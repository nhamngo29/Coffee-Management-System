using System;
using System.Data;

using DAO;
using DTO;

namespace BUS
{
    public class BillBUS
    {
        private static BillBUS instance;

        public static BillBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillBUS();
                return BillBUS.instance;
            }
        }

        private BillBUS() { }

        public int GetUnCheckBillIDByTableID(int id)
        {
            try
            {
                return BillDAO.Instance.GetUnCheckBillIDByTableID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertBill(int tableID)
        {
            try
            {
                BillDAO.Instance.InsertBill(tableID);
            }
            catch { }
        }

        public int GetMaxBillID()
        {
            try
            {
                return BillDAO.Instance.GetMaxBillID();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CheckOut(int billID, int discount, int totalPrice)
        {
            try
            {
                BillDAO.Instance.CheckOut(billID, discount, totalPrice);
            }
            catch { }
        }

        public DataTable GetListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return BillDAO.Instance.GetListBillByDate(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable LoadListBillByDateAndPage(DateTime fromDate, DateTime toDate, int pageNum)
        {
            try
            {
                return BillDAO.Instance.LoadListBillByDateAndPage(fromDate, toDate, pageNum);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetNumBillListByDateAndPage(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return BillDAO.Instance.GetNumBillListByDateAndPage(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteBill(int id)
        {
            try
            {
                return BillDAO.Instance.DeleteBill(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}