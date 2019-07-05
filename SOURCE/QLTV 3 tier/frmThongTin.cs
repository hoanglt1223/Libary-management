using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace QLTV
{
    public partial class frmThongTin : MetroForm
    {
        private frmMain parentForm;
        public frmThongTin(frmMain parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmThongTin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.Opacity = 1;
            this.parentForm.showInfo();
        }

    }
}
