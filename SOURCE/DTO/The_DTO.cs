using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class The_DTO
    {
        private string _maThe;

        public string MaThe
        {
            get { return _maThe; }
            set { _maThe = value; }
        }
        private string _maDocGia;

        public string MaDocGia
        {
            get { return _maDocGia; }
            set { _maDocGia = value; }
        }
        private string _maLoaiThe;

        public string MaLoaiThe
        {
            get { return _maLoaiThe; }
            set { _maLoaiThe = value; }
        }
        private DateTime _ngayCapThe;

        public DateTime NgayCapThe
        {
            get { return _ngayCapThe; }
            set { _ngayCapThe = value; }
        }
        private DateTime _ngayHetHan;

        public DateTime NgayHetHan
        {
            get { return _ngayHetHan; }
            set { _ngayHetHan = value; }
        }
        private int _soSachDuocMuon;

        public int SoSachDuocMuon
        {
            get { return _soSachDuocMuon; }
            set { _soSachDuocMuon = value; }
        }
        private int _soSachDangMuon;

        public int SoSachDangMuon
        {
            get { return _soSachDangMuon; }
            set { _soSachDangMuon = value; }
        }
        public The_DTO(string maThe, string maDocGia, string maLoaiThe, DateTime ngayCapThe, DateTime ngayHetHan, int soSachDuocMuon, int soSachDangMuon)
        {
            MaThe = maThe;
            MaDocGia = maDocGia;
            MaLoaiThe = maLoaiThe;
            NgayCapThe = ngayCapThe;
            NgayHetHan = ngayHetHan;
            SoSachDuocMuon = soSachDuocMuon;
            SoSachDangMuon = soSachDangMuon;
        }

        public The_DTO()
        {
            MaThe = "";
            MaDocGia = "";
            MaLoaiThe = "";
            NgayCapThe = DateTime.Today;
            NgayHetHan = DateTime.Today;
            SoSachDuocMuon = 0;
            SoSachDangMuon = 0;
        }
    }
}
