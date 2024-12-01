using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DetailImportDAO
    {
        private static DetailImportDAO instance;

        public static DetailImportDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DetailImportDAO();
                return DetailImportDAO.instance;
            }
        }

        private DetailImportDAO() { }
        public DataTable GetAll()
        {
            string query = "select * from DetailImport";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Insert(DetailImport import)
        {
            string query = string.Format("SP_ImportDetailProduct @IdImport , @Quantity , @Price , @NameProduct , @Unit");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { import.IdImport, import.Quantity,import.Price, import.NameProduct, import.Unit });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
