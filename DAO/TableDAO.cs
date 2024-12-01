using System;
using System.Data;


namespace DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return instance;
            }
        }

        private TableDAO() { }

        public DataTable GetAllTable()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAllTable");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetTableList()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetListTable");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SwitchTable(int tableID1, int tableID2)
        {
            try
            {
                DataProvider.Instance.ExecuteQuery("SP_SwitchTable @TableID1 , @TableID2", new object[] { tableID1, tableID2 });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MergeTable(int tableID1, int tableID2)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("SP_BillardTable @TableID1 , @TableID2", new object[] { tableID1, tableID2 });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertTable(string name)
        {
            string query = "SP_InsertTable @Name";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name });
            return result > 0;
        }

        public bool UpdateTable(int id, string name)
        {
            string query = "SP_UpdateTable @ID , @Name";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name });
            return result > 0;
        }

        public bool DeleteTable(int id)
        {
            string query = string.Format("SP_DeleteTableFood @ID");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
        public bool IsExist(string name)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery($"SELECT * FROM TableCoffee WHERE UPPER(Name) = UPPER(N'{name}')") > 0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}