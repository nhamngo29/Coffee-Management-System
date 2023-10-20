using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImageDAO
    {
        private static ImageDAO instance;

        public static ImageDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImageDAO();
                return ImageDAO.instance;
            }
        }

        private ImageDAO() { }
        public DataTable GetAllFood()
        {
            string query = "SP_GetAllFood";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAll()
        {
            string query = "select * from Images";
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
