using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiThanhTichDto
    {
        private string _MaLoaiThanhTich;
        private string _TenLoaiThanhTich;
        public string MaLoaiThanhTich
        {
            get { return _MaLoaiThanhTich; }
            set { _MaLoaiThanhTich = value; }
        }
        public string TenLoaiThanhTich
        {
            get { return _TenLoaiThanhTich; }
            set { _TenLoaiThanhTich = value; }
        }
    }
}
