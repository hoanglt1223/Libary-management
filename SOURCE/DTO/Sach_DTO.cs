using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach_DTO
    {
        private string _maSach;

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        private string _tenSach;

        public string TenSach
        {
            get { return _tenSach; }
            set { _tenSach = value; }
        }
        private string _maTacGia;

        public string MaTacGia
        {
            get { return _maTacGia; }
            set { _maTacGia = value; }
        }
        private string _maTheLoai;

        public string MaTheLoai
        {
            get { return _maTheLoai; }
            set { _maTheLoai = value; }
        }
        private string _maNXB;

        public string MaNXB
        {
            get { return _maNXB; }
            set { _maNXB = value; }
        }
        private int _namXuatBan;

        public int NamXuatBan
        {
            get { return _namXuatBan; }
            set { _namXuatBan = value; }
        }
        private int _soTrang;

        public int SoTrang
        {
            get { return _soTrang; }
            set { _soTrang = value; }
        }
        private int _gia;

        public int Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }
        private int _soBan;

        public int SoBan
        {
            get { return _soBan; }
            set { _soBan = value; }
        }
        private int _soBanTon;

        public int SoBanTon
        {
            get { return _soBanTon; }
            set { _soBanTon = value; }
        }

        public Sach_DTO(string maSach, string tenSach, string maTacGia, string maTheLoai, string maNXB, int namXuatBan, int soTrang, int gia, int soBan, int soBanTon)
        {
            MaSach = maSach;
            TenSach = tenSach;
            MaTacGia = maTacGia;
            MaTheLoai = maTheLoai;
            MaNXB = maNXB;
            NamXuatBan = namXuatBan;
            SoTrang = soTrang;
            Gia = gia;
            SoBan = soBan;
            SoBanTon = soBanTon;
        }
    }
}
