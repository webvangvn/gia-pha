using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThanhVienDto
    {
        private string _MaThanhVien;
        private string _ThanhVienCu;
        private string _MaLoaiQuanHe;
        private DateTime _NgayPhatSinh;
        private string _HoVaTen;
        private string _GioiTinh;
        private DateTime _NgayGioSinh;
        private string _MaQueQuan;
        private string _MaNgheNghiep;
        private string _DiaChi;
        private string _Doi;
        private string _ChaMe;
        public string MaThanhVien
        {
            get { return _MaThanhVien; }
            set { _MaThanhVien = value; }
        }
        public string ThanhVienCu
        {
            get { return _ThanhVienCu; }
            set { _ThanhVienCu = value; }
        }
        public string MaLoaiQuanHe
        {
            get { return _MaLoaiQuanHe; }
            set { _MaLoaiQuanHe = value; }
        }
        public DateTime NgayPhatSinh
        {
            get { return _NgayPhatSinh; }
            set { _NgayPhatSinh = value; }
        }
        public string HoVaTen
        {
            get { return _HoVaTen; }
            set { _HoVaTen = value; }
        }
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        public DateTime NgayGioSinh
        {
            get { return _NgayGioSinh; }
            set { _NgayGioSinh = value; }
        }
        public string MaQueQuan
        {
            get { return _MaQueQuan; }
            set { _MaQueQuan = value; }
        }
        public string MaNgheNghiep
        {
            get { return _MaNgheNghiep; }
            set { _MaNgheNghiep = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string Doi
        {
            get { return _Doi; }
            set { _Doi = value; }
        }
        public string ChaMe
        {
            get { return _ChaMe; }
            set { _ChaMe = value; }
        }
    }
}
