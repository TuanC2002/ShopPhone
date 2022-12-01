using Shop.Resources.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop
{
    public partial class Form3 : Form
    {
        DataProvider provider = new DataProvider();
        int i = 1;
        public string id = "";
        public string color_phone = "";
        public Form3(DataRow data)
        {


            InitializeComponent();
            //
            id = data[0].ToString();
            string query = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.INFO WHERE NAME_SERIES = '" + data[5].ToString() + "'";
            DataTable df = provider.excuteQuery(query);
            DataRow row = df.Rows[0];
            //
            path(data);
            name_phone(data);
            picture_phone(data);
            price_phone(data);
            info(row);
            color(data);
            //
            //Info
            //

        }
        private Label create(DataRow data, int i)
        {
            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.Location = new System.Drawing.Point(734, 275);
            lbl.Name = "label";
            lbl.Size = new System.Drawing.Size(85, 29);
            if (i == -1) { lbl.Text = ">"; }
            else { lbl.Text = data[i].ToString(); }
            return lbl;
        }

        private void create_info(string name, DataRow row, ref int i)
        {
            //create label name
            Label lblName = new Label();
            lblName.AutoSize = true;
            lblName.BackColor = System.Drawing.Color.Transparent;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblName.Name = "label3";
            lblName.Size = new System.Drawing.Size(177, 24);
            lblName.TabIndex = 0;
            lblName.AutoSize = true;
            lblName.Text = name;
            //create label info
            Label lblInfo = new Label();
            lblInfo.AutoSize = true;
            lblInfo.BackColor = System.Drawing.Color.Transparent;
            lblInfo.Name = "lblInfo";
            lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblInfo.TabIndex = 1;
            lblInfo.AutoSize = true;
            lblInfo.MinimumSize = new System.Drawing.Size(330, 0);
            lblInfo.MaximumSize = new System.Drawing.Size(330, 0);
            if (row[i].ToString() == "_" && row[i].ToString() == "") { lblInfo.Text = ""; }
            else { lblInfo.Text = row[i].ToString(); }
            //create panel
            Panel pnl = new Panel();
            pnl.BackColor = System.Drawing.Color.White;
            //pnl.AutoSize = true;
            pnl.Controls.Add(lblInfo);
            pnl.Controls.Add(lblName);
            pnl.Location = new System.Drawing.Point(8, 48);
            pnl.Name = "pnl";
            pnl.Size = new System.Drawing.Size(450, 120);
            pnl.TabIndex = 1;
            lblName.Location = new System.Drawing.Point(11, 24);
            lblInfo.Location = new System.Drawing.Point(203, 24);
            pnl.AutoSize = true;
            i++;
            flowLayoutPanelInfo.Controls.Add(pnl);
        }
        private Label create_lbl(string name)
        {
            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.Location = new System.Drawing.Point(3, 0);
            lbl.Name = "label2";
            lbl.Size = new System.Drawing.Size(118, 29);
            lbl.TabIndex = 0;
            lbl.Text = name;
            return lbl;
        }
        private void path(DataRow data)
        {
            flowLayoutPanelTree.Controls.Add(create(data, -1));
            flowLayoutPanelTree.Controls.Add(create(data, 2));
            flowLayoutPanelTree.Controls.Add(create(data, -1));
            flowLayoutPanelTree.Controls.Add(create(data, 5));
            flowLayoutPanelTree.Controls.Add(create(data, -1));
            flowLayoutPanelTree.Controls.Add(create(data, 1));
        }
        private void name_phone(DataRow data)
        {
            labelName.Text = data[1].ToString() + " | " + data[3].ToString() + " GB rom - " + data[4].ToString() + " GB ram";
        }
        private void picture_phone(DataRow data)
        {
            string url = Application.StartupPath + "\\phone\\phone\\" + String.Concat(data[1].ToString().Where(c => !Char.IsWhiteSpace(c))) + ".png";
            Bitmap pic = new Bitmap(url); picPhoneMain.BackgroundImage = pic;
        }
        private void price_phone(DataRow data)
        {
            labelPrice.Text = Int32.Parse(data[6].ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " ₫";
        }
        private void info(DataRow row)
        {
            create_info("Kích thước màn hình", row, ref i);
            create_info("Công nghệ màn hình", row, ref i);
            create_info("Tần số quét", row, ref i);
            flowLayoutPanelInfo.Controls.Add(create_lbl("Camera sau"));
            create_info("Camera sau", row, ref i);
            create_info("Quay video", row, ref i);
            create_info("Tính năng camera", row, ref i);
            flowLayoutPanelInfo.Controls.Add(create_lbl("Camera trước"));
            create_info("Camera trước", row, ref i);
            create_info("Quay video", row, ref i);
            flowLayoutPanelInfo.Controls.Add(create_lbl("Vi xử lý và đồ họa"));
            create_info("Chipset", row, ref i);
            create_info("GPU", row, ref i);
            flowLayoutPanelInfo.Controls.Add(create_lbl("Pin và công nghệ sạc"));
            create_info("Pin", row, ref i);
            create_info("Công nghệ sạc", row, ref i);
            create_info("Cổng sạc", row, ref i);
            flowLayoutPanelInfo.Controls.Add(create_lbl("Giao tiếp và kết nối"));
            create_info("Thẻ SIM", row, ref i);
            create_info("Hệ điều hành", row, ref i);
            create_info("Jack tai nghe 3.5", row, ref i);
            create_info("Wi-Fi", row, ref i);
            flowLayoutPanelInfo.Controls.Add(create_lbl("Thiết kế và Trọng lượng"));
            create_info("Kích thước", row, ref i);
            create_info("Trọng lượng", row, ref i);
            flowLayoutPanelInfo.Controls.Add(create_lbl("Tiện ích khác"));
            create_info("Cảm biến vân tay", row, ref i);
            create_info("Các loại cảm biến", row, ref i);
            create_info("Tính năng đặc biệt", row, ref i);
        }
        private Panel create_panel(DataRow data, string pathimg, string path)
        {
            //create button
            Button btn = new Button();
            Bitmap pic = new Bitmap(pathimg); btn.BackgroundImage = pic;
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn.Name = "button1";
            btn.Size = new System.Drawing.Size(98, 103);
            btn.UseVisualStyleBackColor = true;
            btn.Click += (sender, e) => Onclick(this, e, path, pathimg.ToString().Split('\\')[9].ToString().Split('.')[0].ToString());
            //create label
            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.Name = "label3";
            lbl.Size = new System.Drawing.Size(58, 25);
            lbl.TabIndex = 1;
            lbl.Text = pathimg.ToString().Split('\\')[9].ToString().Split('.')[0].ToString();
            //create panel
            Panel pnl = new Panel();
            pnl.Controls.Add(btn);
            pnl.Controls.Add(lbl);
            pnl.Name = "panel1";
            pnl.Size = new System.Drawing.Size(103, 140);
            btn.Location = new System.Drawing.Point(3, 3);
            lbl.Location = new System.Drawing.Point(24, 109);
            return pnl;

        }
        public void Onclick(object sender, EventArgs e, string path, string color_name)
        {
            color_phone = color_name;
            string url = path + "\\" + color_name + ".jpg";
            Bitmap pic = new Bitmap(url); picPhoneMain.BackgroundImage = pic;
        }
        private void color(DataRow data)
        {
            string path = Application.StartupPath + "\\phone\\" + String.Concat(data[1].ToString().Where(c => !Char.IsWhiteSpace(c)));
            string[] filePaths = Directory.GetFiles(path, "*.jpg");
            foreach (string pathimg in filePaths)
            {
                flowLayoutPanelColor.Controls.Add(create_panel(data, pathimg, path));
            }
        }
        private void excuteform2(string sqlcmd)
        {
            Form2 form = new Form2(sqlcmd);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY LIKE '%" + textBoxSearch.Text + "%'";
            excuteform2(sqlcmd);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (color_phone == "")
            {
                MessageBox.Show("Vui lòng chọn màu cho sản phẩm");
            }
            else
            {
                string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DON_HANG WHERE ID_PHONE = " + id + "AND COLOR = '" + color_phone + "'";
                DataTable tmp = provider.excuteQuery(sqlcmd);
                bool hasRows = tmp.Rows.GetEnumerator().MoveNext();
                if (hasRows == true)
                {
                    DataRow temp = tmp.Rows[0];
                    int count = Int32.Parse(temp[3].ToString()) + 1;
                    sqlcmd = "UPDATE SHOPPING_MOBIPHONE.dbo.DON_HANG SET SO_LUONG = " + count.ToString() + " WHERE ID = " + temp[0].ToString();
                    provider.excuteNonquery(sqlcmd);
                    MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng");
                }
                else
                {
                    sqlcmd = "INSERT INTO SHOPPING_MOBIPHONE.dbo.DON_HANG (ID_PHONE, COLOR, SO_LUONG) VALUES ('" + id + "', '" + color_phone + "',1)";
                    provider.excuteNonquery(sqlcmd);
                    MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng");
                }
            }
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (color_phone == "")
            {
                MessageBox.Show("Vui lòng chọn màu cho sản phẩm");
            }
            else
            {
                string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DON_HANG WHERE ID_PHONE = " + id + "AND COLOR = '" + color_phone + "'";
                DataTable tmp = provider.excuteQuery(sqlcmd);
                bool hasRows = tmp.Rows.GetEnumerator().MoveNext();
                if (hasRows == true)
                {
                    DataRow temp = tmp.Rows[0];
                    int count = Int32.Parse(temp[3].ToString()) + 1;
                    sqlcmd = "UPDATE SHOPPING_MOBIPHONE.dbo.DON_HANG SET SO_LUONG = " + count.ToString() + " WHERE ID = " + temp[0].ToString();
                    provider.excuteNonquery(sqlcmd);
                }
                else
                {
                    sqlcmd = "INSERT INTO SHOPPING_MOBIPHONE.dbo.DON_HANG (ID_PHONE, COLOR, SO_LUONG) VALUES ('" + id + "', '" + color_phone + "',1)";
                    provider.excuteNonquery(sqlcmd);
                }
                Form4 form = new Form4();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1(1);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
