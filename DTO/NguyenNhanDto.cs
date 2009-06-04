using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NguyenNhanDto
    {
        private string _MaNguyenNhan;
        private string _TenNguyenNhan;
        public string MaNguyenNhan
        {
            get { return _MaNguyenNhan; }
            set { _MaNguyenNhan = value; }
        }
        public string TenNguyenNhan
        {
            get { return _TenNguyenNhan; }
            set { _TenNguyenNhan = value; }
        }
    }
}
