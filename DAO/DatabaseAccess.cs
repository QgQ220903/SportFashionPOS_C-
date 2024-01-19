using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DatabaseAccess
    {
        string strConnection = "Server=QGQ\\SQLEXPRESS;Database=CuaHangDaBanhDB;User Id=sa;pwd=123456@@";
        protected SqlConnection conn = null;
        protected SqlDataReader reader = null;
        protected SqlCommand command = null;


        public void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConnection);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
