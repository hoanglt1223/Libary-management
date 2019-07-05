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
    public partial class frmThongTinPhieuMuon : MetroForm
    {
        private Form parentForm;
        public frmThongTinPhieuMuon(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmThongTinPhieuMuon_Load(object sender, EventArgs e)
        {
            cboLuaChonTim.SelectedItem = "Số phiếu";
            HienThiDuLieu(); 
        }

        private void frmThongTinPhieuMuon_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
        }

        private void HienThiDuLieu()
        {
            this.dgvPhieuMuon.DataSource = null;
            this.dgvPhieuMuon.DataSource = BUS_OBJ.loadDSPhieuMuon();
            hieuChinhDGV();
        }
        private void hieuChinhDGV()
        {
            dgvPhieuMuon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuMuon.Columns[0].HeaderText = "Số phiếu";
            
            dgvPhieuMuon.Columns[1].HeaderText = "Mã thẻ";
            dgvPhieuMuon.Columns[1].Width = 100;
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
                        string strSoPhieu = dgvPhieuMuon.Rows[i].Cells[0].Value.ToString();
                        string strMaThe = dgvPhieuMuon.Rows[i].Cells[1].Value.ToString();
                        string strMaDocGia = BUS_OBJ.layMaTheTheoMaDocGia(strMaThe);
                        string strTenDocGia = BUS_OBJ.layTenDocGia(strMaDocGia);
                        string strMaSach = dgvPhieuMuon.Rows[i].Cells[2].Value.ToString();
                        string strTenSach = BUS_OBJ.layTenSach(strMaSach);
                        string strNgayMuon = dgvPhieuMuon.Rows[i].Cells[3].Value.ToString();
                        string strNgayTra = dgvPhieuMuon.Rows[i].Cells[4].Value.ToString();
                        string strTinhTrang = dgvPhieuMuon.Rows[i].Cells[5].Value.ToString();
                        string strGhiChu = dgvPhieuMuon.Rows[i].Cells[6].Value.ToString();
                        string strCaption = "Số phiếu: " + strSoPhieu + "\n" +
                                            "Mã thẻ: " + strMaThe + "\n" +
                                            "Tên độc giả: " + strTenDocGia + "\n" +
                                            "Mã sách: " + strMaSach + "\n" +
                                            "Tên sách: " + strTenSach + "\n" +
                                            "Ngày mượn: " + strNgayMuon + "\n" +
                                            "Ngày trả: " + strNgayTra + "\n" +
                                            "Tình trạng: " + strTinhTrang + "\n" +
                                            "Ghi chú: " + strGhiChu + "\n";
                        dgvPhieuMuon.Rows[i].Cells[j].ToolTipText = strCaption;
                        dgvPhieuMuon.ShowCellToolTips = true;
                    }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            switch (cboLuaChonTim.SelectedItem.ToString())
            {
                case "Mã thẻ": timKiemTheoMaThe(txtThongTinTimKiem.Text.Trim()); break;
                case "Tên chủ thẻ": timKiemTheoTenChuThe(txtThongTinTimKiem.Text.Trim()); break;
                case "Mã sách": timKiemTheoMaSach(txtThongTinTimKiem.Text.Trim()); break;
                case "Tên sách": timKiemTheoTenSach(txtThongTinTimKiem.Text.Trim()); break;
                case "Tình trạng": timKiemTheoTinhTrang(txtThongTinTimKiem.Text.Trim()); break;
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
            DataTable dt = BUS_OBJ.timKiemPhieuMuonTheoMaThe(maThe);
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
            DataTable dt = BUS_OBJ.timKiemPhieuMuonTheoMaThe(BUS_OBJ.layMaDocGiaTheoTenDocGia(tenChuThe));
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
            DataTable dt = BUS_OBJ.timKiemPhieuMuonTheoMaSach(maSach);
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
            DataTable dt = BUS_OBJ.timKiemPhieuMuonTheoMaSach(BUS_OBJ.layMaSachTheoTenSach(tenSach));
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
        private void timKiemTheoTinhTrang(string tinhTrang)
        {
            this.dgvPhieuMuon.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemPhieuMuonTheoTinhTrang(tinhTrang);
            if (dt.Rows.Count != 0)
            {
                this.dgvPhieuMuon.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy phiếu mượn có tình trạng tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }
        private void timKiemTheoSoPhieu(int soPhieu)
        {
            this.dgvPhieuMuon.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemPhieuMuonTheoSoPhieu(soPhieu);
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
    }
}
