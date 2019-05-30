using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia_DTO
    {
        private string _maDocGia;

        public string MaDocGia
        {
            get { return _maDocGia; }
            set { _maDocGia = value; }
        }

        private string _tenDocGia;

        public string TenDocGia
        {
            get { return _tenDocGia; }
            set { _tenDocGia = value; }
        }

        private string _gioiTinh;

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private string _soCMT;

        public string SoCMT
        {
            get { return _soCMT; }
            set { _soCMT = value; }
        }
        private string _maLoaiDocGia;

        public string MaLoaiDocGia
        {
            get { return _maLoaiDocGia; }
            set { _maLoaiDocGia = value; }
        }
        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        public DocGia_DTO(string maDocGia, string tenDocGia, string gioiTinh, DateTime ngaySinh, string diaChi, string soCMT, string maLoaiDocGia, string matKhau)
        {
            MaDocGia = maDocGia;
            TenDocGia = tenDocGia;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SoCMT = soCMT;
            MaLoaiDocGia = maLoaiDocGia;
            MatKhau = matKhau;
        }

        public DocGia_DTO()
        {
            MaDocGia = "";
            TenDocGia = "";
            GioiTinh = "";
            NgaySinh = DateTime.Today;
            DiaChi = "";
            SoCMT = "";
            MaLoaiDocGia = "";
            MatKhau = "";
        }
    }

}
