using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
namespace DAO
{
    public class NguyenNhanDao
    {
        private DataProvider _provider=new DataProvider();
        public NguyenNhanDao()
        {
            _provider.connect();
        }
        public void Insert(NguyenNhanDto dto)
        {
            string query = "INSERT INTO NGUYENNHAN VALUES('" +
            dto.MaNguyenNhan + "','" +
            dto.TenNguyenNhan + "')";
            _provider.executeQuery(query);
        }
        public void Delete(string manguyennhan)
        {
            string query = "DELETE FROM NGUYENNHAN WHERE MaNguyenNhan='" + manguyennhan + "'";
            _provider.executeQuery(query);
        }
        public IDataReader GetDanhSachNguyenNhan()
        {
            string query = "SELECT * FROM NGUYENNHAN";
            return _provider.executeQuery(query);
        }
    }
}
