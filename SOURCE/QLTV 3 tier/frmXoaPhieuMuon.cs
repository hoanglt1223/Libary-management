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
using DTO;
using BUS;

namespace QLTV
{
    public partial class frmXoaPhieuMuon : MetroForm
    {
        private Form parentForm;
        public frmXoaPhieuMuon(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmXoaPhieuMuon_Load(object sender, EventArgs e)
        {            
            cboLuaChonTim.SelectedItem = "Mã thẻ";
            cboTinhTrang.SelectedItem = "Chờ phê duyệt";
            rtbGhiChu.BackColor = SystemColors.Control;
            btnCancel_Click(sender, e);
            btnCancel.Hide();
            this.dgvPhieuMuon.DataSource = null;
            this.dgvPhieuMuon.DataSource = BUS_OBJ.loadDSPhieuMuonDaTra();
            hieuChinhDGV();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Thông tin phiếu mượn:";
            lbSoPhieu.Text = "-";
            lbMaThe.Text = "-";
            lbMaSach.Text = "-";
            DateTime ngay = new DateTime();
            ngay = DateTime.Now;
            dtpNgayMuon.Value = ngay;
            dtpNgayTra.Value = ngay;
            cboTinhTrang.SelectedItem = "Chờ phê duyệt";
            rtbGhiChu.Text = "";
            dtpNgayMuon.Enabled = false;
            dtpNgayTra.Enabled = false;
            cboTinhTrang.Enabled = false;
            rtbGhiChu.ReadOnly = true;
            rtbGhiChu.BackColor = SystemColors.Control;
            tltTenSach.SetToolTip(lbMaSach, "");
            tltTenChuThe.SetToolTip(lbMaThe, "");
            btnCancel.Hide();
        }

        private void frmXoaPhieuMuon_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            switch (cboLuaChonTim.SelectedItem.ToString())
            {
                case "Mã thẻ": timKiemTheoMaThe(txtThongTinTimKiem.Text.Trim()); break;
                case "Tên chủ thẻ": timKiemTheoTenChuThe(txtThongTinTimKiem.Text.Trim()); break;
                case "Mã sách": timKiemTheoMaSach(txtThongTinTimKiem.Text.Trim()); break;
                case "Tên sách": timKiemTheoTenSach(txtThongTinTimKiem.Text.Trim()); break;
                case "Số phiếu":
                    if (txtThongTinTimKiem.Text != "")
                        timKiemTheoSoPhieu(Convert.ToInt16(txtThongTinTimKiem.Text));
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Nhập số phiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
        }

        private void timKiemTheoMaThe(string maThe)
        {
            this.dgvPhieuMuon.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemPhieuMuonDaTraTheoMaThe(maThe);
            if (dt.Rows.Count != 0)
            {
                this.dgvPhieuMuon.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy phiếu mượn của mã thẻ tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }
        private void timKiemTheoTenChuThe(string tenChuThe)
        {
            this.dgvPhieuMuon.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemPhieuMuonDaTraTheoMaThe(BUS_OBJ.layMaDocGiaTheoTenDocGia(tenChuThe));
            if (dt.Rows.Count != 0)
            {
                this.dgvPhieuMuon.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy phiếu mượn của chủ thẻ tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }
        private void timKiemTheoMaSach(string maSach)
        {
            this.dgvPhieuMuon.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemPhieuMuonDaTraTheoMaSach(maSach);
            if (dt.Rows.Count != 0)
            {
                this.dgvPhieuMuon.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy phiếu mượn của mã sách tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }
        private void timKiemTheoTenSach(string tenSach)
        {
            this.dgvPhieuMuon.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemPhieuMuonDaTraTheoMaSach(BUS_OBJ.layMaSachTheoTenSach(tenSach));
            if (dt.Rows.Count != 0)
            {
                this.dgvPhieuMuon.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy phiếu mượn của tựa sách này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }
        private void timKiemTheoSoPhieu(int soPhieu)
        {
            this.dgvPhieuMuon.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemPhieuMuonDaTraTheoSoPhieu(soPhieu);
            if (dt.Rows.Count != 0)
            {
                this.dgvPhieuMuon.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy phiếu mượn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }

        private void hieuChinhDGV()
        {
            dgvPhieuMuon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuMuon.Columns[0].HeaderText = "Số phiếu";
           
            dgvPhieuMuon.Columns[1].HeaderText = "Mã thẻ";
            
            dgvPhieuMuon.Columns[2].HeaderText = "Mã sách";
            
            dgvPhieuMuon.Columns[3].HeaderText = "Ngày mượn";
            
            dgvPhieuMuon.Columns[4].HeaderText = "Ngày trả";
            
            dgvPhieuMuon.Columns[5].HeaderText = "Tình trạng";
            
            dgvPhieuMuon.Columns[6].HeaderText = "Ghi chú";
            dgvPhieuMuon.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (DataGridViewColumn col in dgvPhieuMuon.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void txtThongTinTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboLuaChonTim.SelectedItem.ToString() == "Số phiếu")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void cboLuaChonTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuaChonTim.SelectedItem.ToString() == "Số phiếu")
                txtThongTinTimKiem.Text = "";
        }

        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvPhieuMuon.Rows.Count; i++)
                for (int j = 0; j < dgvPhieuMuon.Columns.Count; j++)
                    if (dgvPhieuMuon.Rows[i].Cells[j].Selected == true)
                    {
                        lbSoPhieu.Text = dgvPhieuMuon.Rows[i].Cells[0].Value.ToString();
                        lbMaThe.Text = dgvPhieuMuon.Rows[i].Cells[1].Value.ToString();
                        lbMaSach.Text = dgvPhieuMuon.Rows[i].Cells[2].Value.ToString();
                        try
                        {
                            string chuoiNgayMuon = dgvPhieuMuon.Rows[i].Cells[3].Value.ToString();
                            DateTime ngayMuon = new DateTime();
                            DateTime.TryParse(chuoiNgayMuon, out ngayMuon);
                            dtpNgayMuon.Value = ngayMuon;
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message);
                        }
                        try
                        {
                            string chuoiNgayTra = dgvPhieuMuon.Rows[i].Cells[4].Value.ToString();
                            DateTime ngayTra = new DateTime();
                            DateTime.TryParse(chuoiNgayTra, out ngayTra);
                            dtpNgayTra.Value = ngayTra;
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message);
                        }
                        cboTinhTrang.SelectedItem = dgvPhieuMuon.Rows[i].Cells[5].Value.ToString();
                        rtbGhiChu.Text = dgvPhieuMuon.Rows[i].Cells[6].Value.ToString();
                    }
            try
            {
                tltTenSach.SetToolTip(lbMaSach, BUS_OBJ.layTenSach(lbMaSach.Text));
                tltTenChuThe.SetToolTip(lbMaThe, BUS_OBJ.layTenDocGia(lbMaThe.Text));
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                for (int i = 0; i < dgvPhieuMuon.Rows.Count; i++)
                {
                    if (dgvPhieuMuon.Rows[i].Selected == true)
                    {
                        count++;
                        BUS_OBJ.xoaPhieuMuon(Convert.ToInt32(dgvPhieuMuon.Rows[i].Cells[0].Value));
                    }
                }
                if (count == 0)
                    MetroFramework.MetroMessageBox.Show(this, "Hãy chọn ít nhất 1 phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Đã xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(sender, e);
                    this.dgvPhieuMuon.DataSource = null;
                    this.dgvPhieuMuon.DataSource = BUS_OBJ.loadDSPhieuMuonDaTra();
                    hieuChinhDGV();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btXoaToanBo_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MetroFramework.MetroMessageBox.Show(this, "Xóa toàn bộ phiếu mượn trong bảng.\nBạn chắc chắn muốn tiếp tục? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < dgvPhieuMuon.Rows.Count; i++)
                    {
                        BUS_OBJ.xoaPhieuMuon(Convert.ToInt32(dgvPhieuMuon.Rows[i].Cells[0].Value));
                    }
                    MetroFramework.MetroMessageBox.Show(this, "Đã xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(sender, e);
                    this.dgvPhieuMuon.DataSource = null;
                    this.dgvPhieuMuon.DataSource = BUS_OBJ.loadDSPhieuMuonDaTra();
                    hieuChinhDGV();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message);
                }
            }
        }
    }
}
