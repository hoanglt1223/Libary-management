using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace QLTV
{
    public partial class frmDoiMK : MetroForm
    {
        private DTO.DangNhap_DTO user;
        private frmMain parentForm;
        public frmDoiMK(frmMain parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
        public void receivingData(DangNhap_DTO user)
        {
            this.user = user;     
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text != "" && txtMKMoi1.Text != "" && txtMKMoi2.Text != "")
            {
                if (txtMKMoi1.Text != txtMKMoi2.Text)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Nhập mật khẩu không trùng nhau. \nMời nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKCu.Text = "";
                    txtMKMoi1.Text = "";
                    txtMKMoi2.Text = "";
                    txtMKCu.Focus();
                }
                else
                {
                    if (txtMKCu.Text == user.MatKhau)
                    {
                        BUS_OBJ.doiMK(user.TenDangNhap, txtMKMoi1.Text);
                        MetroFramework.MetroMessageBox.Show(this,"Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        user.MatKhau = txtMKMoi1.Text;
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Sai mật khẩu cũ. \nMời nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMKCu.Text = "";
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtMKMoi2.Text == "") txtMKMoi2.Focus();
                if (txtMKMoi1.Text == "") txtMKMoi1.Focus();
                if (txtMKCu.Text == "") txtMKCu.Focus();
            }
        }

        private void frmDoiMK_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
            this.parentForm.showInfo();
        }
    }
}
