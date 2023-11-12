using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImportDAO
    {
        private static ImportDAO instance;

        public static ImportDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImportDAO();
                return ImportDAO.instance;
            }
        }

        private ImportDAO() { }

        public DataTable GetAll()
        {
            string query = "select * from ImportProduct";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
