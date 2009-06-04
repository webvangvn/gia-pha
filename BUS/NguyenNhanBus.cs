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
    public class NguyenNhanBus
    {
        private NguyenNhanDto dto = new NguyenNhanDto();
        private NguyenNhanDao dao = new NguyenNhanDao();
        public NguyenNhanDto NguyenNhan
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
        public NguyenNhanDto GetNguyenNhan(string str)
        {
            NguyenNhanDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachNguyenNhan();
            while (reader.Read())
            {
                dto = new NguyenNhanDto();
                dto.MaNguyenNhan = reader["MaNguyenNhan"].ToString();
                dto.TenNguyenNhan = reader["TenNguyenNhan"].ToString();
                if (dto.MaNguyenNhan == str)
                    reader.Close();
                return dto;
            }
            reader.Close();
            return null;
        }
        public ArrayList GetDanhSachNguyenNhan()
        {
            ArrayList arr = new ArrayList();
            NguyenNhanDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachNguyenNhan();
            while (reader.Read())
            {
                dto = new NguyenNhanDto();
                dto.MaNguyenNhan = reader["MaNguyenNhan"].ToString();
                dto.TenNguyenNhan = reader["TenNguyenNhan"].ToString();
                arr.Add(dto);
            }
            reader.Close();
            return arr;
        }
    }
}
