using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenses
{
    public abstract class orderDB
    {
        public static Order getorder(int order_id)
        {
            Order o = new Order();
            NpgsqlConnection connection = accountDB.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM \"order\" " +
                "WHERE order_id = @order_id";
            NpgsqlCommand selectCommand = new NpgsqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@order_id", order_id);
            try
            {
                connection.Open();
                NpgsqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    o.morder_id = (int)reader["order_id"];
                    o.mname = reader["name"].ToString();
                    o.mdate = Convert.ToDateTime(reader["date"]);
                    o.mpartner_id = (int)reader["partner_id"];
                }
                else
                {
                    o = null;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return o;
        }
        public static int countorder()
        {
            NpgsqlConnection connection = accountDB.GetConnection();
            string countStatement = "select count(order_id) as count from \"order\"";
            int i = 0;
            NpgsqlCommand insertCommand = new NpgsqlCommand(countStatement, connection);
            connection.Open();
            NpgsqlDataReader reader = insertCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    i = Convert.ToInt32(reader["count"]);
                }
            }

            connection.Close();
            return i;
        }
        public static int Addorder(Order o)
        {
            NpgsqlConnection connection = accountDB.GetConnection();
            string insertStatement =
                "INSERT into \"order\" " +
                  "(partner_id,date,name) " +
                "VALUES (" + o.mpartner_id + ", '" + o.mdate + "'," + "'" + o.mname + "') returning order_id";

            NpgsqlCommand insertCommand = new NpgsqlCommand(insertStatement, connection);

            try
            {
                connection.Open();
                int leerlingID = Convert.ToInt32(insertCommand.ExecuteScalar());
                return leerlingID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
