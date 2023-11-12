using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BillInfoBUS
    {
        private static BillInfoBUS instance;

        public static BillInfoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoBUS();
                return BillInfoBUS.instance;
            }
        }

        private BillInfoBUS() { }

        public void InsertBillInfo(int billID, int foodID, int amount)
        {
            try
            {
                BillInfoDAO.Instance.InsertBillInfo(billID, foodID, amount);
            }
            catch { }
        }
        public void DeleteFoodBillInfo(int billID, string foodName, int amount)
        {
            try
            {
                BillInfoDAO.Instance.DeleteFoodBillInfo(billID, foodName, amount);
            }
            catch { }
        }
        public void DeleteBillInfoByBillID(int billID)
        {
            try
            {
                BillInfoDAO.Instance.DeleteBillInfoByBillID(billID);
            }
            catch { }
        }
        public List<BillInfo> GetBillInfoByBillID(int billID)
        {
            try
            {
                return BillInfoDAO.Instance.GetListBillInfoByIDBill(billID);
            }
            catch
            {
                return null;
                throw;
            }
        }
    }
}