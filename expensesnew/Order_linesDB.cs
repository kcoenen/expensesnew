using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenses
{
    public abstract class order_linesDB
    {
        public static List<Order_lines> GetorderlinesList(Int32 order_id)
        {
            List<Order_lines> lineslist = new List<Order_lines>();
            NpgsqlConnection connection = accountDB.GetConnection();
            string selectStatement =
                "select *" +
                "from order_lines " +
                "WHERE order_id = @order_id;";
            NpgsqlCommand selectCommand = new NpgsqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@order_id", order_id);
            try
            {
                connection.Open();
                NpgsqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Order_lines ol = new Order_lines();
                    ol.mcost_id = (int)reader["cost_id"];
                    Cost c = new Cost();
                    c = costDB.getcost(ol.mcost_id);
                    ol.mcostname = c.returnname;
                    ol.mprice = Convert.ToDouble(reader["price"]);
                    ol.mdate = Convert.ToDateTime(reader["date"]);
                    lineslist.Add(ol);
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
            return lineslist;
        }

        public static int Addorderline(Order_lines ol)
        {
            NpgsqlConnection connection = accountDB.GetConnection();
            string insertStatement =
                "INSERT into order_lines " +
                  "(order_id,cost_id,price,date) " +
                "VALUES (" + ol.morder_id + ", " + ol.mcost_id + "," + ol.mprice.ToString(System.Globalization.CultureInfo.InvariantCulture) + ",'" + ol.mdate + "') returning order_id";

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