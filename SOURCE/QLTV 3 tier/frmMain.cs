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
    public partial class frmMain : MetroForm
    {

        private DTO.DangNhap_DTO user;
        public delegate void delPassUserData(DangNhap_DTO user);
        private Boolean isRunning;

        public frmMain()
        {
            InitializeComponent();
            pnlInfo.Hide();
            pnMunSach.Hide();
            menuStripMain.Enabled = false;
            user = new DangNhap_DTO();
            isRunning = true;
            tmShowInfo.Start();
            timertieude.Start();
            txtUser.Focus();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FocusMe();
        }

        public void showInfo()
        {
            if (this.user.TenDangNhap != "") {
                if (this.user.LoaiTaiKhoan == 1)
                {
                    
                    groupboxLogin.Hide();
                    lbXinChao.Text = "Xin chào " + user.TenDangNhap  + " !";
                    
                    lbContent.Text = "Phiếu mượn: " + BUS_OBJ.demSoPhieuMuonChoDuyet().ToString()
                                   + "\nPhiếu trễ hẹn: " + BUS_OBJ.demSoPhieuMuonTreHan().ToString();
                    pnlInfo.Show();
                    HienThiDuLieuPhieuMuon();
                    HienThiDuLieuPhieuTra();
                }
                else
                {
                    groupboxLogin.Hide();                    
                    
                    lbXinChao.Text = "Xin chào " + BUS_OBJ.layTenDocGia(user.TenDangNhap) +" !";
                    
                    int soSachDuocMuon = BUS_OBJ.laySoSachDuocMuon(user.TenDangNhap);
                    int soSachDangMuon = BUS_OBJ.laySoSachDangMuon(user.TenDangNhap);

                    if (soSachDuocMuon > soSachDangMuon)
                    {
                        if (soSachDangMuon == 0)
                        {
                            lbContent.Text = "Bạn đang mượn:\n        0 sách"
                                        + "\nCòn lại: " + soSachDuocMuon.ToString() + " sách";
                        }
                        else
                        {
                            lbContent.Text = "Bạn đang mượn:\n        " + soSachDangMuon.ToString() + " sách"
                                        + "\nCòn lại: " + (soSachDuocMuon - soSachDangMuon).ToString() + " sách";
                        }
                    }
                    else
                    {
                        lbContent.Text = "Bạn đang mượn:\n        " + soSachDangMuon.ToString() + " sách";
                    }
                    pnMunSach.Show();
                    txtThongTinTimKiem.Text="";
                    pnlInfo.Show();
                    HienThiDuLieuSach();
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,"Bạn có muốn thoát khỏi chương trình không ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                isRunning = false;
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
        private void HienThiDuLieuSach()
        {
            this.datagvSach.DataSource = null;
            this.datagvSach.DataSource = BUS_OBJ.loadDSSach();
            hieuChinhDGV();
        }

        private void hieuChinhDGV()
        {
            datagvSach.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datagvSach.Columns[0].HeaderText = "Mã sách";
            datagvSach.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            datagvSach.Columns[1].HeaderText = "Tên sách";
            datagvSach.Columns[1].Width = 180;
            datagvSach.Columns[2].HeaderText = "Mã tác giả";

            datagvSach.Columns[3].HeaderText = "Mã thể loại";

            datagvSach.Columns[4].HeaderText = "Nhà XB";

            datagvSach.Columns[5].HeaderText = "Năm XB";

            datagvSach.Columns[6].HeaderText = "Số trang";

            datagvSach.Columns[7].HeaderText = "Giá";

            datagvSach.Columns[8].HeaderText = "Số bản";

            datagvSach.Columns[9].HeaderText = "Tồn";

        }      


       
        private void HienThiDuLieuPhieuMuon()
        {

        }

        private void HienThiDuLieuPhieuTra()
        {

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripMain.Enabled = false;
            pnlInfo.Hide();
            pnMunSach.Hide();
            lbXinChao.Text = "Xin chào ";
            
            lbContent.Text = "Thống kê";
            groupboxLogin.Show();
            txtUser.Text = "";
            txtPwd.Text = "";
            user.TenDangNhap = "";
            user.MatKhau = "";
            user.LoaiTaiKhoan = 10;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMK doiMK = new frmDoiMK(this);
            delPassUserData del = new delPassUserData(doiMK.receivingData);
            del(this.user);
            this.Opacity = .75;
            doiMK.ShowDialog();
        }

        private void tạoMớiTKNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaoMoiTKNV taoMoiTKNV = new frmTaoMoiTKNV(this);
            this.Opacity = .75;
            taoMoiTKNV.ShowDialog();
        }

        private void cậpNhậtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatSach capNhatSach = new frmCapNhatSach(this);
            this.Opacity = .75;
            capNhatSach.ShowDialog();
        }

        private void cậpNhậtTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatTacGia capNhatTG = new frmCapNhatTacGia(this);
            this.Opacity = .75;
            capNhatTG.ShowDialog();
        }

        private void cậpNhậtNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatNXB capNhatNXB = new frmCapNhatNXB(this);
            this.Opacity = .75;
            capNhatNXB.ShowDialog();
        }

        private void cậpNhậtThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatTheLoai capNhatTheLoai = new frmCapNhatTheLoai(this);
            this.Opacity = .75;
            capNhatTheLoai.ShowDialog();
        }

        private void cậpNhậtĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatDocGia capNhatDocGia = new frmCapNhatDocGia(this);
            this.Opacity = .75;
            capNhatDocGia.ShowDialog();
        }

        private void cậpNhậtThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatThe capNhatThe = new frmCapNhatThe(this);
            this.Opacity = .75;
            capNhatThe.ShowDialog();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonSach muonSach = new frmMuonSach(this);
            delPassUserData del = new delPassUserData(muonSach.receivingData);
            del(this.user);
            this.Opacity = .75;
            muonSach.ShowDialog();
        }

        private void quảnLýPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinPhieuMuon thongTinPhieuMuon = new frmThongTinPhieuMuon(this);
            this.Opacity = .75;
            thongTinPhieuMuon.ShowDialog();
        }

        private void duyệtPhiếuMượnĐangChờToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDuyetPhieuMuonDangCho duyetPhieuMuonDangCho = new frmDuyetPhieuMuonDangCho(this);
            this.Opacity = .75;
            duyetPhieuMuonDangCho.ShowDialog();
        }

        private void duyệtYêuCầuTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDuyetYeuCauTra duyetYeuCauTra = new frmDuyetYeuCauTra(this);
            this.Opacity = .75;
            duyetYeuCauTra.ShowDialog();
        }

        private void xóaPhiếuMượnĐãTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXoaPhieuMuon xoaPhieuMuon = new frmXoaPhieuMuon(this);
            this.Opacity = .75;
            xoaPhieuMuon.ShowDialog();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.user.LoaiTaiKhoan == 0)
            {
                frmTraSach traSach = new frmTraSach(this);
                delPassUserData del = new delPassUserData(traSach.receivingData);
                del(this.user);
                this.Opacity = .75;
                traSach.ShowDialog();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Mã thẻ của bạn không khả dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thốngKêSáchĐangMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeSachDangMuon thongKeSachDangMuon = new frmThongKeSachDangMuon(this);
            this.Opacity = .75;
            thongKeSachDangMuon.ShowDialog();
        }

        private void thốngKêSáchĐãTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeSachDaTra thongKeSachDaTra = new frmThongKeSachDaTra(this);
            this.Opacity = .75;
            thongKeSachDaTra.ShowDialog();
        }

        private void thốngKêSáchTrảMuộnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeSachTreHan thongKeSachTreHan = new frmThongKeSachTreHan(this);
            this.Opacity = .75;
            thongKeSachTreHan.ShowDialog();
        }

        private void tmShowInfo_Tick(object sender, EventArgs e)
        {
            if (!this.isRunning)
            {
                tmShowInfo.Enabled = false;
            }
            else
            {
                showInfo();
            }
        }
        public int i = 10;
        private void timertieude_Tick(object sender, EventArgs e)
        {
            lbtieude.Left += i;
            if (lbtieude.Left >= this.Width + 15 || lbtieude.Left <= 0)
                i = -i;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                object objLoaiTK = BUS_OBJ.layLoaiTaiKhoan(txtUser.Text, txtPwd.Text);
                if (objLoaiTK != null)
                {
                    if (objLoaiTK.ToString() == "1")// quyền admin
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        menuStripMain.Enabled = true;
                        tàiKhoảnToolStripMenuItem.Enabled = true;
                        quảnLýHệThốngToolStripMenuItem.Enabled = true;
                        quảnLýMượntrảToolStripMenuItem.Enabled = true;
                        sáchToolStripMenuItem.Enabled = true;
                        báoCáoThốngKêToolStripMenuItem.Enabled = true;
                        tạoMớiTKNVToolStripMenuItem.Enabled = true;
                        user.TenDangNhap = txtUser.Text;
                        user.MatKhau = txtPwd.Text;
                        user.LoaiTaiKhoan = Convert.ToInt16(objLoaiTK);

                        this.showInfo();
                    }
                    else if (objLoaiTK.ToString() == "0")// quyền user
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        menuStripMain.Enabled = true;
                        tàiKhoảnToolStripMenuItem.Enabled = true;
                        quảnLýHệThốngToolStripMenuItem.Enabled = false;
                        quảnLýMượntrảToolStripMenuItem.Enabled = false;
                        sáchToolStripMenuItem.Enabled = true;
                        báoCáoThốngKêToolStripMenuItem.Enabled = false;
                        tạoMớiTKNVToolStripMenuItem.Enabled = false;
                        user.TenDangNhap = txtUser.Text;
                        user.MatKhau = txtPwd.Text;
                        user.LoaiTaiKhoan = Convert.ToInt16(objLoaiTK);
                        this.showInfo();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Text = "";
                    txtPwd.Text = "";
                    txtUser.Focus();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Text = "";
                txtPwd.Text = "";
                txtUser.Focus();
            }
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTin thongTin = new frmThongTin(this);
            this.Opacity = .75;
            thongTin.ShowDialog();
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            if (txtThongTinTimKiem.Text == "")
            {
                HienThiDuLieuSach();
            }
            else
            {
                timKiemTheoTenSach(txtThongTinTimKiem.Text.Trim());
            }
        }

        private void btnMuon_Click_1(object sender, EventArgs e)
        {
            if (datagvSach.SelectedRows == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn 1 cuốn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (datagvSach.Rows[0].Cells[9].Value.ToString() == "0")
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
                                for (int i = 0; i < datagvSach.Rows.Count; i++)
                                    for (int j = 0; j < datagvSach.Columns.Count; j++)
                                        if (datagvSach.Rows[i].Cells[j].Selected == true)
                                        {
                                            muon.setLabelMaSach(datagvSach.Rows[i].Cells[0].Value.ToString());
                                            muon.setLabelTenSach(datagvSach.Rows[i].Cells[1].Value.ToString());

                                        }
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

        private void txtThongTinTimKiem_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (txtThongTinTimKiem.Text == "")
            {
                HienThiDuLieuSach();
            }
            else
            {
                this.datagvSach.DataSource = null;
                DataTable dt = BUS_OBJ.timKiemTheoTenSach(txtThongTinTimKiem.Text.Trim());
                if (dt.Rows.Count != 0)
                {
                    this.datagvSach.DataSource = dt;
                    hieuChinhDGV();
                }
            }
        }
        private void timKiemTheoTenSach(string tenSach)
        {
            this.datagvSach.DataSource = null;
            DataTable dt = BUS_OBJ.timKiemTheoTenSach(tenSach);
            if (dt.Rows.Count != 0)
            {
                this.datagvSach.DataSource = dt;
                hieuChinhDGV();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy tên sách tương tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTinTimKiem.Focus();
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }

}
