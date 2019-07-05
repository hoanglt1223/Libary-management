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
    public partial class frmMuonSach : MetroForm
    {
        private DTO.DangNhap_DTO user;
        private frmMain parentForm;
        public frmMuonSach(frmMain parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
        public void receivingData(DangNhap_DTO user)
        {
            this.user = user;
        }

        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            cboLuaChonTim.SelectedItem = "Mã sách";
            lbMaSach.Hide();
            lbTenSach.Hide();
            lbTacGia.Hide();
            lbTheLoai.Hide();
            lbNXB.Hide();
            lbNamXB.Hide();
            lbSoTrang.Hide();
            lbGia.Hide();
            lbSoBan.Hide();
            lbSoBanTon.Hide();
            HienThiDuLieu();
            btnMuon.Focus();
            txtThongTinTimKiem.Text = "Nhập thông tin tìm kiếm...";
            txtThongTinTimKiem.ForeColor = Color.Gray;
            txtThongTinTimKiem.Focus();
        }

        private void HienThiDuLieu()
        {
            this.dgvSach.DataSource = null;
            this.dgvSach.DataSource = BUS_OBJ.loadDSSach();
            hieuChinhDGV();
        }

        private void hieuChinhDGV()
        {
            dgvSach.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSach.Columns[0].Width = 50;
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[1].Width = 264;
            dgvSach.Columns[2].HeaderText = "Mã tác giả";
            dgvSach.Columns[2].Width = 68;
            dgvSach.Columns[3].HeaderText = "Mã thể loại";
            dgvSach.Columns[3].Width = 68;
            dgvSach.Columns[4].HeaderText = "Mã nhà xuất bản";
            dgvSach.Columns[4].Width = 80;
            dgvSach.Columns[5].HeaderText = "Năm xuất bản";
            dgvSach.Columns[5].Width = 80;
            dgvSach.Columns[6].HeaderText = "Số trang";
            dgvSach.Columns[6].Width = 60;
            dgvSach.Columns[7].HeaderText = "Giá";
            dgvSach.Columns[7].Width = 46;
            dgvSach.Columns[8].HeaderText = "Số bản";
            dgvSach.Columns[8].Width = 50;
            dgvSach.Columns[9].HeaderText = "Tồn";
            dgvSach.Columns[9].Width = 50;
            foreach (DataGridViewColumn col in dgvSach.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            if (dgvSach.Rows.Count == 2)
            {
                lbMaSach.Text = dgvSach.Rows[0].Cells[0].Value.ToString();
                lbTenSach.Text = dgvSach.Rows[0].Cells[1].Value.ToString();
                lbTacGia.Text = BUS_OBJ.layTenTacGia(dgvSach.Rows[0].Cells[2].Value.ToString());
                lbTheLoai.Text = BUS_OBJ.layTenTheLoai(dgvSach.Rows[0].Cells[3].Value.ToString());
                lbNXB.Text = BUS_OBJ.layTenNXB(dgvSach.Rows[0].Cells[4].Value.ToString());
                lbNamXB.Text = dgvSach.Rows[0].Cells[5].Value.ToString();
                lbSoTrang.Text = dgvSach.Rows[0].Cells[6].Value.ToString();
                lbGia.Text = dgvSach.Rows[0].Cells[7].Value.ToString();
                lbSoBan.Text = dgvSach.Rows[0].Cells[8].Value.ToString();
                lbSoBanTon.Text = dgvSach.Rows[0].Cells[9].Value.ToString();
                lbMaSach.Show();
                lbTenSach.Show();
                lbTacGia.Show();
                lbTheLoai.Show();
                lbNXB.Show();
                lbNamXB.Show();
                lbSoTrang.Show();
                lbGia.Show();
                lbSoBan.Show();
                lbSoBanTon.Show();
            }
        }

        private void txtThongTinTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboLuaChonTim.SelectedItem.ToString() == "Năm xuất bản")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void cboLuaChonTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuaChonTim.SelectedItem.ToString() == "Năm xuất bản")
                txtThongTinTimKiem.Text = "";
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvSach.Rows.Count; i++)
                for (int j = 0; j < dgvSach.Columns.Count; j++)
                    if (dgvSach.Rows[i].Cells[j].Selected == true)
                    {
                        lbMaSach.Text = dgvSach.Rows[i].Cells[0].Value.ToString();
                        lbTenSach.Text = dgvSach.Rows[i].Cells[1].Value.ToString();
                        lbTacGia.Text = BUS_OBJ.layTenTacGia(dgvSach.Rows[i].Cells[2].Value.ToString());
                        lbTheLoai.Text = BUS_OBJ.layTenTheLoai(dgvSach.Rows[i].Cells[3].Value.ToString());
                        lbNXB.Text = BUS_OBJ.layTenNXB(dgvSach.Rows[i].Cells[4].Value.ToString());
                        lbNamXB.Text = dgvSach.Rows[i].Cells[5].Value.ToString();
                        lbSoTrang.Text = dgvSach.Rows[i].Cells[6].Value.ToString();
                        lbGia.Text = dgvSach.Rows[i].Cells[7].Value.ToString();
                        lbSoBan.Text = dgvSach.Rows[i].Cells[8].Value.ToString();
                        lbSoBanTon.Text = dgvSach.Rows[i].Cells[9].Value.ToString();
                    }
            lbMaSach.Show();
            lbTenSach.Show();
            lbTacGia.Show();
            lbTheLoai.Show();
            lbNXB.Show();
            lbNamXB.Show();
            lbSoTrang.Show();
            lbGia.Show();
            lbSoBan.Show();
            lbSoBanTon.Show();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            lbMaSach.Hide();
            lbTenSach.Hide();
            lbTacGia.Hide();
            lbTheLoai.Hide();
            lbNXB.Hide();
            lbNamXB.Hide();
            lbSoTrang.Hide();
            lbGia.Hide();
            lbSoBan.Hide();
            lbSoBanTon.Hide();
            if (txtThongTinTimKiem.Text == "")
            {
                HienThiDuLieu();
            }
            else
            {
                switch (cboLuaChonTim.SelectedItem.ToString())
                {
                    case "Mã sách": timKiemTheoMaSach(txtThongTinTimKiem.Text); break;
                    case "Tên sách": timKiemTheoTenSach(txtThongTinTimKiem.Text.Trim()); break;
                    case "Tên tác giả": timKiemTheoTacGia(txtThongTinTimKiem.Text.Trim()); break;
                    case "Thể loại": timKiemTheoTheLoai(txtThongTinTimKiem.Text.Trim()); break;
                    case "Nhà xuất bản": timKiemTheoNXB(txtThongTinTimKiem.Text.Trim()); break;
                    case "Năm xuất bản":
                        if (txtThongTinTimKiem.Text != "")
                        {
                            timKiemTheoNamXB(Convert.ToInt16(txtThongTinTimKiem.Text));
                        }
                        break;
                }
            }
        }
        private void timKiemTheoMaSach(string maSach)
        {
            this.dgvSach.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemTheoMaSach(maSach);
            if (dt.Rows.Count != 0)
            {
                this.dgvSach.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Không tìm thấy mã sách tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }
        private void timKiemTheoTenSach(string tenSach)
        {
            this.dgvSach.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemTheoTenSach(tenSach);
            if (dt.Rows.Count != 0)
            {
                this.dgvSach.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Không tìm thấy tên sách tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }
        private void timKiemTheoTacGia(string tenTacGia)
        {
            this.dgvSach.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemTheoTenTG(tenTacGia);
            if (dt.Rows.Count != 0)
            {
                this.dgvSach.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy sách có tên tác giả tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }
        private void timKiemTheoTheLoai(string tenTheLoai)
        {
            this.dgvSach.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemTheoTheLoai(tenTheLoai);
            if (dt.Rows.Count != 0)
            {
                this.dgvSach.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy sách có tên thể loại tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }
        private void timKiemTheoNXB(string tenNXB)
        {
            this.dgvSach.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemTheoNXB(tenNXB);
            if (dt.Rows.Count != 0)
            {
                this.dgvSach.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy sách có tên nhà xuất bản tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }
        private void timKiemTheoNamXB(int namXB)
        {
            this.dgvSach.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemTheoNamXB(namXB);
            if (dt.Rows.Count != 0)
            {
                this.dgvSach.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy sách có năm xuất bản tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }

        private void txtThongTinTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtThongTinTimKiem.ForeColor != Color.Black)
            {
                txtThongTinTimKiem.ForeColor = Color.Black;
                txtThongTinTimKiem.Text = "";
            }
        }

        private void txtThongTinTimKiem_Leave(object sender, EventArgs e)
        {
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (lbMaSach.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn 1 cuốn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (lbSoBanTon.Text == "0")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Mã sách này hiện đã được mượn hết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        string maThe = BUS_OBJ.layMaTheTheoMaDocGia(user.TenDangNhap);
                        if (maThe == "")
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Mã thẻ của bạn không khả dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            int soSachDangMuon = 0;
                            int soSachDuocMuon = 0;
                            soSachDangMuon = BUS_OBJ.laySoSachDangMuon(maThe);
                            soSachDuocMuon = BUS_OBJ.laySoSachDuocMuon(maThe);
                            if (soSachDangMuon < soSachDuocMuon)
                            {
                                frmPhieuMuon muon = new frmPhieuMuon(this);
                                muon.setLabelMaThe(maThe);
                                muon.setLabelMaSach(lbMaSach.Text);
                                muon.setLabelTenSach(lbTenSach.Text);
                                this.Opacity = .75;
                                muon.ShowDialog();
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Hiện bạn đã mượn hết số lượng sách được mượn. \nVui lòng trả những sách đã mượn để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                    finally
                    {
                        
                    }
                }
            }
        }

        private void frmTimKiemSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
            this.parentForm.showInfo();
        }
    }
}
