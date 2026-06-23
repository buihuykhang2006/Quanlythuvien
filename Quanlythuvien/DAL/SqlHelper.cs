using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAL
{
    public class SqlHelper
    {
        private static string connectionString = @"Data Source=LAPTOP-QKIJUSG3\MSSQLSERVER02;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        public static bool ExecuteNonQuery(string query, SqlParameter[]? parameters = null)
        {
            SqlConnection? connection = null;
            SqlCommand? command = null;

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                int rows = command.ExecuteNonQuery();
                return rows > 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                command?.Dispose();
                if (connection != null)
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }

                    connection.Dispose();
                }
            }
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[]? parameters = null)
        {
            DataTable data = new DataTable();
            SqlConnection? connection = null;
            SqlCommand? command = null;
            SqlDataAdapter? adapter = null;

            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
            catch
            {
                throw;
            }
            finally
            {
                adapter?.Dispose();
                command?.Dispose();
                if (connection != null)
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }

                    connection.Dispose();
                }
            }
        }
    }
}
