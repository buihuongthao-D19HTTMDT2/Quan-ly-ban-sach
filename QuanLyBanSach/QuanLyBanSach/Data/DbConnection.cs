using System.Data.SqlClient;

namespace QuanLyBanSach
{
    public class DbConnection
    {
        private static string connectionString =
            @"Data Source=DESKTOP-B0T5K45;Initial Catalog=QuanLyBanSachDB;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}