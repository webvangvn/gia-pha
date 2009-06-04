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
    public class DiaDiemMaiTangBus
    {
        private DiaDiemMaiTangDto dto = new DiaDiemMaiTangDto();
        private DiaDiemMaiTangDao dao = new DiaDiemMaiTangDao();
        public DiaDiemMaiTangDto DiaDiemMaiTang
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
        public DiaDiemMaiTangDto GetDiaDiemMaiTang(string str)
        {
            DiaDiemMaiTangDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachDiaDiemMaiTang();
            while (reader.Read())
            {
                dto = new DiaDiemMaiTangDto();
                dto.MaDiaDiemMaiTang = reader["MaDiaDiemMaiTang"].ToString();
                dto.TenDiaDiemMaiTang = reader["TenDiaDiemMaiTang"].ToString();
                if (dto.MaDiaDiemMaiTang == str)
                    reader.Close();
                return dto;
            }
            reader.Close();
            return null;
        }
        public ArrayList GetDanhSachDiaDiemMaiTang()
        {
            ArrayList arr = new ArrayList();
            DiaDiemMaiTangDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachDiaDiemMaiTang();
            while (reader.Read())
            {
                dto = new DiaDiemMaiTangDto();
                dto.MaDiaDiemMaiTang = reader["MaDiaDiemMaiTang"].ToString();
                dto.TenDiaDiemMaiTang = reader["TenDiaDiemMaiTang"].ToString();
                arr.Add(dto);
            }
            reader.Close();
            return arr;
        }
    }
}
