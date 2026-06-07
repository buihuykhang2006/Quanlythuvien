using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAL
{
    public class SqlHelper
    {
        private static string connectionString = @"Data Source=LAPTOP-QKIJUSG3\MSSQLSERVER02;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        public static bool ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Nếu có tham số thì thêm vào
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                int rows = command.ExecuteNonQuery();
                return rows > 0; // Trả về true nếu thành công
            }
        }

        // Hàm ExecuteQuery (Dùng cho SELECT)
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            return data;
        }
    }
}
