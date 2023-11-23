using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DetailImportBUS
    {
        private static DetailImportBUS instance;

        public static DetailImportBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DetailImportBUS();
                return DetailImportBUS.instance;
            }
        }

        private DetailImportBUS()
        {

        }
        public DataTable GetAll()
        {
            try
            {
                return DetailImportDAO.Instance.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertImport(DetailImport im)
        {
            try
            {
                return DetailImportDAO.Instance.Insert(im);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
