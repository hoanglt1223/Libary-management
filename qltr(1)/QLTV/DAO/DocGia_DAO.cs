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
    public class DocGia_DAO
    {
        //load DS Doc gia
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

        public static DocGia_DTO layTTDocGia(string maDocGia)
        {
            SqlConnection conn = SQLConn.connect();
            DocGia_DTO docGia = new DocGia_DTO();
            conn.Open();
            docGia.MaDocGia = maDocGia;
            SqlCommand cmd = new SqlCommand("Select TenDocGia from DocGia where MaDocGia = '" + maDocGia + "'", conn);
            docGia.TenDocGia = cmd.ExecuteScalar().ToString();
            SqlCommand cmd1 = new SqlCommand("Select GioiTinh from DocGia where MaDocGia = '" + maDocGia + "'", conn);
            docGia.GioiTinh = cmd1.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand("Select NgaySinh from DocGia where MaDocGia = '" + maDocGia + "'", conn);
            string chuoiNgaySinh = cmd2.ExecuteScalar().ToString();
            DateTime ngaySinh = new DateTime();
            DateTime.TryParse(chuoiNgaySinh, out ngaySinh);
            docGia.NgaySinh = ngaySinh;
            SqlCommand cmd3 = new SqlCommand("Select DiaChi from DocGia where MaDocGia = '" + maDocGia + "'", conn);
            docGia.DiaChi = cmd3.ExecuteScalar().ToString();
            SqlCommand cmd4 = new SqlCommand("Select SoCMT from DocGia where MaDocGia = '" + maDocGia + "'", conn);
            docGia.SoCMT = cmd4.ExecuteScalar().ToString();
            SqlCommand cmd5 = new SqlCommand("Select MaLoaiDocGia from DocGia where MaDocGia = '" + maDocGia + "'", conn);
            docGia.MaLoaiDocGia = cmd5.ExecuteScalar().ToString();
            conn.Close();
            return docGia;
        }

        public static string layTenLoaiDocGia(string maDocGia)
        {
            SqlConnection conn = SQLConn.connect();
            string tenLoaiDocGia = "";
            conn.Open();
            SqlCommand cmd5 = new SqlCommand("Select TenLoaiDocGia from LoaiDocGia where MaLoaiDocGia = (Select MaLoaiDocGia from DocGia where MaDocGia = '" + maDocGia + "')", conn);
            tenLoaiDocGia = cmd5.ExecuteScalar().ToString();
            conn.Close();
            return tenLoaiDocGia;
        }
    }
}
