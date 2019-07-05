using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuon_DTO
    {
        private int _soPhieu;

        public int SoPhieu
        {
            get { return _soPhieu; }
            set { _soPhieu = value; }
        }
        private string _maThe;

        public string MaThe
        {
            get { return _maThe; }
            set { _maThe = value; }
        }
        private string _maSach;

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        private DateTime _ngayMuon;

        public DateTime NgayMuon
        {
            get { return _ngayMuon; }
            set { _ngayMuon = value; }
        }
        private DateTime _ngayTra;

        public DateTime NgayTra
        {
            get { return _ngayTra; }
            set { _ngayTra = value; }
        }
        private string _tinhTrang;

        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public PhieuMuon_DTO(int soPhieu, string maThe, string maSach, DateTime ngayMuon, DateTime ngayTra, string tinhTrang, string ghiChu)
        {
            SoPhieu = soPhieu;
            MaThe = maThe;
            MaSach = maSach;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
            TinhTrang = tinhTrang;
            GhiChu = ghiChu;
        }
        public PhieuMuon_DTO(string maThe, string maSach, DateTime ngayMuon, DateTime ngayTra, string tinhTrang, string ghiChu)
        {
            MaThe = maThe;
            MaSach = maSach;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
            TinhTrang = tinhTrang;
            GhiChu = ghiChu;
        }
    }
}
