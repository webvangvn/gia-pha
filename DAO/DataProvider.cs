using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Timers;
namespace DAO
{
    public class DataProvider
    {
        protected static string _connectionString;
        protected OleDbConnection connection;
        protected OleDbDataAdapter adapter;
        protected OleDbCommand command;
        public static string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public void connect()
        {
            string DBFullPathName = Application.StartupPath + "\\giapha.mdb";
            //DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;
            _connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;
            //connection = new OleDbConnection(ConnectionString);
            connection = new OleDbConnection(_connectionString);
            connection.Open();
        }
        public void disconnect()
        {
            connection.Close();
        }

        public IDataReader executeQuery(string sqlString)
        {
            command = new OleDbCommand(sqlString, connection);
            return command.ExecuteReader();
        }

        public void executeNonQuery(string sqlString)
        {
            command = new OleDbCommand(sqlString, connection);
            command.ExecuteNonQuery();
        }

        public object executeScalar(string sqlString)
        {
            command = new OleDbCommand(sqlString, connection);
            return command.ExecuteScalar();
        }

        public void LoadLstview(ref System.Windows.Forms.ListView lst, string Table)
        {
            string sql = "select * from " + Table;
            OleDbDataReader dr = (OleDbDataReader)executeQuery(sql);

            int count = 1;
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToString(count);
                int i;
                for (i = 0; i < dr.FieldCount; i++)
                {
                    if (Convert.GetTypeCode(dr.GetValue(i)).ToString() == "DateTime")
                    {
                        DateTime st;
                        st = Convert.ToDateTime(dr.GetValue(i));
                        string date = st.ToShortDateString();
                        item.SubItems.Add(Convert.ToString(date));
                    }
                    else
                        item.SubItems.Add(Convert.ToString(dr.GetValue(i)));
                }
                count++;
                lst.Items.Add(item);
            }
            dr.Close();
        }
    }
}
