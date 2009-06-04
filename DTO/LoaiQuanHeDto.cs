using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiQuanHeDto
    {
        private string _MaLoaiQuanHe;
        private string _TenLoaiQuanHe;
        public string MaLoaiQuanHe
        {
            get { return _MaLoaiQuanHe; }
            set { _MaLoaiQuanHe = value; }
        }
        public string TenLoaiQuanHe
        {
            get { return _TenLoaiQuanHe; }
            set { _TenLoaiQuanHe = value; }
        }
    }
}
