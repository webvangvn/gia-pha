using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class QueQuanDto
    {
        private string _MaQueQuan;
        private string _TenQueQuan;
        public string MaQueQuan
        {
            get { return _MaQueQuan; }
            set { _MaQueQuan = value; }
        }
        public string TenQueQuan
        {
            get { return _TenQueQuan; }
            set { _TenQueQuan = value; }
        }
    }
}
