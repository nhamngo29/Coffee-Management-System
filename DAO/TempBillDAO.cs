using System;
using System.Collections.Generic;
using System.Data;

using DTO;

namespace DAO
{
    public class TempBillDAO
    {
        private static TempBillDAO instance;

        public static TempBillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TempBillDAO();
                return TempBillDAO.instance;
            }
        }

        private TempBillDAO() { }

        public DataTable GetListTempBillByTableID(int tableID)
        {

            string query = "SP_GetListTempBillByTableID @TableID";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { tableID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}