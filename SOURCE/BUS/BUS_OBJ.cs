using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_OBJ
    {
        public static object layLoaiTaiKhoan(string tenDN, string mk)
        {
            return Sach_DAO.loaiTaiKhoan(tenDN, mk);
        }
        public static string layTenSach(string maSach)
        {
            return Sach_DAO.layTenSach(maSach);
        }
        public static string layTenDocGia(string maDocGia)
        {
            return Sach_DAO.layTenDocGia(maDocGia);
        }
        public static string layTenTacGia(string maTacGia)
        {
            return Sach_DAO.layTenTacGia(maTacGia);
        }
        public static string layTenTheLoai(string maTheLoai)
        {
            return Sach_DAO.layTenTheLoai(maTheLoai);
        }
        public static string layTenNXB(string maNXB)
        {
            return Sach_DAO.layTenNXB(maNXB);
        }
        public static string layMaTheTheoMaDocGia(string maDocGia)
        {
            return Sach_DAO.layMaTheTheoMaDocGia(maDocGia);
        }
        public static int laySoSachDuocMuon(string maThe)
        {
            return Sach_DAO.laySoSachDuocMuon(maThe);
        }
        public static int laySoSachDangMuon(string maThe)
        {
            return Sach_DAO.laySoSachDangMuon(maThe);
        }
        public static DateTime layNgayHetHan(string maThe)
        {
            return Sach_DAO.layNgayHetHan(maThe);
        }
        public static int laySoPhieuMuonDangChoDuyet(string maThe)
        {
            return Sach_DAO.demSoPhieuMuonTheoMaThe(maThe);
        }
        public static int laySoPhieuMuonTheoMaSach(string maThe,string maSach)
        {
            return Sach_DAO.demSoPhieuMuonTheoMaTheVaMaSach(maThe,maSach);
        }
        public static int demSoPhieuMuonChoDuyet()
        {
            return Sach_DAO.demSoPhieuMuonChoDuyet();
        }
        public static int demSoPhieuMuonTreHan()
        {
            return Sach_DAO.demSoPhieuMuonTreHan();
        }
        public static void taoMoiTKNV(string tenDN, string mk)
        {
            Sach_DAO.taoMoiTK(tenDN,mk);
        }
        public static void doiMK(string taiKhoan, string mkMoi)
        {
            Sach_DAO.doiMK(taiKhoan, mkMoi);
        }
        public static DataTable loadDSSach()
        {
            return Sach_DAO.loadDSSach();
        }
        public static DataTable loadDSTacGia()
        {
            return Sach_DAO.loadDSTacGia();
        }
        public static DataTable loadDSTheLoai()
        {
            return Sach_DAO.loadDSTheLoai();
        }
        public static DataTable loadDSNXB()
        {
            return Sach_DAO.loadDSNXB();
        }
        public static DataTable loadDSDocGia()
        {
            return Sach_DAO.loadDSDocGia();
        }
        public static DataTable loadDSLoaiDG()
        {
            return Sach_DAO.loadDSLoaiDG();
        }
        public static DataTable loadDSLoaiThe()
        {
            return Sach_DAO.loadDSLoaiThe();
        }
        public static DataTable loadDSThe()
        {
            return Sach_DAO.loadDSThe();
        }
        public static DataTable loadDSPhieuMuon()
        {
            return Sach_DAO.loadDSPhieuMuon();
        }
        public static DataTable loadDSPhieuMuonDaTra()
        {
            return Sach_DAO.loadDSPhieuMuonDaTra();
        }
        public static DataTable loadDSPhieuMuonChuaTra()
        {
            return Sach_DAO.loadDSPhieuMuonChuaTra();
        }
        public static void themSach(Sach_DTO sach)
        {
            Sach_DAO.themSach(sach);
        }
        public static void suaSach(Sach_DTO sach)
        {
            Sach_DAO.suaSach(sach);
        }
        public static void xoaSach(string maSach)
        {
            Sach_DAO.xoaSach(maSach);
        }
        public static void themTG(TacGia_DTO tacGia)
        {
            Sach_DAO.themTG(tacGia);
        }
        public static void suaTG(TacGia_DTO tacGia)
        {
            Sach_DAO.suaTG(tacGia);
        }
        public static void xoaTG(string maTacGia)
        {
            Sach_DAO.xoaTG(maTacGia);
        }
        public static void themNXB(NXB_DTO nXB)
        {
            Sach_DAO.themNXB(nXB);
        }
        public static void suaNXB(NXB_DTO nXB)
        {
            Sach_DAO.suaNXB(nXB);
        }
        public static void xoaNXB(string maNXB)
        {
            Sach_DAO.xoaNXB(maNXB);
        }
        public static void themTL(TheLoai_DTO theLoai)
        {
            Sach_DAO.themTL(theLoai);
        }
        public static void suaTL(TheLoai_DTO theLoai)
        {
            Sach_DAO.suaTL(theLoai);
        }
        public static void xoaTL(string maTheLoai)
        {
            Sach_DAO.xoaTL(maTheLoai);
        }
        public static int demSoTheTheoTen(string maDocGia)
        {
            return Sach_DAO.demSoTheTheoTen(maDocGia);
        }
        public static void themThe(The_DTO the)
        {
            Sach_DAO.themThe(the);
        }
        public static void themUser(string tenDN, string mK, int type)
        {
            Sach_DAO.themUser(tenDN, mK, type);
        }
        public static void suaUser(string tenDN, string mK, int type)
        {
            Sach_DAO.suaUser(tenDN, mK, type);
        }
        public static void xoaUser(string maDG)
        {
            Sach_DAO.xoaUser(maDG);
        }
        public static void themDG(DocGia_DTO docGia)
        {
            Sach_DAO.themDG(docGia);
        }
        public static void suaDG(DocGia_DTO docGia)
        {
            Sach_DAO.suaDG(docGia);
        }
        public static void xoaDG(string maDocGia)
        {
            Sach_DAO.xoaDG(maDocGia);
        }
        public static void xoaThe(string maThe)
        {
            Sach_DAO.xoaThe(maThe);
        }
        public static void suaThe(The_DTO the)
        {
            Sach_DAO.suaThe(the);
        }
        public static DataTable timKiemTheoMaSach(string maSach)
        {
            return Sach_DAO.timKiemTheoMaSach(maSach);
        }
        public static DataTable timKiemTheoTenSach(string tenSach)
        {
            return Sach_DAO.timKiemTheoTenSach(tenSach);
        }
        public static DataTable timKiemTheoTenTG(string tenTacGia)
        {
            return Sach_DAO.timKiemTheoTenTacGia(tenTacGia);
        }
        public static DataTable timKiemTheoTheLoai(string tenTheLoai)
        {
            return Sach_DAO.timKiemTheoTenTheLoai(tenTheLoai);
        }
        public static DataTable timKiemTheoNXB(string tenNXB)
        {
            return Sach_DAO.timKiemTheoNXB(tenNXB);
        }
        public static DataTable timKiemTheoNamXB(int namXB)
        {
            return Sach_DAO.timKiemTheoNamXB(namXB);
        }
        public static void guiPhieuMuon(PhieuMuon_DTO phieuMuon)
        {
            Sach_DAO.guiPhieuMuon(phieuMuon);
        }
        public static DataTable timKiemPhieuMuonTheoMaThe(string maThe)
        {
            return Sach_DAO.timKiemPhieuMuonTheoMaThe(maThe);
        }
        public static DataTable timKiemPhieuMuonDaTraTheoMaThe(string maThe)
        {
            return Sach_DAO.timKiemPhieuMuonDaTraTheoMaThe(maThe);
        }
        public static DataTable timKiemPhieuMuonTheoMaSach(string maSach)
        {
            return Sach_DAO.timKiemPhieuMuonTheoMaSach(maSach);
        }
        public static DataTable timKiemPhieuMuonDaTraTheoMaSach(string maSach)
        {
            return Sach_DAO.timKiemPhieuMuonDaTraTheoMaSach(maSach);
        }
        public static DataTable timKiemPhieuMuonTheoTinhTrang(string tinhTrang)
        {
            return Sach_DAO.timKiemPhieuMuonTheoTinhTrang(tinhTrang);
        }
        public static DataTable timKiemPhieuMuonTheoSoPhieu(int soPhieu)
        {
            return Sach_DAO.timKiemPhieuMuonTheoSoPhieu(soPhieu);
        }
        public static DataTable timKiemPhieuMuonDaTraTheoSoPhieu(int soPhieu)
        {
            return Sach_DAO.timKiemPhieuMuonDaTraTheoSoPhieu(soPhieu);
        }
        public static string layMaDocGiaTheoTenDocGia(string tenDocGia)
        {
            return Sach_DAO.layMaDocGiaTheoTenDocGia(tenDocGia);
        }
        public static string layMaSachTheoTenSach(string tenSach)
        {
            return Sach_DAO.layMaSachTheoTenSach(tenSach);
        }
        public static void duyetPhieuMuon(PhieuMuon_DTO phieuMuon)
        {
            Sach_DAO.duyetPhieuMuon(phieuMuon);
        }
        public static void suaPhieuMuonDangCho(PhieuMuon_DTO phieuMuon)
        {
            Sach_DAO.suaPhieuMuonDangCho(phieuMuon);
        }
        public static void tuChoiPhieuMuon(int soPhieu)
        {
            Sach_DAO.tuChoiPhieuMuon(soPhieu);
        }
        public static DataTable loadPhieuMuonChoDuyetTra()
        {
            return Sach_DAO.loadPhieuMuonChoDuyetTra();
        }
        public static DataTable loadDSSachDangMuonTheoMaThe(string maThe)
        {
            return Sach_DAO.loadDSSachDangMuonTheoMaThe(maThe);
        }
        public static DataTable loadTTPhieuMuonTheoMaTheVaMaSach(string maThe, string maSach)
        {
            return Sach_DAO.loadTTPhieuMuonTheoMaTheVaMaSach(maThe,maSach);
        }
        public static void yeuCauTraSach(int soPhieu)
        {
            Sach_DAO.yeuCauTraSach(soPhieu);
        }
        public static void duyetYeuCauTraSach(int soPhieu, string maThe, string maSach)
        {
            Sach_DAO.duyetYeuCauTraSach(soPhieu, maThe, maSach);
        }
        public static void tuChoiTraSach(int soPhieu)
        {
            Sach_DAO.tuChoiTraSach(soPhieu);
        }
        public static void xoaPhieuMuon(int soPhieu)
        {
            Sach_DAO.xoaPhieuMuon(soPhieu);
        }

        public static DocGia_DTO layTTDocGia(string maDocGia)
        {
            return DocGia_DAO.layTTDocGia(maDocGia);
        }

        public static string layTenLoaiDocGia(string maDocGia)
        {
            return DocGia_DAO.layTenLoaiDocGia(maDocGia);
        }

        public static The_DTO layTTThe(string maThe)
        {
            return The_DAO.layTTThe(maThe);
        }

    }
}
