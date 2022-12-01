using Shop.Resources.DAO;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Shop
{
    public partial class Form1 : Form
    {
        DataProvider provider = new DataProvider();
        FilterInfoCollection filter;
        VideoCaptureDevice videocapture;
        public Form1(int i)
        {
           
            InitializeComponent();
            timer1.Start();
            if (i == 1)
            {
                panelDonHang.Visible = true;
                string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DS_DON_HANG";
                DataTable infoOrder = provider.excuteQuery(sqlcmd);
                foreach (DataRow row in infoOrder.Rows)
                {
                    flowLayoutPanelOrder.Controls.Add(create_panel(row));
                }
            }
        }
        int time = 9;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time % 9 == 0)
            {
                pictureBoxAd.BackgroundImage = Properties.Resources.fold4;
            }
            if (time % 10 == 0)
            {
                pictureBoxAd.BackgroundImage = Properties.Resources.XIAOMI1;
            }
            if (time % 11 == 0)
            {
                pictureBoxAd.BackgroundImage = Properties.Resources._12t;
            }
            if (time % 12 == 0)
            {
                pictureBoxAd.BackgroundImage = Properties.Resources.iphone;
            }
            if (time > 12) { time = 9; }
        }

        private void buttonXiaomi_MouseHover(object sender, EventArgs e)
        {
            panelXiaomi.Visible = true;
            panelApple.Visible = false;
            panelSamsung.Visible = false;
        }


        private void buttonApple_MouseHover(object sender, EventArgs e)
        {
            panelApple.Visible = true;
            panelXiaomi.Visible = false;
            panelSamsung.Visible = false;
        }
        private void buttonSamsung_MouseHover(object sender, EventArgs e)
        {
            panelSamsung.Visible = true;
            panelApple.Visible = false;
            panelXiaomi.Visible = false;
        }
        private void excuteform3(DataRow dataR)
        {
            Form3 form = new Form3(dataR);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void excuteform2(string sqlcmd)
        {
            Form2 form = new Form2(sqlcmd);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE ID = '7'";
            excuteform3(provide(sqlcmd));
        }
        private DataRow provide(string sqlcmd)
        {
            string query = sqlcmd;
            DataTable data = new DataTable();
            data = provider.excuteQuery(query);
            DataRow dataR = data.Rows[0];
            return dataR;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE ID = '27'";
            excuteform3(provide(sqlcmd));
        }

        private void button65_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE ID = '65'";
            excuteform3(provide(sqlcmd));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE ID = '15'";
            excuteform3(provide(sqlcmd));
        }

        private void button50_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE ID = '50'";
            excuteform3(provide(sqlcmd));
        }

        private void pictureBoxAd_MouseHover(object sender, EventArgs e)
        {
            panelApple.Visible = false;
            panelXiaomi.Visible = false;
            panelSamsung.Visible = false;
        }

        private void buttonXiaomi_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE COMPANY = 'Xiaomi'";
            excuteform2(sqlcmd);
        }

        private void buttonApple_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE COMPANY = 'Apple'";
            excuteform2(sqlcmd);
        }

        private void buttonSamsung_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE COMPANY = 'Sam sung'";
            excuteform2(sqlcmd);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '"+label16.Text+"'";
            excuteform2(sqlcmd);
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label16.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            label15.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + label15.Text + "'";
            excuteform2(sqlcmd);
        }
        private void label14_MouseHover(object sender, EventArgs e)
        {
            label14.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }
        private void label14_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + label14.Text + "'";
            excuteform2(sqlcmd);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + label13.Text + "'";
            excuteform2(sqlcmd);
        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            label13.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + label10.Text + "'";
            excuteform2(sqlcmd);
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + label9.Text + "'";
            excuteform2(sqlcmd);
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + label8.Text + "'";
            excuteform2(sqlcmd);
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void labelPOCO_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + labelPOCO.Text + "'";
            excuteform2(sqlcmd);
        }

        private void labelPOCO_MouseHover(object sender, EventArgs e)
        {
            labelPOCO.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void labelRedmi9_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + labelRedmi9.Text + "'";
            excuteform2(sqlcmd);
        }

        private void labelRedmi9_MouseHover(object sender, EventArgs e)
        {
            labelRedmi9.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + label4.Text + "'";
            excuteform2(sqlcmd);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + label5.Text + "'";
            excuteform2(sqlcmd);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE CATEGORY = '" + label6.Text + "'";
            excuteform2(sqlcmd);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void labelPOCO_MouseLeave(object sender, EventArgs e)
        {
            labelPOCO.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void labelRedmi9_MouseLeave(object sender, EventArgs e)
        {
            labelRedmi9.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO WHERE NAME_PHONE LIKE '%" + textBoxSearch.Text + "%'";
            excuteform2(sqlcmd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonDonHang_Click(object sender, EventArgs e)
        {
            flowLayoutPanelOrder.Visible = true;
            panelDonHang.Visible = true;
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DS_DON_HANG ORDER BY ID DESC";
            DataTable infoOrder = provider.excuteQuery(sqlcmd);
            foreach(DataRow row in infoOrder.Rows)
            {
                flowLayoutPanelOrder.Controls.Add(create_panel(row));
            } 
        }
        private Panel create_panel(DataRow row)
        {
            //Label ma don hang
            Label madonhang = new Label();
            madonhang.AutoSize = true;
            madonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            madonhang.Name = "madonhang";
            madonhang.Size = new System.Drawing.Size(208, 32);
            madonhang.TabIndex = 0;
            madonhang.Text = "Mã đơn hàng: ";
            //Label tong cong
            Label tongcong = new Label();
            tongcong.AutoSize = true;
            tongcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tongcong.Name = "label20";
            tongcong.Size = new System.Drawing.Size(167, 32);
            tongcong.TabIndex = 2;
            tongcong.Text = "Tổng cộng:";
            //Label trangthai
            Label trangthai = new Label();
            trangthai.AutoSize = true;
            trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trangthai.Name = "label22";
            trangthai.Size = new System.Drawing.Size(162, 32);
            trangthai.TabIndex = 4;
            trangthai.Text = "Trạng thái:";
            //Label dangvanchuyen
            Label dangvanchuyen = new Label();
            dangvanchuyen.AutoSize = true;
            dangvanchuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dangvanchuyen.Name = "label21";
            dangvanchuyen.Size = new System.Drawing.Size(250, 32);
            dangvanchuyen.TabIndex = 5;
            dangvanchuyen.Text = "Đang vận chuyển";
            //Label id
            Label lblID = new Label();
            lblID.AutoSize = true;
            lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblID.Name = "label18";
            lblID.Size = new System.Drawing.Size(124, 32);
            lblID.TabIndex = 1;
            lblID.Text = "CS511" + row[0].ToString();
            //label price
            Label lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrice.Name = "label19";
            lblPrice.Size = new System.Drawing.Size(193, 32);
            lblPrice.TabIndex = 3;
            lblPrice.Text = row[5].ToString();
            //panel
            Panel pnlOrder = new Panel();
            pnlOrder.Location = new System.Drawing.Point(3, 3);
            pnlOrder.Name = "panel1";
            pnlOrder.Size = new System.Drawing.Size(468, 163);
            pnlOrder.TabIndex = 0;
            pnlOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            pnlOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlOrder.Controls.Add(madonhang);
            pnlOrder.Controls.Add(tongcong);
            pnlOrder.Controls.Add(trangthai);
            pnlOrder.Controls.Add(dangvanchuyen);
            pnlOrder.Controls.Add(lblID);
            pnlOrder.Controls.Add(lblPrice);
            pnlOrder.Click += (sender, e) => OnClick(this, e, row);
            madonhang.Location = new System.Drawing.Point(7, 13);
            tongcong.Location = new System.Drawing.Point(7, 59);
            trangthai.Location = new System.Drawing.Point(7, 106);
            dangvanchuyen.Location = new System.Drawing.Point(207, 106);
            lblID.Location = new System.Drawing.Point(221, 13);
            lblPrice.Location = new System.Drawing.Point(207, 59);
            return pnlOrder;
        }
        private void OnClick (object sender, EventArgs e, DataRow row)
        {
            label17.Visible = true;
            panelInfo.Visible = true;
            label26.Text = "CS511"+row[0].ToString();
            label27.Text = row[1].ToString();
            label28.Text = row[2].ToString();
            label33.Text = row[3].ToString();
            label31.Text = Int32.Parse(row[4].ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " ₫";
            label32.Text = row[5].ToString();
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DS_PHONE" + row[0].ToString();
            DataTable PhoneInfo = provider.excuteQuery(sqlcmd);
            foreach (DataRow rows in PhoneInfo.Rows)
            {
                flowLayoutPanelPhone.Controls.Add(create_panel_phone(rows));
            }
        }
        private Panel create_panel_phone (DataRow row)
        {
            //Picture
            PictureBox pic = new PictureBox();
            pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic.Name = "pictureBox1";
            pic.Size = new System.Drawing.Size(150, 150);
            pic.TabIndex = 0;
            pic.TabStop = false;
            string url = Application.StartupPath + "\\phone\\phone\\" + String.Concat(row[0].ToString().Where(c => !Char.IsWhiteSpace(c))) + ".png";
            Bitmap pics = new Bitmap(url); pic.BackgroundImage = pics;
            //Labelname
            Label lblName = new Label();
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblName.Name = "label22";
            lblName.Size = new System.Drawing.Size(248, 87);
            lblName.TabIndex = 1;
            lblName.Text = row[0].ToString() + "\r\n" + row[2].ToString() + " gb rom - " + row[1].ToString() + " gb ram\r\n" + row[4].ToString();
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //label so luong
            Label lblNum = new Label();
            lblNum.AutoSize = true;
            lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNum.Name = "label29";
            lblNum.Size = new System.Drawing.Size(134, 29);
            lblNum.TabIndex = 2;
            lblNum.Text = "Số lượng: "+row[5].ToString();
            //label gia
            Label lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrice.Name = "label35";
            lblPrice.Size = new System.Drawing.Size(198, 29);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Giá: "+ Int32.Parse(row[3].ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " ₫";
            //panel
            Panel pnl = new Panel();
            pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl.Location = new System.Drawing.Point(3, 3);
            pnl.Name = "pnl";
            pnl.Size = new System.Drawing.Size(460, 220);
            pnl.TabIndex = 0;
            pnl.Controls.Add(pic);
            pnl.Controls.Add(lblName);
            pnl.Controls.Add(lblNum);
            pnl.Controls.Add(lblPrice);
            lblName.Location = new System.Drawing.Point(184, 8);
            pic.Location = new System.Drawing.Point(10, 5);
            lblNum.Location = new System.Drawing.Point(5, 171);
            lblPrice.Location = new System.Drawing.Point(234, 171);
            return pnl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            flowLayoutPanelPhone.Controls.Clear();
            panelDonHang.Visible = false;
            if (videocapture.IsRunning)
            {
                videocapture.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanelOrder.Visible = false;
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in filter)
            {
                cboDevice.Items.Add(filterinfo.Name);
            }
            cboDevice.SelectedIndex = 0;
            videocapture = new VideoCaptureDevice(filter[cboDevice.SelectedIndex].MonikerString);
            videocapture.NewFrame += CaptureDevice_NewFrame;
            timer2.Start();
            videocapture.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (picQR.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)picQR.Image);
                if (result!= null)
                {
                    Label_id.Text = result.ToString();
                    timer2.Stop();
                    if (videocapture.IsRunning)
                    {
                        videocapture.Stop();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char last = Label_id.Text[Label_id.Text.Length - 1];
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DS_DON_HANG WHERE ID = " + last;
            DataTable data = provider.excuteQuery(sqlcmd);
            DataRow row = data.Rows[0];
            label17.Visible = true;
            panelInfo.Visible = true;
            label26.Text = "CS511" + row[0].ToString();
            label27.Text = row[1].ToString();
            label28.Text = row[2].ToString();
            label33.Text = row[3].ToString();
            label31.Text = Int32.Parse(row[4].ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " ₫";
            label32.Text = row[5].ToString();
            sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DS_PHONE" + row[0].ToString();
            DataTable PhoneInfo = provider.excuteQuery(sqlcmd);
            foreach (DataRow rows in PhoneInfo.Rows)
            {
                flowLayoutPanelPhone.Controls.Add(create_panel_phone(rows));
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (picQR.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)picQR.Image);
                if (result != null)
                {
                    Label_id.Text = result.ToString();
                    timer2.Stop();
                    if (videocapture.IsRunning)
                    {
                        videocapture.Stop();
                    }
                }
            }
        }
    }
}
