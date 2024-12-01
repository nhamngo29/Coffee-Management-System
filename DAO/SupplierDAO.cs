using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SupplierDAO
    {
        private static SupplierDAO instance;


        public static SupplierDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SupplierDAO();
                return SupplierDAO.instance;
            }
        }
        public SupplierDAO()
        {
        }
        public DataTable GetAll()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Select * from Supplier");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Insert(string name)
        {
            string query = "SP_InsertSupplier @Name";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name});
            return result > 0;
        }
    }
}
