using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGia_DTO
    {
        private string _maTacGia;

        public string MaTacGia
        {
            get { return _maTacGia; }
            set { _maTacGia = value; }
        }
        private string _tenTacGia;

        public string TenTacGia
        {
            get { return _tenTacGia; }
            set { _tenTacGia = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public TacGia_DTO(string maTacGia, string tenTacGia, string ghiChu)
        {
            MaTacGia = maTacGia;
            TenTacGia = tenTacGia;
            GhiChu = ghiChu;
        }
    }
}
