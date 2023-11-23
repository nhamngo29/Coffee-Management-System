using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SupplierBUS
    {
        private static SupplierBUS instance;

        public static SupplierBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SupplierBUS();
                return SupplierBUS.instance;
            }
        }

        private SupplierBUS() { }
        public DataTable GetAll()
        {
            try
            {
                return SupplierDAO.Instance.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Insert(string name)
        {
            try
            {
                return SupplierDAO.Instance.Insert(name);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
