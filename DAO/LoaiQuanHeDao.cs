using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
namespace DAO
{
    public class LoaiQuanHeDao
    {
        private DataProvider _provider = new DataProvider();
        public LoaiQuanHeDao()
        {
            _provider.connect();
        }
        public void Insert(LoaiQuanHeDto dto)
        {
            string query = "INSERT INTO LOAIQUANHE VALUES('" +
                dto.MaLoaiQuanHe + "','" +
                dto.TenLoaiQuanHe + "')";
            _provider.executeQuery(query);
        }
        public void Delete(string maloaiquanhe)
        {
            string query = "DELETE FROM LOAIQUANHE WHERE MaLoaiQuanHe='" + maloaiquanhe + "'";
            _provider.executeQuery(query);
        }
        public IDataReader GetDanhSachLoaiQuanHe()
        {
            string query = "SELECT * FROM LOAIQUANHE";
            return _provider.executeQuery(query);
        }
    }
}
