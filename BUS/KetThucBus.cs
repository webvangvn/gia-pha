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
    public class KetThucBus
    {
        private KetThucDto dto = new KetThucDto();
        private KetThucDao dao = new KetThucDao();
        public KetThucDto KetThuc
        {
            get { return dto; }
            set { dto = value; }
        }
        public void Insert()
        {
            dao.Insert(dto);
        }
        public void Delete(string str)
        {
            dao.Delete(str);
        }
    }
}
