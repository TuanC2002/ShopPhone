using Microsoft.Reporting.WinForms;
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
    public partial class Form5 : Form
    {
        DataProvider provider = new DataProvider();
        public Form5(string id)
        {
            InitializeComponent();
            string sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DS_DON_HANG WHERE ID = " + id;
            DataTable df1 = provider.excuteQuery(sqlcmd);
            DataRow rowName = df1.Rows[0];
            sqlcmd = "SELECT * FROM SHOPPING_MOBIPHONE.dbo.DS_PHONE"+rowName[0].ToString();
            DataTable dfPhone = provider.excuteQuery(sqlcmd);
            //
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "D:\\C#\\exx\\Shop\\Shop\\Report1.rdlc";
            ReportDataSource rdsPhone = new ReportDataSource();
            rdsPhone.Name = "DataSetPhone";
            rdsPhone.Value = dfPhone;
            reportViewer1.LocalReport.DataSources.Add(rdsPhone);
            //
            Int64 preprice = Int32.Parse(rowName[4].ToString()) + Int64.Parse(rowName[4].ToString());
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter ("pPrePrice", Int32.Parse(preprice.ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " đ"),
                new ReportParameter ("pCus", rowName[1].ToString()),
                new ReportParameter("pPhoneNumber", rowName[2].ToString()),
                new ReportParameter("pAddress",rowName[3].ToString()),
                new ReportParameter("pVoucher",Int32.Parse(rowName[4].ToString()).ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " đ"),
                new ReportParameter("pPrice",rowName[5].ToString()),
                new ReportParameter("pID","cs511"+rowName[0].ToString())
            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

    }
}
