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
using DTO;
using BUS;

namespace QLTV
{
    public partial class frmTaoMoiTKNV : MetroForm
    {
        private frmMain parentForm;
        public frmTaoMoiTKNV(frmMain parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmTaoMoiTKNV_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text != "" && txtMK.Text != "" && txtMK1.Text != "")
            {
                if (txtMK.Text != txtMK1.Text)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Nhập mật khẩu không trùng nhau. \nMời nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMK1.Text = "";
                    txtMK.Text = "";
                    txtMK1.Focus();
                }
                else
                {
                    try
                    {
                        BUS_OBJ.taoMoiTKNV(txtTenDN.Text, txtMK.Text);
                        MetroFramework.MetroMessageBox.Show(this, "Tạo mới tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenDN.Focus();
                    }
                    finally
                    {
                        //if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtMK1.Text == "") txtMK1.Focus();
                if (txtMK.Text == "") txtMK.Focus();
                if (txtTenDN.Text == "") txtTenDN.Focus();
            }
        }

        private void frmTaoMoiTKNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
            this.parentForm.showInfo();
        }
    }
}
