using System;
using DevExpress.XtraReports.UI;
// ...

namespace PassParameterToWebReport {
    public partial class _Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            ReportViewer1.Report = CreateReport();
        }

        XtraReport CreateReport() {
            XtraReport1 report = new XtraReport1();
            report.catId.Value = GetSelectedValue(1);
            report.CreateDocument();
            return report;
        }

        int GetSelectedValue(int defaultValue) {
            if(ASPxComboBox1.SelectedItem != null) {
                return Convert.ToInt32(ASPxComboBox1.SelectedItem.Value) + 1;
            }
            else {
                return defaultValue;
            }
        }
    }
}
