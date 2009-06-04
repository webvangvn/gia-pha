using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
namespace DAO
{
    public class NgheNghiepDao
    {
        private DataProvider _provider=new DataProvider();
        public NgheNghiepDao()
        {
            _provider.connect();
        }
        public void Insert(NgheNghiepDto dto)
        {
            string query = "INSERT INTO NGHENGHIEP VALUES('" +
                dto.MaNgheNghiep + "','" +
                dto.TenNgheNghiep + "')";
            _provider.executeQuery(query);
        }
        public void Delete(string manghenghiep)
        {
            string query = "DELETE FROM NGHENGHIEP WHERE MaNgheNghiep='" + manghenghiep + "'";
            _provider.executeQuery(query);
        }
        public IDataReader GetDanhSachNgheNghiep()
        {
            string query = "SELECT * FROM NGHENGHIEP";
            return _provider.executeQuery(query);
        }
    }
}
