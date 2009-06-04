using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
namespace DAO
{
    public class ThanhVienDao
    {
        private DataProvider _provider = new DataProvider();
        public ThanhVienDao()
        {
            _provider.connect();
        }
        public IDataReader GetDanhSachThanhVien()
        {
            string query = "SELECT * FROM THANHVIEN";
            return _provider.executeQuery(query);
        }
        public void Insert(ThanhVienDto dto)
        {
            string query = "INSERT INTO THANHVIEN(MaThanhVien,ThanhVienCu,MaLoaiQuanHe,NgayPhatSinh,HoVaTen,GioiTinh,NgayGioSinh,MaQueQuan,MaNgheNghiep,DiaChi,Doi,ChaMe) VALUES ('" +
                dto.MaThanhVien+"','"+
                dto.ThanhVienCu + "','" +
                dto.MaLoaiQuanHe + "','" +
                dto.NgayPhatSinh + "','" +
                dto.HoVaTen + "','" +
                dto.GioiTinh + "','" +
                dto.NgayGioSinh + "','" +
                dto.MaQueQuan + "','" +
                dto.MaNgheNghiep + "','" +
                dto.DiaChi + "','" +
                dto.Doi + "','" +
                dto.ChaMe + "')";
            _provider.executeQuery(query);
        }
        public void Delete(string mtv)
        {
            string query="DELETE FROM THANHVIEN WHERE MaThanhVien like '"+mtv+"'";
            _provider.executeQuery(query);
        }
        public void Update(ThanhVienDto dto)
        {
            string query="UPDATE THANHVIEN SET MaThanhVien='"+dto.MaThanhVien+
                                               "',ThanhVienCu='"+dto.ThanhVienCu+
                                               "',MaLoaiQuanHe='"+dto.MaLoaiQuanHe+
                                               "',NgayPhatSinh='"+dto.NgayPhatSinh+
                                               "',HoVaTen='"+dto.HoVaTen+
                                               "',GioiTinh='"+dto.GioiTinh+
                                               "',NgayGioSinh='"+dto.NgayGioSinh+
                                               "',MaQueQuan='"+dto.MaQueQuan+
                                               "',MaNgheNghiep='"+dto.MaNgheNghiep+
                                               "',DiaChi='"+dto.DiaChi+
                                               "',Doi='"+dto.Doi+
                                               "',ChaMe='"+dto.ChaMe+
                                               "' WHERE MaThanhVien='"+dto.MaThanhVien+"'";
            _provider.executeQuery(query);
        }
    }

}
