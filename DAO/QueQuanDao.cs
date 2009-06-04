using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
namespace DAO
{
    public class QueQuanDao
    {
        private DataProvider _provider = new DataProvider();
        public QueQuanDao()
        {
            _provider.connect();
        }
        public IDataReader GetDanhSachQueQuan()
        {
            string query = "SELECT * FROM QUEQUAN";
            return _provider.executeQuery(query);
        }
        public void Insert(QueQuanDto dto)
        {
            string query = "INSERT INTO QUEQUAN VALUES('" +
                          dto.MaQueQuan + "','" +
                          dto.TenQueQuan + "')";
            _provider.executeQuery(query);
        }
        public void Delete(string mqq)
        {
            string query = "DELETE FROM QUEQUAN WHERE MaQueQuan='" + mqq + "'";
            _provider.executeQuery(mqq);
        }
        public void Update()
        {
        }
        public void LoadDanhSachQueQuan(ref System.Windows.Forms.ListView list)
        {
            _provider.LoadLstview(ref list, "QueQuan");
        }
    }
}
