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
    public class LoaiQuanHeBus
    {
        private LoaiQuanHeDto dto = new LoaiQuanHeDto();
        private LoaiQuanHeDao dao = new LoaiQuanHeDao();
        public LoaiQuanHeDto LoaiQuanHe
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
        public LoaiQuanHeDto GetLoaiQuanHe(string str)
        {
            LoaiQuanHeDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachLoaiQuanHe();
            while (reader.Read())
            {
                dto = new LoaiQuanHeDto();
                dto.MaLoaiQuanHe = reader["MaLoaiQuanHe"].ToString();
                dto.TenLoaiQuanHe = reader["TenLoaiQuanHe"].ToString();
                if (dto.MaLoaiQuanHe == str)
                    reader.Close();
                return dto;
            }
            reader.Close();
            return null;
        }
        public ArrayList GetDanhSachLoaiQuanHe()
        {
            ArrayList arr = new ArrayList();
            LoaiQuanHeDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachLoaiQuanHe();
            while (reader.Read())
            {
                dto = new LoaiQuanHeDto();
                dto.MaLoaiQuanHe = reader["MaLoaiQuanHe"].ToString();
                dto.TenLoaiQuanHe = reader["TenLoaiQuanHe"].ToString();
                arr.Add(dto);
            }
            reader.Close();
            return arr;
        }
    }
}
