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
    public partial class frmCapNhatNXB : MetroForm
    {
        private Form parentForm;
        public frmCapNhatNXB(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmCapNhatNXB_Load(object sender, EventArgs e)
        {
            txtMaNXB.ReadOnly = true;
            txtTenNXB.ReadOnly = true;
            rtbThongTinNXB.ReadOnly = true;
            rtbThongTinNXB.BackColor = SystemColors.Control;
            btnOkThem.Hide();
            btnCancel.Hide();
            btnOkSua.Hide();
            HienThiDuLieu();
            dgvNXB.ReadOnly = true;
        }

        private void HienThiDuLieu()
        {
            this.dgvNXB.DataSource = null;
            this.dgvNXB.DataSource = BUS_OBJ.loadDSNXB();

            dgvNXB.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNXB.Columns[0].HeaderText = "Mã NXB";
            dgvNXB.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvNXB.Columns[1].HeaderText = "Tên NXB";
            dgvNXB.Columns[1].Width = 200;
            dgvNXB.Columns[2].HeaderText = "Ghi chú";
            foreach (DataGridViewColumn col in dgvNXB.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Thêm mới nhà xuất bản:";
            txtMaNXB.ReadOnly = false;
            txtTenNXB.ReadOnly = false;
            rtbThongTinNXB.ReadOnly = false;
            rtbThongTinNXB.BackColor = SystemColors.Window;
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            rtbThongTinNXB.Text = "";
            btnOkThem.Show();
            btnCancel.Show();
            btnOkSua.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Thông tin nhà xuất bản:";
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            rtbThongTinNXB.Text = "";
            txtMaNXB.ReadOnly = true;
            txtTenNXB.ReadOnly = true;
            rtbThongTinNXB.ReadOnly = true;
            rtbThongTinNXB.BackColor = SystemColors.Control;
            btnOkThem.Hide();
            btnOkSua.Hide();
            btnCancel.Hide();
            txtMaNXB.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text != "")
            {
                gbInfo.Text = "Sửa thông tin NXB:";
                txtMaNXB.ReadOnly = true;
                txtTenNXB.ReadOnly = false;
                rtbThongTinNXB.ReadOnly = false;
                rtbThongTinNXB.BackColor = SystemColors.Window;
                btnOkThem.Hide();
                btnOkSua.Show();
                btnCancel.Show();
                txtTenNXB.Focus();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn NXB muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel_Click(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text != "")
            {
                DialogResult thongbao;
                thongbao = (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc chắn muốn xóa? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    try
                    {
                        BUS_OBJ.xoaNXB(txtMaNXB.Text);
                        MetroFramework.MetroMessageBox.Show(this, "Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDuLieu();
                        btnCancel_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Không thể xóa NXB đang có sách. \nVui lòng xem lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn một NXB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel_Click(sender, e);
            }
            
        }

        private void btnOkThem_Click(object sender, EventArgs e)
        {
            if ((txtMaNXB.Text != "") && (txtTenNXB.Text != ""))
            {
                try
                {
                    NXB_DTO nxb = new NXB_DTO(txtMaNXB.Text, txtTenNXB.Text, rtbThongTinNXB.Text);
                    BUS_OBJ.themNXB(nxb);
                    HienThiDuLieu();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Mã NXB bị trùng. \nKhông thể thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this, "Nhập thiếu dữ liệu.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtTenNXB.Text == "") txtTenNXB.Focus();
                if (txtMaNXB.Text == "") txtMaNXB.Focus();
            }     
        }

        private void btnOkSua_Click(object sender, EventArgs e)
        {
            if ((txtMaNXB.Text != "") && (txtTenNXB.Text != ""))
            {
                try
                {
                    NXB_DTO nxb = new NXB_DTO(txtMaNXB.Text, txtTenNXB.Text, rtbThongTinNXB.Text);
                    BUS_OBJ.suaNXB(nxb);
                    HienThiDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                if (txtTenNXB.Text == "") txtTenNXB.Focus();
                if (txtMaNXB.Text == "") txtMaNXB.Focus();
            }
            
        }

        private void dgvNXB_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvNXB.Rows.Count; i++)
            {
                for (int j = 0; j < dgvNXB.Columns.Count; j++)
                {
                    if (dgvNXB.Rows[i].Cells[j].Selected == true)
                    {
                        txtMaNXB.Text = dgvNXB.Rows[i].Cells[0].Value.ToString();
                        txtTenNXB.Text = dgvNXB.Rows[i].Cells[1].Value.ToString();
                        rtbThongTinNXB.Text = dgvNXB.Rows[i].Cells[2].Value.ToString();
                    }
                }
            }
        }

        private void frmCapNhatNXB_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
        }
    }
}
