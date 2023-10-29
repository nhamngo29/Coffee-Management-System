using System;
using System.Data;

namespace DAO
{
    public class DiscountDAO
    {
        private static DiscountDAO instance;

        public static DiscountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DiscountDAO();
                return DiscountDAO.instance;
            }
        }

        private DiscountDAO() { }
        public int GetNumDiscount(string ID)
        {
            int num;
            string query = string.Format("SP_GetNumPercent '{0}'", ID);
            try
            {
                num = (int)DataProvider.Instance.ExecuteScalar(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (num > 0&&num!=null)
            {
                return num;
            }
            return -1;
        }
        public DataTable GetAllDiscount()
        {
            string query = string.Format("Select * from discount");
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Insert(int Percent,int Quantity)
        {
            string query = string.Format("SP_InsertDiscount {0},{1}", Percent,Quantity);
            try
            {
                return (int)DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Delete(string id)
        {
            string query = string.Format("SP_DeleteDisscount {0}",id);
            try
            {
                return (int)DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
