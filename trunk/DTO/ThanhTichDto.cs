using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThanhTichDto
    {
        private string _MaPhieuThanhTich;
        private string _MaThanhVien;
        private string _MaLoaiThanhTich;
        private DateTime _NgayPhatSinh;
        public string MaPhieuThanhTich
        {
            get { return _MaLoaiThanhTich; }
            set { _MaLoaiThanhTich = value; }
        }
        public string MaThanhVien
        {
            get { return _MaThanhVien; }
            set { _MaThanhVien = value; }
        }
        public string MaLoaiThanhTich
        {
            get { return _MaLoaiThanhTich; }
            set { _MaLoaiThanhTich = value; }
        }
        public DateTime NgayPhatSinh
        {
            get { return _NgayPhatSinh; }
            set { _NgayPhatSinh = value; }
        }
    }
}
