using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoai_DTO
    {
        private string _maTheLoai;

        public string MaTheLoai
        {
            get { return _maTheLoai; }
            set { _maTheLoai = value; }
        }
        private string _tenTheLoai;

        public string TenTheLoai
        {
            get { return _tenTheLoai; }
            set { _tenTheLoai = value; }
        }
        public TheLoai_DTO(string maTheLoai, string tenTheLoai)
        {
            MaTheLoai = maTheLoai;
            TenTheLoai = tenTheLoai;
        }
    }
}
