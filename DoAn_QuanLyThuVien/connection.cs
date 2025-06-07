using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAn_QuanLyThuVien
{
    internal class connection
    {
        private static string stringconnection = @"Data Source=MSI\ADMIN_MSI;Initial Catalog=QLTV_Last;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringconnection);
        }
    }
}
