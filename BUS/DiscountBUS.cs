using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class DiscountBUS
    {
        private static DiscountBUS instance;

        public static DiscountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DiscountBUS();
                return DiscountBUS.instance;
            }
        }

        private DiscountBUS() { }
        public int GetUnCheckBillIDByTableID(string id)
        {
            try
            {
                return DiscountDAO.Instance.GetNumDiscount(id);
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
        }
        public DataTable GetAllDiscount()
        {
            try
            {
                return DiscountDAO.Instance.GetAllDiscount();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Insert(int Percent, int Quantity)
        {
            try
            {
                return (DiscountDAO.Instance.Insert(Percent, Quantity) > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(string id)
        {
            try
            {
                return (DiscountDAO.Instance.Delete(id) > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
