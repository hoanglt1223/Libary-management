using MetroFramework.Forms;
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
using DTO;
using BUS;

namespace QLTV
{
    public partial class frmCapNhatTheLoai : MetroForm
    {
        private Form parentForm;
        public frmCapNhatTheLoai(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmCapNhatTheLoai_Load(object sender, EventArgs e)
        {
            txtMaTL.ReadOnly = true;
            txtTenTL.ReadOnly = true;
            btnOkThem.Hide();
            btnCancel.Hide();
            btnOkSua.Hide();
            HienThiDuLieu();
            dgvTheLoai.ReadOnly = true;
        }

        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvTheLoai.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTheLoai.Columns.Count; j++)
                {
                    if (dgvTheLoai.Rows[i].Cells[j].Selected == true)
                    {
                        txtMaTL.Text = dgvTheLoai.Rows[i].Cells[0].Value.ToString();
                        txtTenTL.Text = dgvTheLoai.Rows[i].Cells[1].Value.ToString();
                    }
                }
            }
        }
        private void HienThiDuLieu()
        {
            this.dgvTheLoai.DataSource = null;
            this.dgvTheLoai.DataSource = BUS_OBJ.loadDSTheLoai();

            dgvTheLoai.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvTheLoai.Columns[0].HeaderText = "Mã thể loại";
            dgvTheLoai.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvTheLoai.Columns[1].HeaderText = "Tên thể loại";
           
            foreach (DataGridViewColumn col in dgvTheLoai.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Thêm mới thể loại:";
            txtMaTL.ReadOnly = false;
            txtTenTL.ReadOnly = false;
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            btnOkThem.Show();
            btnCancel.Show();
            btnOkSua.Hide();
            txtMaTL.Focus();
        }

        private void btnOkThem_Click(object sender, EventArgs e)
        {
            if ((txtMaTL.Text != "") && (txtTenTL.Text != ""))
            {
                try
                {
                    TheLoai_DTO theLoai = new TheLoai_DTO(txtMaTL.Text, txtTenTL.Text);
                    BUS_OBJ.themTL(theLoai);
                    HienThiDuLieu();
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Mã thể loại bị trùng. \nKhông thể thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnCancel_Click(sender, e);
                    //if (conn.State == ConnectionState.Open) conn.Close();
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Nhập thiếu dữ liệu.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtTenTL.Text == "") txtTenTL.Focus();
                if (txtMaTL.Text == "") txtMaTL.Focus();
            }
            //btnCancel_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Thông tin thể loại:";
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            txtMaTL.ReadOnly = true;
            txtTenTL.ReadOnly = true;
            btnOkThem.Hide();
            btnOkSua.Hide();
            btnCancel.Hide();
            txtMaTL.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Text != "")
            {
                gbInfo.Text = "Sửa thông tin thể loại:";
                txtMaTL.ReadOnly = true;
                txtTenTL.ReadOnly = false;
                btnOkThem.Hide();
                btnOkSua.Show();
                btnCancel.Show();
                txtTenTL.Focus();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn thể loại muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel_Click(sender, e);
            }
        }

        private void btnOkSua_Click(object sender, EventArgs e)
        {
            if ((txtMaTL.Text != "") && (txtTenTL.Text != ""))
            {
                try
                {
                    TheLoai_DTO theLoai = new TheLoai_DTO(txtMaTL.Text, txtTenTL.Text);
                    BUS_OBJ.suaTL(theLoai);
                    HienThiDuLieu();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this,ex.Message);
                }
                finally
                {
                    btnCancel_Click(sender, e);
                    //if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Nhập thiếu dữ liệu.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtTenTL.Text == "") txtTenTL.Focus();
                if (txtMaTL.Text == "") txtMaTL.Focus();
            } 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Text != "")
            {
                DialogResult thongbao;
                thongbao = (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc chắn muốn xóa? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    try
                    {
                        BUS_OBJ.xoaTL(txtMaTL.Text);
                        MetroFramework.MetroMessageBox.Show(this, "Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDuLieu();
                    }
                    catch (Exception)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Không thể xóa thể loại đang có sách. \nVui lòng xem lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn một thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel_Click(sender, e);
            }
        }

        private void frmCapNhatTheLoai_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
        }
    }
}
