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
    public partial class frmPhieuMuon : MetroForm
    {
        private Form parentForm;
        public frmPhieuMuon(Form parentForm)
        {
            InitializeComponent();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = dtpNgayMuon.Value.AddMonths(1);
            this.parentForm = parentForm;
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {

        }
        public void setLabelMaThe(string maThe)
        {
            lbMaThe.Text = maThe;
            return;
        }
        public void setLabelMaSach(string maSach)
        {
            lbMaSach.Text = maSach;
            return;
        }
        public void setLabelTenSach(string tenSach)
        {
            lbTenSach.Text = tenSach;
            return;
        }
        private void frmPhieuMuon_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Opacity = 1;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server = .; database = QLTV; Integrated Security = true");
            DateTime ngayHetHan = BUS_OBJ.layNgayHetHan(lbMaThe.Text);
            if (ngayHetHan > DateTime.Today)
            {
                int soPhieuMuonChoDuyet = BUS_OBJ.laySoPhieuMuonDangChoDuyet(lbMaThe.Text);
                if (soPhieuMuonChoDuyet >= 3)
                    MetroFramework.MetroMessageBox.Show(this, "Hiện bạn đã có 3 phiếu mượn đang chờ duyệt. \nVui lòng đợi thư viện duyệt trước khi tiếp tục mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    int soPhieuMuonTheoMaSach = BUS_OBJ.laySoPhieuMuonTheoMaSach(lbMaThe.Text,lbMaSach.Text);
                    if (soPhieuMuonTheoMaSach > 0)
                        MetroFramework.MetroMessageBox.Show(this, "Không thể tạo 2 phiếu mượn cho 1 mã sách duy nhất. \nHiện bạn đã có phiếu mượn chưa trả mã sách này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (dtpNgayMuon.Value < dtpNgayTra.Value)
                        {
                            PhieuMuon_DTO phieuMuon = new PhieuMuon_DTO(lbMaThe.Text,lbMaSach.Text,dtpNgayMuon.Value,dtpNgayTra.Value,"Chờ phê duyệt","");
                            BUS_OBJ.guiPhieuMuon(phieuMuon);
                            MetroFramework.MetroMessageBox.Show(this, "Gửi phiếu mượn thành công.\nVui lòng chờ phê duyệt phiếu mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else MetroFramework.MetroMessageBox.Show(this, "Điền ngày trả trước ngày mượn.\nVui lòng xem lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Thẻ của bạn hiện đã hết han. \nVui lòng liên hệ quản trị viên để làm thẻ mới trước khi mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
