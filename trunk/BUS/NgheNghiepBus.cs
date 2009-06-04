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
    public class NgheNghiepBus
    {
        private NgheNghiepDto dto = new NgheNghiepDto();
        private NgheNghiepDao dao=new NgheNghiepDao();
        public NgheNghiepDto NgheNghiep
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
        public NgheNghiepDto GetNgheNghiep(string str)
        {
            NgheNghiepDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachNgheNghiep();
            while (reader.Read())
            {
                dto = new NgheNghiepDto();
                dto.MaNgheNghiep = reader["MaNgheNghiep"].ToString();
                dto.TenNgheNghiep = reader["TenNgheNghiep"].ToString();
                if (dto.MaNgheNghiep == str)
                    reader.Close();
                return dto;
            }
            reader.Close();
            return null;
        }
        public ArrayList GetDanhSachNgheNghiep()
        {
            ArrayList arr = new ArrayList();
            NgheNghiepDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachNgheNghiep();
            while (reader.Read())
            {
                dto = new NgheNghiepDto();
                dto.MaNgheNghiep = reader["MaNgheNghiep"].ToString();
                dto.TenNgheNghiep = reader["TenNgheNghiep"].ToString();
                arr.Add(dto);
            }
            reader.Close();
            return arr;
        }
    }
}
