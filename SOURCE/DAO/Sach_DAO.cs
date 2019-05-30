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

        // dem so phieu muon theo ma the va ma sach (phieu dang cho duyet hoac da muon nhung chua tra)

        // dem so the theo ten

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
        
    }
}
