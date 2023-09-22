using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace LibrarySQL
{
    public class SQL_Connection
    {
        public static SqlConnection cnn;
        private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public SQL_Connection(string ConnectionString)
        {
            builder.ConnectionString= ConnectionString;
        }
        public SQL_Connection(string serverName, string databaseName, string userId, string password)
        {
            builder.DataSource = serverName;
            builder.InitialCatalog = databaseName;
            builder.UserID = userId;
            builder.Password = password;
        }
        public SQL_Connection(string serverName, string databaseName)
        {
            builder.DataSource = serverName;
            builder.InitialCatalog = databaseName;
        }

        public void CreateConnection()
        {
            cnn = new SqlConnection(builder.ConnectionString);
        }
        public bool TestConnection()
        {
            try
            {
                cnn.Open();
                cnn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable ExcuteQuery(string pQuery, object[] parameter = null)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = cnn)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(pQuery, connection);

                if (parameter != null)
                {
                    string[] listPara = pQuery.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            return table;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int row = 0;
            using (SqlConnection connection = cnn)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                row = command.ExecuteNonQuery();
                connection.Close();
            }
            return row;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = cnn)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " + pPass + "");
            da.Fill(dt);
            return dt;
        }
        
    }
}
