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
    public partial class frmCapNhatDocGia : MetroForm
    {
        private Form parentForm;
        public frmCapNhatDocGia(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmCapNhatDocGia_Load(object sender, EventArgs e)
        {
            cboGioiTinh.SelectedItem = "Nam";
            cboLoaiDG_LoadDataBase();
            btnOkThem.Hide();
            btnCancel.Hide();
            btnOkSua.Hide();
            HienThiDuLieu();
            btnCancel_Click(sender, e);
            dgvDocGia.ReadOnly = true;
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true) txtMK.UseSystemPasswordChar = false;
            else txtMK.UseSystemPasswordChar = true;
        }
        private void HienThiDuLieu()
        {
            this.dgvDocGia.DataSource = null;
            this.dgvDocGia.DataSource = BUS_OBJ.loadDSDocGia();

            dgvDocGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDocGia.Columns[0].HeaderText = "Mã độc giả";
            dgvDocGia.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvDocGia.Columns[1].HeaderText = "Tên độc giả";
            
            dgvDocGia.Columns[2].HeaderText = "Giới tính";
            
            dgvDocGia.Columns[3].HeaderText = "Ngày sinh";
            
            dgvDocGia.Columns[4].HeaderText = "Địa chỉ";
            
            dgvDocGia.Columns[5].HeaderText = "Số CMT";
            
            dgvDocGia.Columns[6].HeaderText = "Loại độc giả";
            
            foreach (DataGridViewColumn col in dgvDocGia.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void txtSoCMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cboLoaiDG_LoadDataBase()
        {
            DataTable dt = BUS_OBJ.loadDSLoaiDG();
            cboLoaiDG.DataSource = dt;
            cboLoaiDG.DisplayMember = "TenLoaiDocGia";
            cboLoaiDG.ValueMember = "MaLoaiDocGia";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Thông tin độc giả:";
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            cboGioiTinh.SelectedItem = "Nam";
            DateTime ngaySinh = new DateTime();
            DateTime.TryParse("2000-01-01", out ngaySinh);
            dtpNgaySinh.Value = ngaySinh;
            txtDiaChi.Text = "";
            txtSoCMT.Text = "";
            cboLoaiDG.SelectedValue = "101";
            txtMK.Text = "";
            txtMaDG.ReadOnly = true;
            txtTenDG.ReadOnly = true;
            cboGioiTinh.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtDiaChi.ReadOnly = true;
            txtSoCMT.ReadOnly = true;
            cboLoaiDG.Enabled = false;
            txtMK.ReadOnly = true;
            btnOkThem.Hide();
            btnOkSua.Hide();
            btnCancel.Hide();
            cbTaoThe.Hide();
            txtMaDG.Focus();
        }

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvDocGia.Rows.Count; i++)
                for (int j = 0; j < dgvDocGia.Columns.Count; j++)
                    if (dgvDocGia.Rows[i].Cells[j].Selected == true)
                    {
                        txtMaDG.Text = dgvDocGia.Rows[i].Cells[0].Value.ToString();
                        txtTenDG.Text = dgvDocGia.Rows[i].Cells[1].Value.ToString();
                        cboGioiTinh.SelectedItem = dgvDocGia.Rows[i].Cells[2].Value.ToString();
                        try
                        {
                            string chuoiNgaySinh = dgvDocGia.Rows[i].Cells[3].Value.ToString();
                            DateTime ngaySinh = new DateTime();
                            DateTime.TryParse(chuoiNgaySinh, out ngaySinh);
                            dtpNgaySinh.Value = ngaySinh;
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message);
                        }
                        txtDiaChi.Text = dgvDocGia.Rows[i].Cells[4].Value.ToString();
                        txtSoCMT.Text = dgvDocGia.Rows[i].Cells[5].Value.ToString();
                        cboLoaiDG.SelectedValue = dgvDocGia.Rows[i].Cells[6].Value.ToString();
                        txtMK.Text = dgvDocGia.Rows[i].Cells[7].Value.ToString();
                    }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Nhập đầy đủ các thông tin:";
            txtMaDG.ReadOnly = false;
            txtTenDG.ReadOnly = false;
            cboGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtDiaChi.ReadOnly = false;
            txtSoCMT.ReadOnly = false;
            cboLoaiDG.Enabled = true;
            txtMK.ReadOnly = false;
            cbTaoThe.Show();
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            cboGioiTinh.SelectedItem = "Nam";
            DateTime ngaySinh = new DateTime();
            DateTime.TryParse("2000-01-01", out ngaySinh);
            dtpNgaySinh.Value = ngaySinh;
            txtDiaChi.Text = "";
            txtSoCMT.Text = "";
            cboLoaiDG.SelectedValue = "101";
            txtMK.Text = "";
            btnOkThem.Show();
            btnCancel.Show();
            btnOkSua.Hide();
            txtMaDG.Focus();
        }
        private void autoThemThe()
        {
            try
            {
                if (BUS_OBJ.demSoTheTheoTen(txtMaDG.Text) > 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Dữ liệu bị trùng, mã thẻ đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime ngayCapThe = DateTime.Now;
                    DateTime ngayHetHan = DateTime.Now;
                    int soSachDuocMuon = 0, soSachDangMuon = 0;
                    if (string.Compare((string)cboLoaiDG.SelectedValue, "103") == 0)
                    {
                        ngayHetHan = DateTime.Now.AddYears(1);
                        soSachDuocMuon = 2;
                    }
                    else if (string.Compare((string)cboLoaiDG.SelectedValue, "102") == 0)
                    {
                        ngayHetHan = DateTime.Now.AddYears(4);
                        soSachDuocMuon = 5; 
                    } else if (string.Compare((string)cboLoaiDG.SelectedValue, "101") == 0)
                    {
                        ngayHetHan = DateTime.Now.AddYears(5);
                        soSachDuocMuon = 8;
                    }
                    The_DTO the = new The_DTO(txtMaDG.Text, txtMaDG.Text, (string)cboLoaiDG.SelectedValue, ngayCapThe, ngayHetHan, soSachDuocMuon, soSachDangMuon);
                    BUS_OBJ.themThe(the);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Mã thẻ mượn sách đã tồn tại. \nKhông thể thêm mới thẻ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        private void autoThemUser()
        {
            try
            {
                BUS_OBJ.themUser(txtMaDG.Text, txtMK.Text, 0);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Tên đăng nhập bị trùng. \nChưa thêm mới tài khoản đăng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        private void autoSuaUser()
        {
            try
            {
                BUS_OBJ.suaUser(txtMaDG.Text, txtMK.Text, 0);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            finally
            {
                //if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        private void autoXoaUser()
        {
            try
            {
                BUS_OBJ.xoaUser(txtMaDG.Text);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            finally
            {
                //if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnOkThem_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpNgaySinh.Value, DateTime.Today) < 0)
            {
                if ((txtMaDG.Text != "") && (txtTenDG.Text != "") && (txtDiaChi.Text != "") && (txtSoCMT.Text != "") && (txtMK.Text != ""))
                {
                    try
                    {
                        DocGia_DTO docGia = new DocGia_DTO(txtMaDG.Text, txtTenDG.Text, cboGioiTinh.SelectedItem.ToString(), dtpNgaySinh.Value, txtDiaChi.Text, txtSoCMT.Text, (string)cboLoaiDG.SelectedValue, txtMK.Text);
                        BUS_OBJ.themDG(docGia);
                        if (cbTaoThe.Checked == true) autoThemThe();
                        autoThemUser();/////
                        HienThiDuLieu();
                    }
                    catch (Exception)
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Mã độc giả bị trùng. \nKhông thể thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (txtMK.Text == "") txtMK.Focus();
                    if (txtSoCMT.Text == "") txtSoCMT.Focus();
                    if (txtDiaChi.Text == "") txtDiaChi.Focus();
                    if (txtTenDG.Text == "") txtTenDG.Focus();
                    if (txtMaDG.Text == "") txtMaDG.Focus();
                }
            }
            else MetroFramework.MetroMessageBox.Show(this,"Nhập ngày sinh sai.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cbTaoThe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text != "")
            {
                gbInfo.Text = "Sửa thông tin độc giả:";
                txtMaDG.ReadOnly = true;
                txtTenDG.ReadOnly = false;
                cboGioiTinh.Enabled = true;
                dtpNgaySinh.Enabled = true;
                txtDiaChi.ReadOnly = false;
                txtSoCMT.ReadOnly = false;
                cboLoaiDG.Enabled = true;
                txtMK.ReadOnly = false;
                btnOkThem.Hide();
                cbTaoThe.Hide();
                btnOkSua.Show();
                btnCancel.Show();
                txtTenDG.Focus();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn độc giả muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel_Click(sender, e);
            }
        }

        private void btnOkSua_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpNgaySinh.Value, DateTime.Today) < 0)
            {
                if ((txtMaDG.Text != "") && (txtTenDG.Text != "") && (txtDiaChi.Text != "") && (txtSoCMT.Text != "") && (txtMK.Text != ""))
                {
                    try
                    {
                        DocGia_DTO docGia = new DocGia_DTO(txtMaDG.Text, txtTenDG.Text, cboGioiTinh.SelectedItem.ToString(), dtpNgaySinh.Value, txtDiaChi.Text, txtSoCMT.Text, (string)cboLoaiDG.SelectedValue, txtMK.Text);
                        BUS_OBJ.suaDG(docGia);
                        autoSuaUser();
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
                    MessageBox.Show(this,"Nhập thiếu dữ liệu.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (txtMK.Text == "") txtMK.Focus();
                    if (txtSoCMT.Text == "") txtSoCMT.Focus();
                    if (txtDiaChi.Text == "") txtDiaChi.Focus();
                    if (txtTenDG.Text == "") txtTenDG.Focus();
                    //if (txtMaDG.Text == "") txtMaDG.Focus();
                }
            }
            else MetroFramework.MetroMessageBox.Show(this,"Nhập ngày sinh sai.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text != "")
            {
                DialogResult thongbao;
                thongbao = (MetroFramework.MetroMessageBox.Show(this, "Thẻ và tên đăng nhập có mã độc giả trên cũng sẽ bị xóa.\nBạn chắc chắn muốn tiếp tục? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    try
                    {
                        BUS_OBJ.xoaDG(txtMaDG.Text);
                        autoXoaUser();
                        MetroFramework.MetroMessageBox.Show(this, "Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDuLieu();
                       
                    }
                    catch (Exception)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Không thể xóa thẻ đang có phiếu mượn.\nVui lòng xem lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        txtMaDG.Focus();
                        //if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn 1 độc giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDG.Focus();
                btnCancel_Click(sender, e);
            }  
        }

        private void frmCapNhatDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
        }
    }
}
