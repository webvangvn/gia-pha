using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
namespace DAO
{
    public class DiaDiemMaiTangDao
    {
        private DataProvider _provider = new DataProvider();
        public DiaDiemMaiTangDao()
        {
            _provider.connect();
        }
        public void Insert(DiaDiemMaiTangDto dto)
        {
            string query = "INSERT INTO DIADIEMMAITANG VALUES('" +
                dto.MaDiaDiemMaiTang + "','" +
                dto.TenDiaDiemMaiTang + "')";
            _provider.executeQuery(query);
        }
        public void Delete(string madiadiemmaitang)
        {
            string query = "DELETE FROM DIADIEMMAITANG WHERE MaDiaDiemMaiTang='" + madiadiemmaitang + "'";
            _provider.executeQuery(query);
        }
        public IDataReader GetDanhSachDiaDiemMaiTang()
        {
            string query = "SELECT * FROM DIADIEMMAITANG";
            return _provider.executeQuery(query);
        }
    }
}
