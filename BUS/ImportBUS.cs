using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ImportBUS
    {
        private static ImportBUS instance;

        public static ImportBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImportBUS();
                return ImportBUS.instance;
            }
        }

        private ImportBUS()
        {

        }
        public DataTable GetAll()
        {
            try
            {
                return ImportDAO.Instance.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
