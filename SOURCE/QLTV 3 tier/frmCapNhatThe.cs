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
    public partial class frmCapNhatThe : MetroForm
    {
        private Form parentForm;
        public frmCapNhatThe(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmThe_Load(object sender, EventArgs e)
        {
            cboLoaiThe_LoadDataBase();
            btnCancel_Click(sender, e);
            btnOkThem.Hide();
            btnCancel.Hide();
            btnOkSua.Hide();
            HienThiDuLieu();
            dgvThe.ReadOnly = true;
            txtMaThe.Focus();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaThe.Text != "")
            {
                gbInfo.Text = "Sửa thông tin thẻ:";
                txtMaThe.ReadOnly = true;
                txtMaDG.ReadOnly = false;
                cboLoaiThe.Enabled = true;
                dtpNgayTao.Enabled = true;
                dtpNgayHetHan.Enabled = true;
                txtSachDcMuon.ReadOnly = false;
                //txtSachDangMuon.ReadOnly = false;
                if (txtMaDG.Text != "")
                {
                    tltTenDG.SetToolTip(txtMaDG, "Tên Độc Giả: " + BUS_OBJ.layTenDocGia(txtMaDG.Text));
                }
                btnOkThem.Hide();
                btnOkSua.Show();
                btnCancel.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn mã thẻ muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel_Click(sender, e);
            }
            
        }

        private void txtSachDcMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSachDangMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void cboLoaiThe_LoadDataBase()
        {
            DataTable dt = BUS_OBJ.loadDSLoaiThe();
            cboLoaiThe.DataSource = dt;
            cboLoaiThe.DisplayMember = "TenLoaiThe";
            cboLoaiThe.ValueMember = "MaLoaiThe";
            
        }
        private void HienThiDuLieu()
        {
            this.dgvThe.DataSource = null;
            this.dgvThe.DataSource = BUS_OBJ.loadDSThe();

            dgvThe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThe.Columns[0].HeaderText = "Mã thẻ";
            
            dgvThe.Columns[1].HeaderText = "Mã độc giả";
            
            dgvThe.Columns[2].HeaderText = "Mã loại thẻ";
            
            dgvThe.Columns[3].HeaderText = "Ngày tạo thẻ";
            
            dgvThe.Columns[4].HeaderText = "Ngày hết hạn";
            
            dgvThe.Columns[5].HeaderText = "Số sách được mượn";
            
            dgvThe.Columns[6].HeaderText = "Số sách đang mượn";
            
            foreach (DataGridViewColumn col in dgvThe.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Thông tin thẻ:";
            txtMaThe.Text = "";
            txtMaDG.Text = "";
            cboLoaiThe.SelectedValue = "101";
            DateTime ngay = new DateTime();
            ngay = DateTime.Now;
            dtpNgayTao.Value = ngay;
            dtpNgayHetHan.Value = ngay;
            txtSachDcMuon.Text = "";
            txtSachDangMuon.Text = "";
            txtMaThe.ReadOnly = true;
            txtMaDG.ReadOnly = true;
            cboLoaiThe.Enabled = false;
            dtpNgayTao.Enabled = false;
            dtpNgayHetHan.Enabled = false;
            txtSachDcMuon.ReadOnly = true;
            txtSachDangMuon.ReadOnly = true;
            tltTenDG.SetToolTip(txtMaDG, "");
            btnOkThem.Hide();
            btnOkSua.Hide();
            btnCancel.Hide();
            txtMaThe.Focus();
        }

        private void dgvThe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvThe.Rows.Count; i++)
                for (int j = 0; j < dgvThe.Columns.Count; j++)
                    if (dgvThe.Rows[i].Cells[j].Selected == true)
                    {
                        txtMaThe.Text = dgvThe.Rows[i].Cells[0].Value.ToString();
                        txtMaDG.Text = dgvThe.Rows[i].Cells[1].Value.ToString();
                        cboLoaiThe.SelectedValue = dgvThe.Rows[i].Cells[2].Value.ToString();
                        try
                        {
                            string chuoiNgayTao = dgvThe.Rows[i].Cells[3].Value.ToString();
                            DateTime ngayTao = new DateTime();
                            DateTime.TryParse(chuoiNgayTao, out ngayTao);
                            dtpNgayTao.Value = ngayTao;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        try
                        {
                            string chuoiNgayHetHan = dgvThe.Rows[i].Cells[4].Value.ToString();
                            DateTime ngayHetHan = new DateTime();
                            DateTime.TryParse(chuoiNgayHetHan, out ngayHetHan);
                            dtpNgayHetHan.Value = ngayHetHan;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        txtSachDcMuon.Text = dgvThe.Rows[i].Cells[5].Value.ToString();
                        txtSachDangMuon.Text = dgvThe.Rows[i].Cells[6].Value.ToString();
                    }
            tltTenDG.SetToolTip(txtMaDG, "Tên Độc Giả: " + BUS_OBJ.layTenDocGia(txtMaDG.Text));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Nhập đầy đủ các thông tin:";
            txtMaThe.ReadOnly = false;
            txtMaDG.ReadOnly = false;
            cboLoaiThe.Enabled = true;
            dtpNgayTao.Enabled = true;
            dtpNgayHetHan.Enabled = true;
            txtSachDcMuon.ReadOnly = false;
            //txtSachDangMuon.ReadOnly = false;
            txtMaThe.Text = "";
            txtMaDG.Text = "";
            cboLoaiThe.SelectedValue = "101";
            DateTime ngay = new DateTime();
            ngay = DateTime.Now;
            dtpNgayTao.Value = ngay;
            dtpNgayHetHan.Value = ngay;
            txtSachDcMuon.Text = "";
            txtSachDangMuon.Text = "0";
            tltTenDG.SetToolTip(txtMaDG, "");
            btnOkThem.Show();
            btnCancel.Show();
            btnOkSua.Hide();
            txtMaThe.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaThe.Text != "")
            {
                DialogResult thongbao;
                thongbao = (MetroFramework.MetroMessageBox.Show(this, "Bạn chắc chắn muốn xóa? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    try
                    {
                        BUS_OBJ.xoaThe(txtMaThe.Text);
                        HienThiDuLieu();
                        MetroFramework.MetroMessageBox.Show(this, "Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaThe.Text = "";
                        txtMaDG.Text = "";
                        cboLoaiThe.SelectedValue = "101";
                        DateTime ngay = new DateTime();
                        ngay = DateTime.Now;
                        dtpNgayTao.Value = ngay;
                        dtpNgayHetHan.Value = ngay;
                        txtSachDcMuon.Text = "";
                        txtSachDangMuon.Text = "0";
                        tltTenDG.SetToolTip(txtMaDG, "");
                    }
                    catch (Exception)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Không thể xóa thẻ đang có phiếu mượn. \nVui lòng xem lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn 1 mã thẻ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaThe.Focus();
                btnCancel_Click(sender, e);
            }   
        }

        private void btnOkSua_Click(object sender, EventArgs e)
        {
            if (txtMaThe.Text != "")
            {
                if (DateTime.Compare(dtpNgayTao.Value, dtpNgayHetHan.Value) < 0)
                {
                    if ((txtMaThe.Text != "") && (txtMaDG.Text != "") && (txtSachDcMuon.Text != ""))
                    {
                        try
                        {
                            The_DTO the = new The_DTO(txtMaThe.Text, txtMaDG.Text, (string)cboLoaiThe.SelectedValue, dtpNgayTao.Value, dtpNgayHetHan.Value, Convert.ToInt32(txtSachDcMuon.Text), Convert.ToInt32(txtSachDangMuon.Text));
                            BUS_OBJ.suaThe(the);
                            HienThiDuLieu();
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Nhập lỗi, không tìm thấy mã độc giả.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //MetroFramework.MetroMessageBox.Show(this, ex.Message);
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
                        if (txtSachDcMuon.Text == "") txtSachDcMuon.Focus();
                        if (txtMaDG.Text == "") txtMaDG.Focus();
                        //if (txtMaThe.Text == "") txtMaThe.Focus();
                    }
                }
                else MetroFramework.MetroMessageBox.Show(this, "Nhập lỗi, ngày hết hạn trước ngày tạo.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOkThem_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpNgayTao.Value, dtpNgayHetHan.Value) < 0)
            {
                if ((txtMaThe.Text != "") && (txtMaDG.Text != "") && (txtSachDcMuon.Text != ""))
                {
                    try
                    {
                        The_DTO the = new The_DTO(txtMaThe.Text, txtMaDG.Text, (string)cboLoaiThe.SelectedValue, dtpNgayTao.Value, dtpNgayHetHan.Value, Convert.ToInt32(txtSachDcMuon.Text), Convert.ToInt32(txtSachDangMuon.Text));
                        BUS_OBJ.themThe(the);
                        HienThiDuLieu();
                    }
                    catch (Exception)
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Mã thẻ bị trùng. \nKhông thể thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (txtSachDcMuon.Text == "") txtSachDcMuon.Focus();
                    if (txtMaDG.Text == "") txtMaDG.Focus();
                    if (txtMaThe.Text == "") txtMaThe.Focus();
                }
            }
            else MetroFramework.MetroMessageBox.Show(this,"Nhập lỗi, ngày hết hạn trước ngày tạo.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmCapNhatThe_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
        }
    }
}
