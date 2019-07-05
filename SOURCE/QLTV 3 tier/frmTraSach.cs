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
    public partial class frmTraSach : MetroForm
    {
        private frmMain parentForm;
        private DTO.DangNhap_DTO user;

        public frmTraSach(frmMain parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            CleanUI();
            cboLuaChonTraLoad();
        }

        private void frmTraSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
            this.parentForm.showInfo();
        }

        public void receivingData(DangNhap_DTO user)
        {
            this.user = user;
        }

        private void cboLuaChonTraLoad()
        {
            DataTable dt = BUS_OBJ.loadDSSachDangMuonTheoMaThe(user.TenDangNhap);
            if (dt.Rows.Count != 0)
            {
                cboLuaChonTra.DataSource = dt;
                cboLuaChonTra.DisplayMember = "TenSach";
                cboLuaChonTra.ValueMember = "MaSach";
            }
            else
            {
                cboLuaChonTra.DataSource = null;
                cboLuaChonTra.SelectedIndex = -1;
            }
        }

        private void CleanUI()
        {
            cboTinhTrang.SelectedItem = "Chờ phê duyệt";
            cboTinhTrang.Enabled = false;
            rtbGhiChu.BackColor = SystemColors.Control;
            rtbGhiChu.Text = "";
            rtbGhiChu.ReadOnly = true;
            gbInfo.Text = "Thông tin phiếu mượn:";
            lbSoPhieu.Text = "-";
            lbMaThe.Text = "-";
            lbMaSach.Text = "-";
            DateTime ngay = new DateTime();
            ngay = DateTime.Now;
            dtpNgayMuon.Value = ngay;
            dtpNgayTra.Value = ngay;
            dtpNgayMuon.Enabled = false;
            dtpNgayTra.Enabled = false;
            tltTenSach.SetToolTip(lbMaSach, "");
            tltTenChuThe.SetToolTip(lbMaThe, "");
        }

        private void cboLuaChonTra_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLuaChonTra.SelectedValue == null)
            {
                return;
            }
            DataTable dt = BUS_OBJ.loadTTPhieuMuonTheoMaTheVaMaSach(user.TenDangNhap, cboLuaChonTra.SelectedValue.ToString());
            if (dt.Rows.Count != 0)
            {
                lbSoPhieu.Text = dt.Rows[0].Field<Int32>(0).ToString();
                lbMaThe.Text = dt.Rows[0].Field<string>(1).ToString();
                lbMaSach.Text = dt.Rows[0].Field<string>(2).ToString();
                try
                {
                    string chuoiNgayMuon = dt.Rows[0].Field<DateTime>(3).ToString();
                    DateTime ngayMuon = new DateTime();
                    DateTime.TryParse(chuoiNgayMuon, out ngayMuon);
                    dtpNgayMuon.Value = ngayMuon;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this,ex.Message);
                }
                try
                {
                    string chuoiNgayTra = dt.Rows[0].Field<DateTime>(4).ToString();
                    DateTime ngayTra = new DateTime();
                    DateTime.TryParse(chuoiNgayTra, out ngayTra);
                    dtpNgayTra.Value = ngayTra;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message);
                }
                cboTinhTrang.SelectedItem = dt.Rows[0].Field<string>(5).ToString();
                rtbGhiChu.Text = dt.Rows[0].Field<string>(6).ToString();
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
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (lbSoPhieu.Text != "-")
            {
                BUS_OBJ.yeuCauTraSach(Convert.ToInt32(lbSoPhieu.Text));
                MetroFramework.MetroMessageBox.Show(this, "Gửi yêu cầu trả sách thành công. \nVui lòng chờ trong giây lát.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanUI();
                cboLuaChonTraLoad();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng chờ phê duyệt các yêu cầu đã gửi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
