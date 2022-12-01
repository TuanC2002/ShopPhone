using Shop.Resources.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form2 : Form
    {
        DataTable data = new DataTable();
        DataProvider provider = new DataProvider();
        public Form2(string sqlcmd)
        {
            InitializeComponent();
            data = provider.excuteQuery(sqlcmd);
            show_phone(data);
        }
        public void show_phone(DataTable data)
        {
            flowLayoutPanel1.Controls.Clear();
            bool hasRows = data.Rows.GetEnumerator().MoveNext();
            if (hasRows == false)
            {
                Label lbl = new Label();
                lbl.BackColor = System.Drawing.Color.Transparent;
                lbl.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold);
                lbl.ForeColor = System.Drawing.Color.Black;
                lbl.Name = "label2";
                lbl.Size = new System.Drawing.Size(720, 720);
                lbl.Text = "Rất tiếc, chúng tôi không tìm được kết quả mong muốn";
                flowLayoutPanel1.Controls.Add(lbl);
            }
            else
            {
                foreach (DataRow row in data.Rows)
                {
                    ///create btn
                    Button btn = new Button();
                    btn.Size = new System.Drawing.Size(268, 386);
                    btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                    string url = Application.StartupPath + "\\phone\\phone\\" + String.Concat(row[1].ToString().Where(c => !Char.IsWhiteSpace(c))) + ".png";
                    Bitmap pic = new Bitmap(url); btn.Image = pic;
                    btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    btn.Text = row[1].ToString() + "\n" + row[3].ToString() + " GB rom - " + row[4].ToString() + " GB ram\n\n\n";
                    btn.Font = Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.ForeColor = System.Drawing.Color.Black;
                    btn.Click += (sender, e) => Onclick(this, e, row);
                    ///create label
                    Label lbl = new Label();
                    lbl.Font = Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbl.Text = Int32.Parse(row[6].ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " ₫";
                    lbl.ForeColor = System.Drawing.Color.Red;
                    lbl.Size = new System.Drawing.Size(389, 59);
                    lbl.BackColor = System.Drawing.Color.Transparent;
                    ///creat panel
                    Panel pnl = new Panel();
                    pnl.Size = new System.Drawing.Size(268, 385);
                    pnl.Controls.Add(btn);
                    btn.Location = new System.Drawing.Point(0, 0);
                    btn.Controls.Add(lbl);
                    lbl.Location = new System.Drawing.Point(60, 350);
                    this.flowLayoutPanel1.Controls.Add(pnl);
                }
            }
        }
        public void Onclick(object sender, EventArgs e, DataRow row)
        {
            row[7] =int.Parse(row[7].ToString())+1;
            string sql_cmd = "UPDATE PHONE_INFO SET COUNT_CLICK = "+row[7].ToString()+" WHERE ID ="+row[0].ToString();
            provider.excuteNonquery(sql_cmd);
            Form3 form = new Form3(row);
            this.Hide();
            form.ShowDialog();
            this.Show();
         }
        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoSeries.SelectedIndex = -1;
            this.comboBoSeries.Items.Clear();
            if (comboBoxCompany.Text == "Xiaomi")
            {
                this.comboBoSeries.Items.AddRange(new object[] {
                "POCO",
                "Redmi 9 series",
                "Xiaomi Note 11 series",
                "Xiaomi 12 series"});
            }
            else if (comboBoxCompany.Text == "Apple")
            {
                this.comboBoSeries.Items.AddRange(new object[] {
                "Iphone 12 series",
                "Iphone 13 series",
                "Iphone 14 series"});
                
            }
            else if (comboBoxCompany.Text == "Sam sung")
            {
                this.comboBoSeries.Items.AddRange(new object[] {
                "Sam sung Z Flip series",
                "Sam sung Z Fold series",
                "Sam sung Note series",
                "Sam sung S series",
                "Sam sung A series"});
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int i = 0;
            string company="";
            string category = "";
            string ram = "";
            string rom = "";
            string price = "";
            if (comboBoxCompany.Text != "")
            {
                i++;
                company = "COMPANY = '" + comboBoxCompany.Text + "' ";

            }
            if (comboBoSeries.Text != "")
            {
                if (i != 0)
                {
                    category = "AND CATEGORY = '" + comboBoSeries.Text + "'";
                }
                else { category = "CATEGORY = '" + comboBoSeries.Text + "'"; }
                i++;
            }
            if (comboBoxRam.Text != "")
            {
                if (i != 0) { ram = "AND "; }
                if (comboBoxRam.Text=="Dưới 4 gb")
                {
                    ram += "ROM <4";
                }
                else if(comboBoxRam.Text == "4gb-6gb")
                {
                    ram += "(RAM BETWEEN 4 AND 6)";
                }
                else if (comboBoxRam.Text == "8gb-12gb")
                {
                    ram += "(RAM BETWEEN 8 AND 12)";
                }
                else { ram += "RAM >12"; }
                i++;
            }
            if (comboBoxRom.Text != "")
            {
                if (i != 0) { rom = "AND "; }
                if (comboBoxRom.Text == "Dưới 32gb")
                {
                    rom += "ROM <= 32";
                }
                else if (comboBoxRom.Text == "32gb và 64gb")
                {
                    rom += "(ROM BETWEEN 32 AND 64)";
                }
                else if (comboBoxRom.Text == "128gb và 216 gb")
                {
                    rom += "(ROM BETWEEN 128 AND 216)";
                }
                else { rom += "ROM >=512"; }
            }
            if (textBoxPriceMin.Text == "") { textBoxPriceMin.Text = "0"; }
            if (textBoxPriceMax.Text == "") { textBoxPriceMax.Text = "0"; }
            if (Int32.Parse(textBoxPriceMax.Text) < Int32.Parse(textBoxPriceMin.Text)) { MessageBox.Show("Lỗi khoảng giá"); }
            else
            {
                if (i != 0) { price = "AND "; }
                price += "(PRICE BETWEEN "+textBoxPriceMin.Text+" AND "+textBoxPriceMax.Text+")";
                string sqlcmd = "select * from phone_info where " + company + category + ram + rom + price;
                DataTable data = provider.excuteQuery(sqlcmd);
                show_phone(data);
            }
            
        }   

        private void buttonDecreate_Click(object sender, EventArgs e)
        {
            if (buttonDecreate.BackColor == Color.White)
            {
                buttonDecreate.BackColor = Color.DeepSkyBlue;
                buttonIncreate.BackColor = Color.White;
                buttoncount_click.BackColor = Color.White;
            }
            data.DefaultView.Sort = "PRICE DESC";
            data = data.DefaultView.ToTable();
            show_phone(data);
        }

        private void buttonIncreate_Click(object sender, EventArgs e)
        {
            if (buttonIncreate.BackColor == Color.White)
            {
                buttonIncreate.BackColor = Color.DeepSkyBlue;
                buttonDecreate.BackColor = Color.White;
                buttoncount_click.BackColor = Color.White;
            }
            data.DefaultView.Sort = "PRICE ASC";
            data = data.DefaultView.ToTable();
            show_phone(data);
        }

        private void buttoncount_click_Click(object sender, EventArgs e)
        {
            if (buttoncount_click.BackColor == Color.White)
            {
                buttonIncreate.BackColor = Color.White;
                buttonDecreate.BackColor = Color.White;
                buttoncount_click.BackColor = Color.DeepSkyBlue;
            }
            data.DefaultView.Sort = "count_click DESC";
            data = data.DefaultView.ToTable();
            show_phone(data);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE NAME_PHONE LIKE '%" + textBoxSearch.Text + "%'"; 
            data = provider.excuteQuery(sqlcmd);
            show_phone(data);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(1);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
