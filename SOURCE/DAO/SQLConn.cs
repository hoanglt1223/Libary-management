using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class SQLConn
    {
        public static SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=QLTV;Trusted_Connection=True");
            return conn;
        }

        public static void openConnection()
        {
            SqlConnection conn = connect();
            if (conn.State != ConnectionState.Connecting)
                conn.Open();
        }

        public static void closeConnection()
        {
            SqlConnection conn = connect();
            if (conn.State == ConnectionState.Connecting)
                conn.Close();
        }
    }
}
