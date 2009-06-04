using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NgheNghiepDto
    {
        private string _MaNgheNghiep;
        private string _TenNgheNghiep;
        public string MaNgheNghiep
        {
            get { return _MaNgheNghiep; }
            set { _MaNgheNghiep = value; }
        }
        public string TenNgheNghiep
        {
            get { return _TenNgheNghiep; }
            set { _TenNgheNghiep = value; }
        }
    }
}
