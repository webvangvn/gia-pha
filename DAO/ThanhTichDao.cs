using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
namespace DAO
{
    public class ThanhTichDao
    {
        private DataProvider _provider = new DataProvider();
        public ThanhTichDao()
        {
            _provider.connect();
        }
        public void Insert(ThanhTichDto dto)
        {
            string query="INSERT INTO THANHTICH VALUES('"+
                dto.MaPhieuThanhTich+"','"+
                dto.MaThanhVien+"','"+
                dto.MaLoaiThanhTich+"','"+
                dto.NgayPhatSinh+"')";
            _provider.executeQuery(query);
        }
        public void Delete(string str)
        {
            string query = "DELETE FROM THANHTICH WHERE MaPhieuThanhTich='" + str + "'";
            _provider.executeQuery(str);
        }
        public IDataReader GetDanhSachThanhTich()
        {
            string query = "SELECT * FROM THANHTICH";
            return _provider.executeQuery(query);
        }
    }
}
