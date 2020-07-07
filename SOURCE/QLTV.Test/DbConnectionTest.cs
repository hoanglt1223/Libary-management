using Xunit;
using System.Data.SqlClient;

namespace QLTV.Test
{
    public class DbConnectionTest
    {
        [Fact]
        public void ConnectionTest()
        {
            SqlConnection conn = DAO.SQLConn.connect();
            conn.Open();
            Assert.Equal(System.Data.ConnectionState.Open, conn.State);
            conn.Close();
        }
    }
}
