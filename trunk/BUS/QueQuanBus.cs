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
    public class QueQuanBus
    {
        private QueQuanDto dto = new QueQuanDto();
        private QueQuanDao dao=new QueQuanDao();
        public QueQuanDto QueQuan
        {
            get { return dto; }
            set { dto = value; }
        }
        public void Insert()
        {
            dao.Insert(dto);
        }
        public void Delete(string mqq)
        {
            dao.Delete(mqq);
        }
        public QueQuanDto GetQueQuan(string mqq)
        {
            QueQuanDto qq;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachQueQuan();
            while (reader.Read())
            {
                qq = new QueQuanDto();
                qq.MaQueQuan = reader["MaQueQuan"].ToString();
                qq.TenQueQuan = reader["TenQueQuan"].ToString();
                if (qq.MaQueQuan == mqq)
                    reader.Close();
                return qq;
            }
            reader.Close();
            return null;
        }
        public ArrayList GetDanhSachQueQuan()
        {
            ArrayList arr = new ArrayList();
            QueQuanDto dto;
            OleDbDataReader reader = (OleDbDataReader)dao.GetDanhSachQueQuan();
            while (reader.Read())
            {
                dto = new QueQuanDto();
                dto.MaQueQuan = reader["MaQueQuan"].ToString();
                dto.TenQueQuan = reader["TenQueQuan"].ToString();
                arr.Add(dto);
            }
            reader.Close();
            return arr;
        }
    }
}
