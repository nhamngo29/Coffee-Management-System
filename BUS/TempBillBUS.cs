using System;
using System.Data;
using System.Collections.Generic;

using DAO;
using DTO;

namespace BUS
{
    public class TempBillBUS
    {
        private static TempBillBUS instance;

        public static TempBillBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TempBillBUS();
                return TempBillBUS.instance;
            }
        }

        private TempBillBUS() { }

        public List<TempBill> GetListTempBillByTableID(int tableID)
        {
            DataTable table;
            try
            {
                table = TempBillDAO.Instance.GetListTempBillByTableID(tableID);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<TempBill> lstTempBill = new List<TempBill>();
            foreach (DataRow row in table.Rows)
            {
                TempBill tmp = new TempBill(row);
                lstTempBill.Add(tmp);
            }
            return lstTempBill;
        }
    }
}