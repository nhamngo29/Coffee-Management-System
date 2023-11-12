using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
        }

        private BillInfoDAO() { }

        public void InsertBillInfo(int billID, int foodID, int amount)
        {
            string query = "SP_InsertBillInfo @BillID , @FoodID , @Amount";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID, foodID, amount });
            }
            catch { }
        }
        public void DeleteFoodBillInfo(int billID, string foodName, int amount)
        {
            string query = "SP_DeleteFoodByIdBill @BillID , @FoodName , @Amount";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID, foodName, amount });
            }
            catch { }
        }
        public void DeleteBillInfoByBillID(int billID)
        {
            string query = string.Format("SP_DeleteBillInfoByBillID @BillID");
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID });
            }
            catch { }
        }
        public List<BillInfo> GetListBillInfoByIDBill(int id)
        {
            List<BillInfo> list = new List<BillInfo>();
            string query = string.Format("select * from billinfo where BillID=" + id);
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in table.Rows)
            {
                BillInfo category = new BillInfo(row);
                list.Add(category);
            }
            return list;
        }
    }
}