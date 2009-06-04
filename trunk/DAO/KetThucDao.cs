using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
namespace DAO
{
    public class KetThucDao
    {
        private DataProvider _provider = new DataProvider();
        public KetThucDao()
        {
            _provider.connect();
        }
        public void Insert(KetThucDto dto)
        {
            string query = "INSERT INTO KETTHUC VALUES('" +
                dto.MaPhieuKetThuc + "','" +
                dto.MaThanhVien + "','" +
                dto.NgayGioMat + "','" +
                dto.MaNguyenNhan + "','" +
                dto.MaDiaDiemMaiTang + "')";
            _provider.executeQuery(query);
        }
        public void Delete(string maphieuketthuc)
        {
            string query = "DELETE FROM KETTHUC WHERE MaPhieuKetThuc='" + maphieuketthuc + "'";
            _provider.executeQuery(query);
        }
    }
}
