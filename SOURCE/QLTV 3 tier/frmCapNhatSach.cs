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
using DTO;
using BUS;

namespace QLTV
{
    public partial class frmCapNhatSach : MetroForm
    {
        private Form parentForm;
        public frmCapNhatSach(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmCapNhatSach_Load(object sender, EventArgs e)
        {
            cboTacGia_LoadDataBase();
            cboTheLoai_LoadDataBase();
            cboNXB_LoadDataBase();
            btnCancel_Click(sender, e);
            btnOkThem.Hide();
            btnCancel.Hide();
            btnOkSua.Hide();
            HienThiDuLieu();
            dgvSach.ReadOnly = true;
        }

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoBanTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvSach.Rows.Count; i++)
                for (int j = 0; j < dgvSach.Columns.Count; j++)
                    if (dgvSach.Rows[i].Cells[j].Selected == true)
                    {
                        txtMaSach.Text = dgvSach.Rows[i].Cells[0].Value.ToString();
                        txtTenSach.Text = dgvSach.Rows[i].Cells[1].Value.ToString();
                        cboTacGia.SelectedValue = dgvSach.Rows[i].Cells[2].Value.ToString();
                        cboTheLoai.SelectedValue = dgvSach.Rows[i].Cells[3].Value.ToString();
                        cboNXB.SelectedValue = dgvSach.Rows[i].Cells[4].Value.ToString();
                        txtNamXB.Text = dgvSach.Rows[i].Cells[5].Value.ToString();
                        txtSoTrang.Text = dgvSach.Rows[i].Cells[6].Value.ToString();
                        txtGia.Text = dgvSach.Rows[i].Cells[7].Value.ToString();
                        txtSoBan.Text = dgvSach.Rows[i].Cells[8].Value.ToString();
                        txtSoBanTon.Text = dgvSach.Rows[i].Cells[9].Value.ToString();
                    }
        }
        private void cboTacGia_LoadDataBase()
        {
            DataTable dt = BUS_OBJ.loadDSTacGia();
            cboTacGia.DataSource = dt;
            cboTacGia.DisplayMember = "TenTacGia";
            cboTacGia.ValueMember = "MaTacGia";
        }
        private void cboTheLoai_LoadDataBase()
        {
            DataTable dt = BUS_OBJ.loadDSTheLoai();
            cboTheLoai.DataSource = dt;
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
        }
        private void cboNXB_LoadDataBase()
        {
            DataTable dt = BUS_OBJ.loadDSNXB();
            cboNXB.DataSource = dt;
            cboNXB.DisplayMember = "TenNXB";
            cboNXB.ValueMember = "MaNXB";
        }
        private void HienThiDuLieu()
        {
            this.dgvSach.DataSource = null;
            this.dgvSach.DataSource = BUS_OBJ.loadDSSach();

            dgvSach.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[1].Width = 260;
            dgvSach.Columns[2].HeaderText = "Mã tác giả";
            
            dgvSach.Columns[3].HeaderText = "Mã thể loại";
            
            dgvSach.Columns[4].HeaderText = "Mã nhà xuất bản";
            
            dgvSach.Columns[5].HeaderText = "Năm xuất bản";
            
            dgvSach.Columns[6].HeaderText = "Số trang";
            
            dgvSach.Columns[7].HeaderText = "Giá";
            
            dgvSach.Columns[8].HeaderText = "Số bản";
            
            dgvSach.Columns[9].HeaderText = "Tồn";
            
            foreach (DataGridViewColumn col in dgvSach.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Thông tin sách:";
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cboTacGia.SelectedValue = "0001";
            cboTheLoai.SelectedValue = "100";
            cboNXB.SelectedValue = "1000";
            txtNamXB.Text = "";
            txtSoTrang.Text = "";
            txtGia.Text = "";
            txtSoBan.Text = "";
            txtSoBanTon.Text = "";
            txtMaSach.ReadOnly = true;
            txtTenSach.ReadOnly = true;
            cboTacGia.Enabled = false;
            cboTheLoai.Enabled = false;
            cboNXB.Enabled = false;
            txtNamXB.ReadOnly = true;
            txtSoTrang.ReadOnly = true;
            txtGia.ReadOnly = true;
            txtSoBan.ReadOnly = true;
            txtSoBanTon.ReadOnly = true;
            btnOkThem.Hide();
            btnOkSua.Hide();
            btnCancel.Hide();
            txtMaSach.Focus();
        }

        private void btnOkThem_Click(object sender, EventArgs e)
        {
            if ((txtMaSach.Text != "") && (txtTenSach.Text != "") && (txtNamXB.Text != "") && (txtSoTrang.Text != "") && (txtGia.Text != "") && (txtSoBan.Text != "") && (txtSoBanTon.Text != "") && (cboTacGia.SelectedValue != null) && (cboTheLoai.SelectedValue != null) && (cboNXB.SelectedValue != null))
            {
                try
                {
                    Sach_DTO sach = new Sach_DTO(txtMaSach.Text, txtTenSach.Text, Convert.ToString(cboTacGia.SelectedValue), Convert.ToString(cboTheLoai.SelectedValue), Convert.ToString(cboNXB.SelectedValue), Convert.ToInt32(txtNamXB.Text), Convert.ToInt32(txtSoTrang.Text), Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtSoBan.Text), Convert.ToInt32(txtSoBanTon.Text));
                    BUS_OBJ.themSach(sach);
                    HienThiDuLieu();
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Mã sách bị trùng. \nKhông thể thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (cboTacGia.SelectedValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Chưa có tác giả này.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTacGia.Focus();
                }
                else if (cboTheLoai.SelectedValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Chưa có thể loại này.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTheLoai.Focus();
                }
                else if (cboNXB.SelectedValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Chưa có NXB này.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboNXB.Focus();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nhập thiếu dữ liệu.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (txtSoBanTon.Text == "") txtSoBanTon.Focus();
                    if (txtSoBan.Text == "") txtSoBan.Focus();
                    if (txtGia.Text == "") txtGia.Focus();
                    if (txtSoTrang.Text == "") txtSoTrang.Focus();
                    if (txtNamXB.Text == "") txtNamXB.Focus();
                    if (txtTenSach.Text == "") txtTenSach.Focus();
                    if (txtMaSach.Text == "") txtMaSach.Focus();
                }
     
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                gbInfo.Text = "Sửa thông tin sách:";
                txtMaSach.ReadOnly = true;
                txtTenSach.ReadOnly = false;
                cboTacGia.Enabled = true;
                cboTheLoai.Enabled = true;
                cboNXB.Enabled = true;
                txtNamXB.ReadOnly = false;
                txtSoTrang.ReadOnly = false;
                txtGia.ReadOnly = false;
                txtSoBan.ReadOnly = false;
                txtSoBanTon.ReadOnly = false;
                btnOkThem.Hide();
                btnOkSua.Show();
                btnCancel.Show();
                txtTenSach.Focus();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn cuốn sách muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel_Click(sender,e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Nhập đầy đủ các thông tin:";
            txtMaSach.ReadOnly = false;
            txtTenSach.ReadOnly = false;
            cboTacGia.Enabled = true;
            cboTheLoai.Enabled = true;
            cboNXB.Enabled = true;
            txtNamXB.ReadOnly = false;
            txtSoTrang.ReadOnly = false;
            txtGia.ReadOnly = false;
            txtSoBan.ReadOnly = false;
            txtSoBanTon.ReadOnly = false;
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cboTacGia.SelectedValue = "0001";
            cboTheLoai.SelectedValue = "100";
            cboNXB.SelectedValue = "1000";
            txtNamXB.Text = "";
            txtSoTrang.Text = "";
            txtGia.Text = "";
            txtSoBan.Text = "";
            txtSoBanTon.Text = "";
            btnOkThem.Show();
            btnCancel.Show();
            btnOkSua.Hide();
            txtMaSach.Focus();
        }

        private void btnOkSua_Click(object sender, EventArgs e)
        {
            if ((txtMaSach.Text != "") && (txtTenSach.Text != "") && (txtNamXB.Text != "") && (txtSoTrang.Text != "") && (txtGia.Text != "") && (txtSoBan.Text != "") && (txtSoBanTon.Text != "") && (cboTacGia.SelectedValue != null) && (cboTheLoai.SelectedValue != null) && (cboNXB.SelectedValue != null))
            {
                try
                {
                    Sach_DTO sach = new Sach_DTO(txtMaSach.Text, txtTenSach.Text, Convert.ToString(cboTacGia.SelectedValue), Convert.ToString(cboTheLoai.SelectedValue), Convert.ToString(cboNXB.SelectedValue), Convert.ToInt32(txtNamXB.Text), Convert.ToInt32(txtSoTrang.Text), Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtSoBan.Text), Convert.ToInt32(txtSoBanTon.Text));
                    BUS_OBJ.suaSach(sach);
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
                if (cboTacGia.SelectedValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Chưa có tác giả này.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTacGia.Focus();
                }
                else if (cboTheLoai.SelectedValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Chưa có thể loại này.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTheLoai.Focus();
                }
                else if (cboNXB.SelectedValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Chưa có NXB này.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboNXB.Focus();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nhập thiếu dữ liệu.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (txtSoBanTon.Text == "") txtSoBanTon.Focus();
                    if (txtSoBan.Text == "") txtSoBan.Focus();
                    if (txtGia.Text == "") txtGia.Focus();
                    if (txtSoTrang.Text == "") txtSoTrang.Focus();
                    if (txtNamXB.Text == "") txtNamXB.Focus();
                    if (txtTenSach.Text == "") txtTenSach.Focus();
                    if (txtMaSach.Text == "") txtMaSach.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                DialogResult thongbao;
                thongbao = (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc chắn muốn xóa? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    try
                    {
                        BUS_OBJ.xoaSach(txtMaSach.Text);
                        MetroFramework.MetroMessageBox.Show(this, "Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDuLieu();
                        txtMaSach.Text = "";
                        txtTenSach.Text = "";
                        cboTacGia.SelectedValue = "0001";
                        cboTheLoai.SelectedValue = "100";
                        cboNXB.SelectedValue = "1000";
                        txtNamXB.Text = "";
                        txtSoTrang.Text = "";
                        txtGia.Text = "";
                        txtSoBan.Text = "";
                        txtSoBanTon.Text = "";
                    }
                    catch (Exception)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Không thể xóa sách đang có phiếu mượn. \nVui lòng xem lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        txtMaSach.Focus();
                        //if (conn.State == ConnectionState.Open) conn.Close();
                    }
                } 
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn 1 cuốn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
                btnCancel_Click(sender, e);
            }      
        }

        private void frmCapNhatSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
        }
    }
}
