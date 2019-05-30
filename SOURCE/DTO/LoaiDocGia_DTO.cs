using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDocGia_DTO
    {
        private string _maLoaiDocGia;

        public string MaLoaiDocGia
        {
            get { return _maLoaiDocGia; }
            set { _maLoaiDocGia = value; }
        }
        private string _tenLoaiDocGia;

        public string TenLoaiDocGia
        {
            get { return _tenLoaiDocGia; }
            set { _tenLoaiDocGia = value; }
        }

        public LoaiDocGia_DTO(string maLoaiDocGia, string tenLoaiDocGia)
        {
            MaLoaiDocGia = maLoaiDocGia;
            TenLoaiDocGia = tenLoaiDocGia;
        }
    }
}
