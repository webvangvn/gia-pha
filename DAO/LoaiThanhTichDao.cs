using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
namespace DAO
{
    public class LoaiThanhTichDao
    {
        private DataProvider _provider = new DataProvider();
        public LoaiThanhTichDao()
        {
            _provider.connect();
        }
        public void Insert(LoaiThanhTichDto dto)
        {
            string query="INSERT INTO LOAITHANHTICH VALUES('"+
                dto.MaLoaiThanhTich+"','"+
                dto.TenLoaiThanhTich+"')";
            _provider.executeQuery(query);
        }
        public void Delete(string maloaithanhtich)
        {
            string query = "DELETE FROM LOAITHANHTICH WHERE MaLoaiThanhTich='" + maloaithanhtich + "'";
            _provider.executeQuery(query);
        }
        public IDataReader GetDanhSachLoaiThanhTich()
        {
            string query = "SELECT * FROM LOAITHANHTICH";
            return _provider.executeQuery(query);
        }
    }
}
