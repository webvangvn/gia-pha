using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KetThucDto
    {
        private string _MaPhieuKetThuc;
        private string _MaThanhVien;
        private DateTime _NgayGioMat;
        private string _MaNguyenNhan;
        private string _MaDiaDiemMaiTang;
        public string MaPhieuKetThuc
        {
            get { return _MaPhieuKetThuc;}
            set{_MaPhieuKetThuc=value;}
        }
        public string MaThanhVien
        {
            get { return _MaThanhVien; }
            set { _MaThanhVien = value; }
        }
        public DateTime NgayGioMat
        {
            get { return _NgayGioMat; }
            set { _NgayGioMat = value; }
        }
        public string MaNguyenNhan
        {
            get { return _MaNguyenNhan; }
            set { _MaNguyenNhan = value; }
        }
        public string MaDiaDiemMaiTang
        {
            get { return _MaDiaDiemMaiTang; }
            set { _MaDiaDiemMaiTang = value; }
        }
    }
}
