using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NXB_DTO
    {
        private string _maNXB;

        public string MaNXB
        {
            get { return _maNXB; }
            set { _maNXB = value; }
        }
        private string _tenNXB;

        public string TenNXB
        {
            get { return _tenNXB; }
            set { _tenNXB = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public NXB_DTO(string maNXB, string tenNXB, string ghiChu)
        {
            MaNXB = maNXB;
            TenNXB = tenNXB;
            GhiChu = ghiChu;
        }
    }
}
