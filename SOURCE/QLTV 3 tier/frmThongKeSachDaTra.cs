using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;


namespace QLTV
{
    public partial class frmThongKeSachDaTra : MetroForm
    {
        private Form parentForm;
        public frmThongKeSachDaTra(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmThongKeSachDaTra_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            DataTable dt = BUS.BUS_OBJ.loadDSPhieuMuonDaTra();
            this.reportViewer1.RefreshReport();
            //System.IO.Stream report = new System.IO.Stream();
            //reportViewer1.LocalReport.LoadReportDefinition();
            reportViewer1.LocalReport.ReportPath = "rptSachDaTra.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource newDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("dsSachDaTra", dt);
            reportViewer1.LocalReport.DataSources.Add(newDataSource);
            reportViewer1.RefreshReport();
        }

        private void frmThongKeSachDaTra_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
