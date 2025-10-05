using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Novelity
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["NovelityDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Database query error: " + ex.Message, ex);
                }
            }

            return dataTable;
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Database non-query error: " + ex.Message, ex);
                }
            }

            return rowsAffected;
        }

        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;

            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        result = command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Database scalar error: " + ex.Message, ex);
                }
            }

            return result;
        }
    }
}