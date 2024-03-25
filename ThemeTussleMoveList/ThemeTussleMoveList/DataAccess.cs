using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ThemeMoveListDemo
{
    internal static class DataAccess
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MoveList"].ConnectionString;

        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLCleaner(sql), conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static List<string> GetStringData(string sql)
        {
            List<string> list = new List<string>();

           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQLCleaner(sql), conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            string str = reader.GetString(0);
                            string str2 = reader.GetString(1);
                            list.Add(str);
                            list.Add(str2);
                        }
                        
                    }
                }
                conn.Close();
            }
            return list;
        }

        public static DataSet GetData(string[] sqlStatements)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                for (int i = 0; i < sqlStatements.Length; i++)
                {
                    sqlStatements[i] = SQLCleaner(sqlStatements[i]);
                }

                string sql = string.Join(";", sqlStatements);

                using (SqlCommand cmd = new SqlCommand(SQLCleaner(sql), conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        for (int i = 0; i < sqlStatements.Length; i++)
                        {
                            da.TableMappings.Add(i.ToString(), $"Data{i}");
                        }

                        da.Fill(ds);
                    }
                }
            }

            return ds;
        }

        public static object GetValue(string sql)
        {
            object returnValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLCleaner(sql), conn))
                {

                    conn.Open();
                    returnValue = cmd.ExecuteScalar();
                    conn.Close();
                }
            }

            return returnValue;
        }

        public static int ExecuteNonQuery(string sql)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLCleaner(sql), conn))
                {
                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            return rowsAffected;
        }

        private static string SQLCleaner(string sqlStatement)
        {
            return sqlStatement.Replace(Environment.NewLine, "");
        }
    }
}
