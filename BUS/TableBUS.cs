using System;
using System.Collections.Generic;
using System.Data;

using DAO;
using DTO;

namespace BUS
{
    public class TableBUS
    {
        private static TableBUS instance;

        public static TableBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableBUS();
                return TableBUS.instance;
            }
        }

        public DataTable GetAllTable()
        {
            try
            {
                return TableDAO.Instance.GetAllTable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Table> GetTableList()
        {
            DataTable table;
            try
            {
                table = TableDAO.Instance.GetTableList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<Table> lstTable = new List<Table>();
            foreach (DataRow row in table.Rows)
            {
                Table tb = new Table(row);
                lstTable.Add(tb);
            }
            return lstTable;
        }

        public void SwitchTable(int tableID1, int tableID2)
        {
            try
            {
                TableDAO.Instance.SwitchTable(tableID1, tableID2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MergeTable(int tableID1, int tableID2)
        {
            try
            {
                TableDAO.Instance.MergeTable(tableID1, tableID2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertTable(string name)
        {
            return TableDAO.Instance.InsertTable(name);
        }

        public bool UpdateTable(int id, string name)
        {
            return TableDAO.Instance.UpdateTable(id, name);
        }

        public bool DeleteTable(int id)
        {
            return TableDAO.Instance.DeleteTable(id);
        }
    }
}