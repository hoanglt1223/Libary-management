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
    public partial class frmThongKeSachTreHan : MetroForm
    {
        private Form parentForm;
        public frmThongKeSachTreHan(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmThongKeSachTreHan_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            DataTable dt = BUS_OBJ.timKiemPhieuMuonTheoTinhTrang("Trễ hạn");
            this.reportViewer1.RefreshReport();
            //System.IO.Stream report = new System.IO.Stream();
            //reportViewer1.LocalReport.LoadReportDefinition();
            reportViewer1.LocalReport.ReportPath = "rptSachTreHan.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource newDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("dsSachTreHan", dt);
            reportViewer1.LocalReport.DataSources.Add(newDataSource);
            reportViewer1.RefreshReport();
        }

        private void frmThongKeSachTreHan_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
        }
    }
}
