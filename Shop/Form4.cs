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
    public partial class Form4 : Form
    {
        Int64 FinalPrice = 0;
        int check = 0;
        DataProvider provider = new DataProvider();
        public Form4()
        {
            InitializeComponent();
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DON_HANG";
            DataTable df = provider.excuteQuery(sqlcmd);
            bool hasRows = df.Rows.GetEnumerator().MoveNext();
            if (hasRows == false)
            {
                Label lbl = new Label();
                lbl.BackColor = System.Drawing.Color.Transparent;
                lbl.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold);
                lbl.ForeColor = System.Drawing.Color.Black;
                lbl.Name = "label2";
                lbl.Size = new System.Drawing.Size(720, 720);
                lbl.Text = "Giỏ hàng rỗng";
                flowLayoutPanelPhone.Controls.Add(lbl);
            }
            else { Show_phone(df);check = 1; };
        }
        private void Show_phone(DataTable df)
        {
            foreach (DataRow row in df.Rows)
            {
                string query = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO NAME_PHONE WHERE ID = " + row[1].ToString();
                DataTable tmp = provider.excuteQuery(query);
                DataRow data2 = tmp.Rows[0];
                flowLayoutPanelPhone.Controls.Add(create_panel(row, data2));
                FinalPrice += (Int32.Parse(data2[6].ToString()) * Int32.Parse(row[3].ToString()));
            }
            labelFinalPrice.Text = Int64.Parse(FinalPrice.ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " đ";
        }
        private void Show_finalphone(DataTable df)
        {
            foreach (DataRow row in df.Rows)
            {
                string query = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO NAME_PHONE WHERE ID = " + row[1].ToString();
                DataTable tmp = provider.excuteQuery(query);
                DataRow data2 = tmp.Rows[0];
                flowLayoutPanelFinal.Controls.Add(create_finalpanel(row, data2));
            } 
        }
        private Panel create_panel(DataRow row, DataRow data2)
        {
            //create picture box
            PictureBox pic = new PictureBox();
            pic.Name = "pic";
            pic.Size = new System.Drawing.Size(200, 200);
            pic.TabStop = false;
            pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            string path = Application.StartupPath + "\\phone\\" + String.Concat(data2[1].ToString().Where(c => !Char.IsWhiteSpace(c))) + "\\" + row[2].ToString() + ".jpg";
            Bitmap picpath = new Bitmap(path); pic.BackgroundImage = picpath;
            //create label name
            Label lbl_name = new Label();
            lbl_name.AutoSize = true;
            lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new System.Drawing.Size(572, 29);
            lbl_name.TabIndex = 1;
            lbl_name.Text = data2[1].ToString()+"\n"+ data2[3].ToString() + " GB rom - " + data2[4].ToString() + " GB ram - "+row[2].ToString();
            //create label price
            Label lbl_price = new Label();
            lbl_price.AutoSize = true;
            lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_price.ForeColor = System.Drawing.Color.Red;
            lbl_price.Name = "label4";
            lbl_price.Size = new System.Drawing.Size(162, 29);
            lbl_price.TabIndex = 2;
            lbl_price.Text = Int32.Parse(data2[6].ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " ₫";
            // create label so luong
            Label label5 = new Label();
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(152, 25);
            label5.Text = "Chọn số lượng";
            //create numberic
            NumericUpDown updown = new NumericUpDown();
            updown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updown.Name = "updown";
            updown.Size = new System.Drawing.Size(120, 24);
            updown.TabIndex = 4;
            updown.Value = Int32.Parse(row[3].ToString());
            updown.Minimum = 1;
            updown.ValueChanged += (sender, e)=> TextChanged(this, e, row[0].ToString(),row,Int32.Parse(updown.Value.ToString()), Int32.Parse(data2[6].ToString()));
            //create button delete
            Button buttonDelete = new Button();
            buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            buttonDelete.BackgroundImage = Properties.Resources.delete;
            buttonDelete.Name = "button1";
            buttonDelete.Size = new System.Drawing.Size(40, 40);
            buttonDelete.TabIndex = 0;
            buttonDelete.UseVisualStyleBackColor = true;
            //create panel
            Panel pnl = new Panel();
            pnl.Name = "pnl";
            pnl.Size = new System.Drawing.Size(809, 268);
            pnl.TabIndex = 0;
            //pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl.Controls.Add(pic);
            pnl.Controls.Add(updown);
            pnl.Controls.Add(label5);
            pnl.Controls.Add(lbl_price);
            pnl.Controls.Add(lbl_name);
            pnl.Controls.Add(buttonDelete);
            buttonDelete.Click += (sender, e) => Onclick(this, e, row[0].ToString(), pnl, Int32.Parse(updown.Value.ToString()), Int32.Parse(data2[6].ToString()));
            buttonDelete.Location = new System.Drawing.Point(545, 0);
            pic.Location = new System.Drawing.Point(10, 34);
            lbl_name.Location = new System.Drawing.Point(216, 34);
            lbl_price.Location = new System.Drawing.Point(216, 128);
            label5.Location = new System.Drawing.Point(216, 194);
            updown.Location = new System.Drawing.Point(391, 197);
            return pnl;
        }
        private Panel create_finalpanel(DataRow row, DataRow data2)
        {
            //create picture box
            PictureBox pic = new PictureBox();
            pic.Name = "pic";
            pic.Size = new System.Drawing.Size(200, 200);
            pic.TabStop = false;
            pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            string path = Application.StartupPath + "\\phone\\" + String.Concat(data2[1].ToString().Where(c => !Char.IsWhiteSpace(c))) + "\\" + row[2].ToString() + ".jpg";
            Bitmap picpath = new Bitmap(path); pic.BackgroundImage = picpath;
            //create label name
            Label lbl_name = new Label();
            lbl_name.AutoSize = true;
            lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new System.Drawing.Size(572, 29);
            lbl_name.TabIndex = 1;
            lbl_name.Text = data2[1].ToString() + "\n" + data2[3].ToString() + " GB rom - " + data2[4].ToString() + " GB ram - " + row[2].ToString();
            //create label price
            Label lbl_price = new Label();
            lbl_price.AutoSize = true;
            lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_price.ForeColor = System.Drawing.Color.Red;
            lbl_price.Name = "label4";
            lbl_price.Size = new System.Drawing.Size(162, 29);
            lbl_price.TabIndex = 2;
            lbl_price.Text = Int32.Parse(data2[6].ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " ₫";
            // create label so luong
            Label label5 = new Label();
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(152, 25);
            label5.Text = "Số lượng";
            //create numberic
            Label updown = new Label();
            updown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updown.Name = "updown";
            updown.Size = new System.Drawing.Size(120, 24);
            updown.TabIndex = 4;
            updown.Text = row[3].ToString();
            //create panel
            Panel pnl = new Panel();
            pnl.Name = "pnl";
            pnl.Size = new System.Drawing.Size(809, 268);
            pnl.TabIndex = 0;
            pnl.Controls.Add(pic);
            pnl.Controls.Add(updown);
            pnl.Controls.Add(label5);
            pnl.Controls.Add(lbl_price);
            pnl.Controls.Add(lbl_name);
            pic.Location = new System.Drawing.Point(10, 34);
            lbl_name.Location = new System.Drawing.Point(216, 34);
            lbl_price.Location = new System.Drawing.Point(216, 128);
            label5.Location = new System.Drawing.Point(216, 194);
            updown.Location = new System.Drawing.Point(391, 197);
            return pnl;
        }
        private void TextChanged(object sender, EventArgs e,string id, DataRow row, int value, int price)
        {
            int prevalue = Int32.Parse(row[3].ToString());
            if (prevalue ==1 && value == 1)
            {
                MessageBox.Show("Số lượng sản phẩm đã đạt tối thiểu");
            }
            else
            {
                Int64 Final = FinalPrice;
                Final += ((value - prevalue) * price);
                labelFinalPrice.Text = Int64.Parse(Final.ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " đ";
                FinalPrice = Final;
                //update sql
                string sqlcmd = "UPDATE SHOPPING_MOBIPHONE.dbo.DON_HANG SET SO_LUONG = " + value.ToString() + " WHERE ID = " + id;
                provider.excuteNonquery(sqlcmd);
                row[3] = value;
            }
        }

        public void Onclick(object sender, EventArgs e, string id, Panel pnl, int value, int price)
        {
            string sqlcmd = "DELETE FROM SHOPPING_MOBIPHONE.dbo.DON_HANG WHERE ID = " + id;
            provider.excuteNonquery(sqlcmd);
            flowLayoutPanelPhone.Controls.Remove(pnl);
            FinalPrice -= (value * price);
            labelFinalPrice.Text = Int64.Parse(FinalPrice.ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " đ";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int voucher = 0;
        private void btnVoucher_Click(object sender, EventArgs e)
        {
            if (textBoxVoucher.Text != "")
            {
                string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.VOUCHER WHERE CODE = '"+ textBoxVoucher.Text+"'";
                DataTable df = provider.excuteQuery(sqlcmd);
                bool hasRows = df.Rows.GetEnumerator().MoveNext();
                if (hasRows == true)
                {
                    DataRow result = df.Rows[0];
                    FinalPrice -= Int32.Parse(result[1].ToString());
                    labelFinalPrice.Text = Int64.Parse(FinalPrice.ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " đ";
                    MessageBox.Show("Áp dụng voucher thành công");
                    voucher = Int32.Parse(result[1].ToString());
                }
                else { MessageBox.Show("Nhập sai hoặc voucher không còn khả dụng"); }
            }
            else { MessageBox.Show("Vui lòng nhập voucher"); }
            
            
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (FinalPrice == 0)
            {
                MessageBox.Show("Giỏ hàng rỗng");
            }
            else if (textBoxName.Text == "" || textBoxSdt.Text == "" || textBoxCity.Text == "" || textBoxDistrict.Text == "" || textBoxHome.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                panelDatHang.Visible = true;
                labelNameDatHang.Text = textBoxName.Text + " | " + textBoxSdt.Text;
                labeldiachi.Text = textBoxHome.Text + ", " + textBoxDistrict.Text + ", " + textBoxCity.Text;
                labelVoucher.Text = textBoxVoucher.Text;
                string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DON_HANG";
                DataTable df2 = provider.excuteQuery(sqlcmd);
                Show_finalphone(df2);
                Int64 tmp = FinalPrice + voucher;
                labelPrice.Text = Int64.Parse(tmp.ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " đ";
                labelVoucher2.Text = "- " + Int32.Parse(voucher.ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " đ";
                tmp = tmp - voucher + 20000;
                label25.Text = Int64.Parse(tmp.ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " đ";
            }  
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
                string sqlcmd = "INSERT INTO SHOPPING_MOBIPHONE.dbo.DS_DON_HANG(NAME_CUS, PHONE_NUMBER,HOME,VOUCHER,FinalPrice)" +
                                "VALUES('" + textBoxName.Text + "','" + textBoxSdt.Text + "','" + labeldiachi.Text + "'," + voucher + ",'" + label25.Text + " ')";
                provider.excuteNonquery(sqlcmd);
                sqlcmd = "SELECT TOP 1 * FROM SHOPPING_MOBIPHONE.dbo.DS_DON_HANG ORDER BY ID DESC";
                DataTable df = provider.excuteQuery(sqlcmd);
                DataRow row = df.Rows[0];
            sqlcmd = "SELECT SHOPPING_MOBIPHONE.dbo.PHONE_INFO.NAME_PHONE, SHOPPING_MOBIPHONE.dbo.PHONE_INFO.RAM, SHOPPING_MOBIPHONE.dbo.PHONE_INFO.ROM, SHOPPING_MOBIPHONE.dbo.PHONE_INFO.PRICE,SHOPPING_MOBIPHONE.dbo.DON_HANG.COLOR,SHOPPING_MOBIPHONE.dbo.DON_HANG.SO_LUONG  INTO DS_PHONE" + row[0].ToString() +
                        " FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO , SHOPPING_MOBIPHONE.dbo.DON_HANG" +
                        " WHERE SHOPPING_MOBIPHONE.dbo.DON_HANG.ID = SHOPPING_MOBIPHONE.dbo.PHONE_INFO.ID ";
            provider.excuteNonquery(sqlcmd);
            MessageBox.Show("Đặt hàng thành công");
            this.Close();
            sqlcmd = "DELETE FROM SHOPPING_MOBIPHONE.dbo.DON_HANG";
            provider.excuteNonquery(sqlcmd);
            Form5 f = new Form5(row[0].ToString());
                this.Hide();
                f.ShowDialog();
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
