﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
        }

        private BillDAO() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableID"></param>
        /// <returns>Bill ID, if Bill ID is null, this function will return -1</returns>
        public int GetUnCheckBillIDByTableID(int tableID)
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("GetUnCheckBillIDByTableID @TableID", new object[] { tableID });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (table.Rows.Count > 0)
            {
                DTO.Bill bill = new DTO.Bill(table.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(int tableID)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("SP_InsertBill @TableID", new object[] { tableID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetMaxBillID()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SP_GetMaxBillID");
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut(int billID, int discount, int totalPrice,int staff)
        {
            string query = "SP_CheckOut @ID , @Discount , @TotalPrice , @IdStaff";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID, discount, totalPrice ,staff});
            }
            catch { }
        }

        public DataTable GetListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetListBillByDay @fromDate , @toDate",
                    new object[] { fromDate, toDate });
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
                return DataProvider.Instance.ExecuteQuery("SP_GetListBillByDateAndPage @fromDate , @toDate , @Page",
                    new object[] { fromDate, toDate, pageNum });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetNumBillListByDateAndPage(DateTime fromDate, DateTime toDate)
        {
            return (int)DataProvider.Instance.ExecuteScalar(string.Format("GetNumBillByDate @FromDate , @ToDate"),new object[] { fromDate, toDate });
        }
        public bool DeleteBill(int id)
        {
            string query = string.Format("SP_DeleteBill @ID");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public double TotalAmountByMothAndYear(int Year,int Month)
        {
            try
            {
                return double.Parse(DataProvider.Instance.ExecuteScalar("SP_TotalAmountByMothAndYear @Year , @Month", new object[] { Year, Month }).ToString());
            }
            catch
            {
                return 0;
            }
        }
        public Bill GeByID(int id)
        {
            List<Bill> list = new List<Bill>();
            string query = "select * from bill where ID=" +id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Bill type = new Bill(row);
                list.Add(type);
            }
            return list[0];
        }
    }
}