using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private readonly string Connectionstring=Properties.Settings.Default.ConnectionString;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }
        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(Connectionstring))
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

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            return table;
        }
        public bool TestConnection()
        {
            using (SqlConnection connection = new SqlConnection(Connectionstring))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }    
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int row = 0;
            using (SqlConnection connection = new SqlConnection(Connectionstring))
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
            using (SqlConnection connection = new SqlConnection(Connectionstring))
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
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            Properties.Settings.Default.ConnectionString= $"Data Source={pServer};Initial Catalog={pDBname};User ID={pUser};Password= {pPass}";
            DAO.Properties.Settings.Default.Save();
        }
    }
}