using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap_DTO
    {
        private string _tenDangNhap;

        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }
        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        private int _loaiTaiKhoan;

        public int LoaiTaiKhoan
        {
            get { return _loaiTaiKhoan; }
            set { _loaiTaiKhoan = value; }
        }
        public DangNhap_DTO(string tenDangNhap, string matKhau, int loaiTaiKhoan)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            LoaiTaiKhoan = loaiTaiKhoan;
        }

        public DangNhap_DTO()
        {
            // TODO: Complete member initialization
            TenDangNhap = "";
            MatKhau = "";
            LoaiTaiKhoan = 9;
        }
    }
}
