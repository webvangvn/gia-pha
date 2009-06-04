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
    public class LoaiThanhTichBus
    {
        private LoaiThanhTichDto dto = new LoaiThanhTichDto();
        private LoaiThanhTichDao dao = new LoaiThanhTichDao();
        public LoaiThanhTichDto LoaiThanhTich
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
        public LoaiThanhTichDto GetLoaiThanhTich(string str)
        {
            LoaiThanhTichDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachLoaiThanhTich();
            while (reader.Read())
            {
                dto = new LoaiThanhTichDto();
                dto.MaLoaiThanhTich = reader["MaLoaiThanhTich"].ToString();
                dto.TenLoaiThanhTich = reader["TenLoaiThanhTich"].ToString();
                if (dto.MaLoaiThanhTich == str)
                    reader.Close();
                return dto;
            }
            reader.Close();
            return null;
        }
        public ArrayList GetDanhSachLoaiThanhTich()
        {
            ArrayList arr = new ArrayList();
            LoaiThanhTichDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachLoaiThanhTich();
            while (reader.Read())
            {
                dto = new LoaiThanhTichDto();
                dto.MaLoaiThanhTich = reader["MaLoaiThanhTich"].ToString();
                dto.TenLoaiThanhTich = reader["TenLoaiThanhTich"].ToString();
                arr.Add(dto);
            }
            reader.Close();
            return arr;
        }
    }
}
