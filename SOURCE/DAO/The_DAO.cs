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
    public class The_DAO
    {
        public static The_DTO layTTThe(string maThe)
        {
            SqlConnection conn = SQLConn.connect();
            conn.Open();
            The_DTO the = new The_DTO();
            the.MaThe = maThe;
            SqlCommand cmd = new SqlCommand("Select NgayCapThe from The where MaThe = '" + maThe + "'", conn);
            string chuoiNgayCap = cmd.ExecuteScalar().ToString();
            DateTime ngayCap = new DateTime();
            DateTime.TryParse(chuoiNgayCap, out ngayCap);
            the.NgayCapThe = ngayCap;
            SqlCommand cmd1 = new SqlCommand("Select NgayHetHan from The where MaThe = '" + maThe + "'", conn);
            string chuoiNgayHetHan = cmd1.ExecuteScalar().ToString();
            DateTime ngayHetHan = new DateTime();
            DateTime.TryParse(chuoiNgayHetHan, out ngayHetHan);
            the.NgayHetHan = ngayHetHan;
            SqlCommand cmd2 = new SqlCommand("Select SoSachDuocMuon from The where MaThe = '" + maThe + "'", conn);
            the.SoSachDuocMuon = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            SqlCommand cmd3 = new SqlCommand("Select SoSachDangMuon from The where MaThe = '" + maThe + "'", conn);
            the.SoSachDangMuon = Convert.ToInt32(cmd3.ExecuteScalar().ToString());
            conn.Close();
            return the;
        }
    }
}
