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
using BUS;
using DTO;

namespace QLTV
{
    public partial class frmDuyetPhieuMuonDangCho : MetroForm
    {
        private frmMain parentForm;
        public frmDuyetPhieuMuonDangCho(frmMain parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmDuyetPhieuMuonDangCho_Load(object sender, EventArgs e)
        {
            cboTinhTrang.SelectedItem = "Chờ phê duyệt";
            rtbGhiChu.BackColor = SystemColors.Control;
            btnCancel_Click(sender, e);
            btnCancel.Hide();
            btnOkSua.Hide();
            HienThiDuLieu();
        }

        private void frmDuyetPhieuMuonDangCho_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
            this.parentForm.showInfo();
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
                            MessageBox.Show(ex.Message);
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
            btnOkSua.Hide();
            btnCancel.Hide();
        }
        private void HienThiDuLieu()
        {
            this.dgvPhieuMuon.DataSource = null;
            this.dgvPhieuMuon.DataSource = BUS_OBJ.timKiemPhieuMuonTheoTinhTrang("Chờ phê duyệt");
            hieuChinhDGV();
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

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (lbSoPhieu.Text != "-")
            {
                try
                {
                    string maThe = "";
                    maThe = BUS_OBJ.layMaTheTheoMaDocGia(lbMaThe.Text);
                    if (maThe == "")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Mã thẻ không khả dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int soSachDangMuon = 0;
                        int soSachDuocMuon = 0;
                        soSachDuocMuon = BUS_OBJ.laySoSachDuocMuon(maThe);
                        soSachDangMuon = BUS_OBJ.laySoSachDangMuon(maThe);
                        if (soSachDangMuon < soSachDuocMuon)
                        {
                            PhieuMuon_DTO phieuMuon = new PhieuMuon_DTO(Convert.ToInt32(lbSoPhieu.Text), lbMaThe.Text, lbMaSach.Text, 
                                            dtpNgayMuon.Value, dtpNgayTra.Value, cboTinhTrang.SelectedItem.ToString(), rtbGhiChu.Text);
                            BUS_OBJ.duyetPhieuMuon(phieuMuon);
                            HienThiDuLieu();
                            btnCancel_Click(sender, e);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Thẻ này đã mượn hết số lượng sách được mượn. \nHãy yêu cầu trả những sách đã mượn để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            rtbGhiChu.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn 1 phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbGhiChu.Focus();
            }      
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lbSoPhieu.Text != "-")
            {
                gbInfo.Text = "Sửa thông tin phiếu mượn:";
                dtpNgayMuon.Enabled = true;
                dtpNgayTra.Enabled = true;
                cboTinhTrang.Enabled = false;
                rtbGhiChu.ReadOnly = false;
                rtbGhiChu.BackColor = SystemColors.Window;
                btnOkSua.Show();
                btnCancel.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn 1 phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbGhiChu.Focus();
            }   
        }

        private void btnOkSua_Click(object sender, EventArgs e)
        {
            if (dtpNgayMuon.Value < dtpNgayTra.Value)
            {
                PhieuMuon_DTO phieuMuon = new PhieuMuon_DTO(Convert.ToInt32(lbSoPhieu.Text), lbMaThe.Text, lbMaSach.Text, 
                                dtpNgayMuon.Value, dtpNgayTra.Value, cboTinhTrang.SelectedItem.ToString(), rtbGhiChu.Text);
                BUS_OBJ.suaPhieuMuonDangCho(phieuMuon);
                HienThiDuLieu();
                btnCancel_Click(sender, e);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Điền ngày trả trước ngày mượn.\nVui lòng xem lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayTra.Focus();
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (lbSoPhieu.Text != "-")
            {
                DialogResult thongbao;
                thongbao = (MetroFramework.MetroMessageBox.Show(this, "Phiếu mượn sẽ bị xóa. \nBạn có chắc chắn muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    try
                    {
                        BUS_OBJ.tuChoiPhieuMuon(Convert.ToInt32(lbSoPhieu.Text));
                        HienThiDuLieu();
                        btnCancel_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                    //finally
                    //{
                    //    if (conn.State == ConnectionState.Open) conn.Close();
                    //}
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn 1 phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }
    }
}
