using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace expenses
{
    public abstract class costDB
    {
        public static Cost getcost(int cost_id)
        {
            Cost c = new Cost();
            NpgsqlConnection connection = accountDB.GetConnection();
            string selectStatement =
                "SELECT *" +
                "FROM cost " +
                "WHERE cost_id = @cost_id";
            NpgsqlCommand selectCommand = new NpgsqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@cost_id", cost_id);
            try
            {
                connection.Open();
                NpgsqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    c.mcost_id = (int)reader["cost_id"];
                    c.mname = reader["name"].ToString();
                }
                else
                {
                    c = null;
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
            return c;
        }

        public static int Addcost(Cost c)
        {
            NpgsqlConnection connection = accountDB.GetConnection();
            string insertStatement =
                "INSERT into cost " +
                  "(name) " +
                "VALUES ('" + c.mname + "') returning cost_id";

            NpgsqlCommand insertCommand = new NpgsqlCommand(insertStatement, connection);

            try
            {
                connection.Open();
                int leerlingID = Convert.ToInt32(insertCommand.ExecuteScalar());
                //string selectStatement =
                //    "SELECT IDENT_CURRENT('cost') FROM cost";
                //NpgsqlCommand selectCommand = new NpgsqlCommand(selectStatement, connection);
                //int leerlingID = Convert.ToInt32(selectCommand.ExecuteScalar());
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

        public static int countCost()
        {
            NpgsqlConnection connection = accountDB.GetConnection();
            string countStatement = "select count(cost_id) as count from cost";
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

        public static void updatecost(Cost c)
        {
            NpgsqlConnection connection = accountDB.GetConnection();
            string updateStatement =
                "UPDATE cost SET " +
                  "name = '" + c.mname + "' WHERE cost_id =" + c.mcost_id + ";";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateStatement, connection);
            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();
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

        public static List<Cost> GetcostList()
        {
            List<Cost> costlijst = new List<Cost>();
            NpgsqlConnection connection = accountDB.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM cost ";
            NpgsqlCommand selectCommand = new NpgsqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                NpgsqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Cost c = new Cost();
                    c.mcost_id = (int)reader["cost_id"];
                    c.mname = reader["name"].ToString();
                    costlijst.Add(c);
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
            return costlijst;
        }
    }
}
