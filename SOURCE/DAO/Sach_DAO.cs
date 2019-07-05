using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class Sach_DAO
    {
        //load DS Sach
        public static DataTable loadDSSach()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // dem so phieu muon theo ma the (phieu dang cho phe duyet)
        public static int demSoPhieuMuonTheoMaThe(string maThe)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_demSoPhieuMuonTheoMaThe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            conn.Open();
            int soPhieuMuonChoDuyet = Convert.ToInt16(cmd.ExecuteScalar());
            conn.Close();
            return soPhieuMuonChoDuyet;
        }
        // dem so phieu muon theo ma the va ma sach (phieu dang cho duyet hoac da muon nhung chua tra)
        public static int demSoPhieuMuonTheoMaTheVaMaSach(string maThe, string maSach)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_demSoPhieuMuonTheoMaTheVaMaSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = maSach;
            conn.Open();
            int soPhieuMuonTheoMaSach = Convert.ToInt16(cmd.ExecuteScalar());
            conn.Close();
            return soPhieuMuonTheoMaSach;
        }
        // dem so the theo ten
        public static int demSoTheTheoTen(string maDocGia)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_demSoTheTheoTen", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = maDocGia;
            conn.Open();
            int soTheTheoTen = Convert.ToInt16(cmd.ExecuteScalar());
            conn.Close();
            return soTheTheoTen;
        }
        // check loai tai khoan
        public static object loaiTaiKhoan(string tenDN, string matKhau)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loaiTaiKhoan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendn", SqlDbType.NVarChar).Value = tenDN;
            cmd.Parameters.Add("@mk", SqlDbType.NVarChar).Value = matKhau;
            conn.Open();
            object loaiTaiKhoan = cmd.ExecuteScalar();
            conn.Close();
            return loaiTaiKhoan;
        }
        // lay ten sach
        public static string layTenSach(string maSach)
        {
            string tenSach = "";
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_layTenSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = maSach;
            conn.Open();
            tenSach = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return tenSach;
        }
        // lay ten doc gia
        public static string layTenDocGia(string maDocGia)
        {
            string tenDocGia = "";
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_layTenDocGia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = maDocGia;
            conn.Open();
            tenDocGia = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return tenDocGia;
        }
        // lay ten tac gia
        public static string layTenTacGia(string maTacGia)
        {
            string tenTacGia = "";
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_layTenTacGia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@matacgia", SqlDbType.VarChar).Value = maTacGia;
            conn.Open();
            tenTacGia = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return tenTacGia;
        }
        // lay ten the loai
        public static string layTenTheLoai(string maTheLoai)
        {
            string tenTheLoai = "";
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_layTenTheLoai", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@matheloai", SqlDbType.VarChar).Value = maTheLoai;
            conn.Open();
            tenTheLoai = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return tenTheLoai;
        }
        // lay ten NXB
        public static string layTenNXB(string maNXB)
        {
            string tenNXB = "";
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_layTenNXB", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maNXB", SqlDbType.VarChar).Value = maNXB;
            conn.Open();
            tenNXB = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return tenNXB;
        }
        public static string layMaTheTheoMaDocGia(string maDocGia)
        {
            string maThe = "";
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_layMaTheTheoMaDG", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = maDocGia;
            conn.Open();
            maThe = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return maThe;
        }
        public static int laySoSachDuocMuon(string maThe)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_laySoSachDuocMuon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            conn.Open();
            int soSachDuocMuon = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return soSachDuocMuon;
        }
        public static int laySoSachDangMuon(string maThe)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_laySoSachDangMuon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            conn.Open();
            int soSachDangMuon = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return soSachDangMuon;
        }
        public static DateTime layNgayHetHan(string maThe)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_layNgayHetHan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            conn.Open();
            string strNgayHetHan = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            DateTime ngayHetHan = new DateTime();
            DateTime.TryParse(strNgayHetHan, out ngayHetHan);
            return ngayHetHan;
        }
        //tao moi tai khoan
        public static void taoMoiTK(string tenDN, string mk) 
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_taomoitk", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendangnhap", SqlDbType.NVarChar).Value = tenDN;
            cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = mk;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();        
        }
        public static void doiMK(string taiKhoan, string mkMoi)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_doimk", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendangnhap", SqlDbType.NVarChar).Value = taiKhoan;
            cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = mkMoi;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable loadDSTacGia()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaTacGia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable loadDSPhieuMuon()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaPhieuMuon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable loadDSPhieuMuonDaTra()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaPhieuMuonDaTra", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable loadDSPhieuMuonChuaTra()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaPhieuMuonChuaTra", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable loadDSTheLoai()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaTheLoai", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable loadDSNXB()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaNXB", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void themSach(Sach_DTO sach)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_themSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = sach.MaSach;
            cmd.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = sach.TenSach;
            cmd.Parameters.Add("@matacgia", SqlDbType.VarChar).Value = sach.MaTacGia;
            cmd.Parameters.Add("@matheloai", SqlDbType.VarChar).Value = sach.MaTheLoai;
            cmd.Parameters.Add("@manhaxuatban", SqlDbType.VarChar).Value = sach.MaNXB;
            cmd.Parameters.Add("@namxuatban", SqlDbType.Int).Value = sach.NamXuatBan;
            cmd.Parameters.Add("@sotrang", SqlDbType.Int).Value = sach.SoTrang;
            cmd.Parameters.Add("@gia", SqlDbType.Int).Value = sach.Gia;
            cmd.Parameters.Add("@soban", SqlDbType.Int).Value = sach.SoBan;
            cmd.Parameters.Add("@sobanton", SqlDbType.Int).Value = sach.SoBanTon;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void suaSach(Sach_DTO sach)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_suaSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = sach.MaSach;
            cmd.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = sach.TenSach;
            cmd.Parameters.Add("@matacgia", SqlDbType.VarChar).Value = sach.MaTacGia;
            cmd.Parameters.Add("@matheloai", SqlDbType.VarChar).Value = sach.MaTheLoai;
            cmd.Parameters.Add("@manhaxuatban", SqlDbType.VarChar).Value = sach.MaNXB;
            cmd.Parameters.Add("@namxuatban", SqlDbType.Int).Value = sach.NamXuatBan;
            cmd.Parameters.Add("@sotrang", SqlDbType.Int).Value = sach.SoTrang;
            cmd.Parameters.Add("@gia", SqlDbType.Int).Value = sach.Gia;
            cmd.Parameters.Add("@soban", SqlDbType.Int).Value = sach.SoBan;
            cmd.Parameters.Add("@sobanton", SqlDbType.Int).Value = sach.SoBanTon;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void xoaSach(string maSach)
        {
            SqlConnection conn = SQLConn.connect();           
            SqlCommand cmd = new SqlCommand("sp_xoaSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = maSach;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void themTG(TacGia_DTO tacGia)
        {
            SqlConnection conn = SQLConn.connect();          
            SqlCommand cmd = new SqlCommand("sp_themTG", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@matacgia", SqlDbType.VarChar).Value = tacGia.MaTacGia;
            cmd.Parameters.Add("@tentacgia", SqlDbType.NVarChar).Value = tacGia.TenTacGia;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = tacGia.GhiChu;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void suaTG(TacGia_DTO tacGia)
        {
            SqlConnection conn = SQLConn.connect();   
            SqlCommand cmd = new SqlCommand("sp_suaTG", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@matacgia", SqlDbType.VarChar).Value = tacGia.MaTacGia;
            cmd.Parameters.Add("@tentacgia", SqlDbType.NVarChar).Value = tacGia.TenTacGia;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = tacGia.GhiChu;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void xoaTG(string maTacGia)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_xoaTG", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@matacgia", SqlDbType.VarChar).Value = maTacGia;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void themNXB(NXB_DTO nXB)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_themnxb", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manxb", SqlDbType.VarChar).Value = nXB.MaNXB;
            cmd.Parameters.Add("@tennxb", SqlDbType.NVarChar).Value = nXB.TenNXB;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = nXB.GhiChu;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void suaNXB(NXB_DTO nXB)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_suanxb", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manxb", SqlDbType.VarChar).Value = nXB.MaNXB;
            cmd.Parameters.Add("@tennxb", SqlDbType.NVarChar).Value = nXB.TenNXB;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = nXB.GhiChu;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void xoaNXB(string maNXB)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_xoanxb", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manxb", SqlDbType.VarChar).Value = maNXB;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void themTL(TheLoai_DTO theLoai)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_themtheloai", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@matheloai", SqlDbType.VarChar).Value = theLoai.MaTheLoai;
            cmd.Parameters.Add("@tentheloai", SqlDbType.NVarChar).Value = theLoai.TenTheLoai;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void suaTL(TheLoai_DTO theLoai)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_suatheloai", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@matheloai", SqlDbType.VarChar).Value = theLoai.MaTheLoai;
            cmd.Parameters.Add("@tentheloai", SqlDbType.NVarChar).Value = theLoai.TenTheLoai;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void xoaTL(string maTheLoai)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_xoatheloai", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@matheloai", SqlDbType.VarChar).Value = maTheLoai;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable loadDSLoaiDG()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaLoaiDocGia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable loadDSDocGia()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaDocGia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void themThe(The_DTO the)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd1 = new SqlCommand("sp_themthe", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@mathe", SqlDbType.VarChar).Value = the.MaThe;
            cmd1.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = the.MaDocGia;
            cmd1.Parameters.Add("@maloaithe", SqlDbType.VarChar).Value = the.MaLoaiThe;
            cmd1.Parameters.Add("@ngaycapthe", SqlDbType.Date).Value = the.NgayCapThe;
            cmd1.Parameters.Add("@ngayhethan", SqlDbType.Date).Value = the.NgayHetHan;
            cmd1.Parameters.Add("@sosachduocmuon", SqlDbType.Int).Value = the.SoSachDuocMuon;
            cmd1.Parameters.Add("@sosachdangmuon", SqlDbType.Int).Value = the.SoSachDangMuon;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }
        public static void themUser(string tenDN, string mK, int type)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_themuser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@uid", SqlDbType.NVarChar).Value = tenDN;
            cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = mK;
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void suaUser(string tenDN, string mK, int type)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_suauser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@uid", SqlDbType.NVarChar).Value = tenDN;
            cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = mK;
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void xoaUser(string maDG)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_xoauser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@uid", SqlDbType.NVarChar).Value = maDG;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void themDG(DocGia_DTO docGia)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_themdocgia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = docGia.MaDocGia;
            cmd.Parameters.Add("@tendocgia", SqlDbType.NVarChar).Value = docGia.TenDocGia;
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = docGia.GioiTinh;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = docGia.NgaySinh;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = docGia.DiaChi;
            cmd.Parameters.Add("@socmt", SqlDbType.VarChar).Value = docGia.SoCMT;
            cmd.Parameters.Add("@loaidocgia", SqlDbType.VarChar).Value = docGia.MaLoaiDocGia;
            cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = docGia.MatKhau;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void suaDG(DocGia_DTO docGia)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_suadocgia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = docGia.MaDocGia;
            cmd.Parameters.Add("@tendocgia", SqlDbType.NVarChar).Value = docGia.TenDocGia;
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = docGia.GioiTinh;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = docGia.NgaySinh;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = docGia.DiaChi;
            cmd.Parameters.Add("@socmt", SqlDbType.VarChar).Value = docGia.SoCMT;
            cmd.Parameters.Add("@loaidocgia", SqlDbType.VarChar).Value = docGia.MaLoaiDocGia;
            cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = docGia.MatKhau;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void xoaDG(string maDocGia)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd1 = new SqlCommand("sp_xoathe", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = maDocGia;
            SqlCommand cmd = new SqlCommand("sp_xoadocgia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = maDocGia;
            conn.Open();
            cmd1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable loadDSLoaiThe()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaLoaiThe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable loadDSThe()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTatCaThe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void xoaThe(string maThe)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_xoathe1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void suaThe(The_DTO the)
        {
            SqlConnection conn = SQLConn.connect(); 
            SqlCommand cmd = new SqlCommand("sp_suathe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = the.MaThe;
            cmd.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = the.MaDocGia;
            cmd.Parameters.Add("@maloaithe", SqlDbType.VarChar).Value = the.MaLoaiThe;
            cmd.Parameters.Add("@ngaycapthe", SqlDbType.Date).Value = the.NgayCapThe;
            cmd.Parameters.Add("@ngayhethan", SqlDbType.Date).Value = the.NgayHetHan;
            cmd.Parameters.Add("@sosachduocmuon", SqlDbType.Int).Value = the.SoSachDuocMuon;
            cmd.Parameters.Add("@sosachdangmuon", SqlDbType.Int).Value = the.SoSachDangMuon;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable timKiemTheoMaSach(string maSach)
        {
            SqlConnection conn = SQLConn.connect(); 
            SqlCommand cmd = new SqlCommand("sp_timKiemTheoMaSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = maSach;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemTheoTenSach(string tenSach)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemTheoTenSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = tenSach;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemTheoTenTacGia(string tenTacGia)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemTheoTenTG", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tentacgia", SqlDbType.NVarChar).Value = tenTacGia;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemTheoTenTheLoai(string tenTheLoai)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemTheoTheLoai", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tentheloai", SqlDbType.NVarChar).Value = tenTheLoai;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemTheoNXB(string tenNXB)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemTheoNXB", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tennxb", SqlDbType.NVarChar).Value = tenNXB;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemTheoNamXB(int namXB)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemTheoNamXB", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@namxb", SqlDbType.Int).Value = namXB;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void guiPhieuMuon(PhieuMuon_DTO phieuMuon)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_themphieumuon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = phieuMuon.MaThe;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = phieuMuon.MaSach;
            cmd.Parameters.Add("@ngaymuon", SqlDbType.Date).Value = phieuMuon.NgayMuon;
            cmd.Parameters.Add("@ngaytra", SqlDbType.Date).Value = phieuMuon.NgayTra;
            cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = phieuMuon.TinhTrang;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = phieuMuon.GhiChu;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable timKiemPhieuMuonTheoMaThe(string maThe)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemPhieuMuonTheoMaThe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemPhieuMuonDaTraTheoMaThe(string maThe)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemPhieuMuonDaTraTheoMaThe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemPhieuMuonTheoMaSach(string maSach)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemPhieuMuonTheoMaSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = maSach;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemPhieuMuonDaTraTheoMaSach(string maSach)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemPhieuMuonDaTraTheoMaSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = maSach;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemPhieuMuonTheoTinhTrang(string tinhTrang)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemPhieuMuonTheoTinhTrang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhTrang;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemPhieuMuonTheoSoPhieu(int soPhieu)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemPhieuMuonTheoSoPhieu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.Int).Value = soPhieu;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable timKiemPhieuMuonDaTraTheoSoPhieu(int soPhieu)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_timKiemPhieuMuonDaTraTheoSoPhieu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.Int).Value = soPhieu;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static string layMaDocGiaTheoTenDocGia(string tenDocGia)
        {
            string maDocGia = "";
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_layMaDocGiaTheoTenDocGia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendocgia", SqlDbType.NVarChar).Value = tenDocGia;
            conn.Open();
            if (cmd.ExecuteScalar() != null)
                maDocGia = cmd.ExecuteScalar().ToString();
            conn.Close();
            return maDocGia;
        }
        public static string layMaSachTheoTenSach(string tenSach)
        {
            string maSach = "";
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_layMaSachTheoTenSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = tenSach;
            conn.Open();
            if (cmd.ExecuteScalar() != null)
                maSach = cmd.ExecuteScalar().ToString();
            conn.Close();
            return maSach;
        }
        public static void duyetPhieuMuon(PhieuMuon_DTO phieuMuon)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_duyetphieumuon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.Int).Value = phieuMuon.SoPhieu;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = phieuMuon.MaThe;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = phieuMuon.MaSach;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void suaPhieuMuonDangCho(PhieuMuon_DTO phieuMuon)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_suaphieumuondangcho", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.Int).Value = phieuMuon.SoPhieu;
            cmd.Parameters.Add("@ngaymuon", SqlDbType.Date).Value = phieuMuon.NgayMuon;
            cmd.Parameters.Add("@ngaytra", SqlDbType.Date).Value = phieuMuon.NgayTra;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = phieuMuon.GhiChu;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void tuChoiPhieuMuon(int soPhieu)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_tuchoiphieumuon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.Int).Value = soPhieu;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable loadPhieuMuonChoDuyetTra()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadPhieuMuonChoDuyetTra", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable loadDSSachDangMuonTheoMaThe(string maThe)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadDSSachDangMuonTheoMaThe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable loadTTPhieuMuonTheoMaTheVaMaSach(string maThe, string maSach)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_loadTTPhieuMuonTheoMaTheVaMaSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            cmd.Parameters.Add("@masach", SqlDbType.VarChar).Value = maSach;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void yeuCauTraSach(int soPhieu)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_yeucautrasach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.Int).Value = soPhieu;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void duyetYeuCauTraSach(int soPhieu, string maThe, string maSach)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd3 = new SqlCommand("sp_duyetyeucautrasach", conn);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add("@sophieu", SqlDbType.Int).Value = soPhieu;
            cmd3.Parameters.Add("@mathe", SqlDbType.VarChar).Value = maThe;
            cmd3.Parameters.Add("@masach", SqlDbType.VarChar).Value = maSach;
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
        }
        public static void tuChoiTraSach(int soPhieu) {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_tuchoitrasach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.Int).Value = soPhieu;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void xoaPhieuMuon(int soPhieu)
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_xoaPhieuMuon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.Int).Value = soPhieu;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static int demSoPhieuMuonChoDuyet()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_demSoPhieuMuonChoDuyet", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return result;
        }

        public static int demSoPhieuMuonTreHan()
        {
            SqlConnection conn = SQLConn.connect();
            SqlCommand cmd = new SqlCommand("sp_demSoPhieuMuonTreHan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return result;
        }
    }
}
