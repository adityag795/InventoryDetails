using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


namespace Inventory
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

         //   this.reportViewer1.RefreshReport();
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\C#ConsoleCode\WindowsForms\Inventory\Inventory\Reports\CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
          //  this.reportViewer1.RefreshReport();

           

        }
    }
}
