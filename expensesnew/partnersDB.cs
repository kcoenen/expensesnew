using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.SqlClient;

namespace expenses
{
    public abstract class partnersDB
    {
        public static Partners getpartner(int partner_id)
        {
            Partners p = new Partners();
            NpgsqlConnection connection = accountDB.GetConnection();
            string selectStatement =
                "SELECT *" +
                "FROM partners " +
                "WHERE partner_id = @partner_id";
            NpgsqlCommand selectCommand = new NpgsqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@partner_id", partner_id);
            try
            {
                connection.Open();
                NpgsqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    p.mpartner_id = (int)reader["partner_id"];
                    p.mcity_id = (int)reader["city_id"];
                    p.mname = reader["name"].ToString();
                    p.mstreet = reader["street"].ToString();
                    p.memail = reader["email"].ToString();
                    p.mcallname = reader["callname"].ToString();
                }
                else
                {
                    p = null;
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
            return p;
        }
        public static int countpartner()
        {
            NpgsqlConnection connection = accountDB.GetConnection();
            string countStatement = "select count(partner_id) as count from partners";
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
        public static void updatepartner(Partners p)
        {
            NpgsqlConnection connection = accountDB.GetConnection();
            string updateStatement =
                "UPDATE partners SET " +
                  "name = '" + p.mname + "', " +
                  "street = '" + p.mstreet + "', " +
                  "city_id = '" + p.mcity_id + "', " +
                  "email = '" + p.memail + "', " +
                  "callname = '" + p.mcallname + "'" +
                  " WHERE partner_id = " + p.mpartner_id + ";";
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
        public static int Addpartner(Partners p)
        {
            NpgsqlConnection connection = accountDB.GetConnection();
            string insertStatement =
                "INSERT into partners " +
                  "(name,street,city_id,email,callname) " +
                "VALUES ('" + p.mname + "'," + "'" + p.mstreet + "'," + "'" + p.mcity_id + "',"+ "'" + p.memail + "',"+ "'" + p.mcallname + "') returning partner_id";

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
        public static List<Partners> GetpartnerList()
        {
            List<Partners> partnerlist = new List<Partners>();
            NpgsqlConnection connection = accountDB.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM partners ";
            NpgsqlCommand selectCommand = new NpgsqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                NpgsqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Partners p = new Partners();
                    p.mpartner_id = (int)reader["partner_id"];
                    p.mname = reader["name"].ToString();
                    p.mstreet = reader["street"].ToString();
                    p.mcity_id = (int)reader["city_id"];
                    p.memail = reader["email"].ToString();
                    p.mcallname = reader["callname"].ToString();
                    partnerlist.Add(p);
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
            return partnerlist;
        }

    }
}
