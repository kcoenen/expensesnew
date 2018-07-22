using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace expenses
{
    public static class accountDB
    {
        public static NpgsqlConnection GetConnection()
        {
            //string connectionString =
            //"Data Source=localhost\\SqlExpress;Initial Catalog=HIA6;" +
            //"Integrated Security=True";
            string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "192.168.1.50", "5432", "accountdb",
                    "accountdb", "accountdb");
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            return conn;
        }
    }
}
