using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
using DAO;
namespace BUS
{
    public class ThanhVienBus
    {
        private ThanhVienDto dto = new ThanhVienDto();
        private ThanhVienDao dao = new ThanhVienDao();
        public ThanhVienDto ThanhVien
        {
            get { return dto; }
            set { dto = value; }
        }
        public void Insert()
        {
            dao.Insert(dto);
        }
        public void Delete()
        {
            dao.Delete(dto.MaThanhVien);
        }
        public void Update()
        {
            dao.Update(dto);
        }
        public ThanhVienDto GetThanhVien(string mtv)
        {
            ArrayList arr = new ArrayList();
            ThanhVienDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachThanhVien();
            while (reader.Read())
            {
                dto = new ThanhVienDto();
                dto.MaThanhVien = reader["MaThanhVien"].ToString();
                dto.ThanhVienCu = reader["ThanhVienCu"].ToString();
                dto.MaLoaiQuanHe = reader["MaLoaiQuanHe"].ToString();
                dto.NgayPhatSinh = System.Convert.ToDateTime(reader["NgayPhatSinh"].ToString());
                dto.HoVaTen = reader["HoVaTen"].ToString();
                dto.GioiTinh = reader["GioiTinh"].ToString();
                dto.NgayGioSinh = System.Convert.ToDateTime(reader["NgayGioSinh"].ToString());
                dto.MaQueQuan = reader["MaQueQuan"].ToString();
                dto.MaNgheNghiep = reader["MaNgheNghiep"].ToString();
                dto.DiaChi = reader["DiaChi"].ToString();
                dto.Doi = reader["Doi"].ToString();
                dto.ChaMe = reader["ChaMe"].ToString();
                if (dto.MaThanhVien == mtv)
                    reader.Close();
                return dto;
            }
            reader.Close();
            return null;
        }
        public ArrayList GetDanhSachThanhVien()
        {
            ArrayList arr = new ArrayList();
            ThanhVienDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachThanhVien();
            while (reader.Read())
            {
                dto = new ThanhVienDto();
                dto.MaThanhVien = reader["MaThanhVien"].ToString();
                dto.ThanhVienCu = reader["ThanhVienCu"].ToString();
                dto.MaLoaiQuanHe = reader["MaLoaiQuanHe"].ToString();
                dto.NgayPhatSinh = System.Convert.ToDateTime(reader["NgayPhatSinh"].ToString());
                dto.HoVaTen = reader["HoVaTen"].ToString();
                dto.GioiTinh = reader["GioiTinh"].ToString();
                dto.NgayGioSinh = System.Convert.ToDateTime(reader["NgayGioSinh"].ToString());
                dto.MaQueQuan = reader["MaQueQuan"].ToString();
                dto.MaNgheNghiep = reader["MaNgheNghiep"].ToString();
                dto.DiaChi = reader["DiaChi"].ToString();
                dto.Doi = reader["Doi"].ToString();
                dto.ChaMe=reader["ChaMe"].ToString();
                arr.Add(dto);
            }
            reader.Close();
            return arr;
        }
    }
}
