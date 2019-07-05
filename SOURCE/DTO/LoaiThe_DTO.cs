using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiThe_DTO
    {
        private string _maLoaiThe;

        public string MaLoaiThe
        {
            get { return _maLoaiThe; }
            set { _maLoaiThe = value; }
        }
        private string _tenLoaiThe;

        public string TenLoaiThe
        {
            get { return _tenLoaiThe; }
            set { _tenLoaiThe = value; }
        }

        public LoaiThe_DTO(string maLoaiThe, string tenLoaiThe)
        {
            MaLoaiThe = maLoaiThe;
            TenLoaiThe = tenLoaiThe;
        }
    }
}
