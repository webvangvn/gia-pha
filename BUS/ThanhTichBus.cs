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
    public class ThanhTichBus
    {
        private ThanhTichDto dto = new ThanhTichDto();
        private ThanhTichDao dao = new ThanhTichDao();
        public ThanhTichDto ThanhTich
        {
            get { return dto; }
            set { dto = value; }
        }
        public void Insert()
        {
            dao.Insert(dto);
        }
        public void Delete(string str)
        {
            dao.Delete(str);
        }
        public ThanhTichDto GetThanhTich(string str)
        {
            ThanhTichDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachThanhTich();
            while (reader.Read())
            {
                dto = new ThanhTichDto();
                dto.MaPhieuThanhTich = reader["MaPhieuThanhTich"].ToString();
                dto.MaThanhVien = reader["MaThanhVien"].ToString();
                dto.MaLoaiThanhTich = reader["MaLoaiThanhTich"].ToString();
                dto.NgayPhatSinh = System.Convert.ToDateTime(reader["NgayPhatSinh"].ToString());
                if (dto.MaPhieuThanhTich == str)
                    reader.Close();
                return dto;
            }
            reader.Close();
            return null;
        }
        public ArrayList GetDanhSachThanhTich()
        {
            ArrayList arr = new ArrayList();
            ThanhTichDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachThanhTich();
            while (reader.Read())
            {
                dto = new ThanhTichDto();
                dto.MaPhieuThanhTich = reader["MaPhieuThanhTich"].ToString();
                dto.MaThanhVien = reader["MaThanhVien"].ToString();
                dto.MaLoaiThanhTich = reader["MaLoaiThanhTich"].ToString();
                dto.NgayPhatSinh = System.Convert.ToDateTime(reader["NgayPhatSinh"].ToString());
                arr.Add(dto);
            }
            reader.Close();
            return arr;
        }
    }
}
