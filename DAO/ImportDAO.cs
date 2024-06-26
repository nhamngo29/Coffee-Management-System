﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImportDAO
    {
        private static ImportDAO instance;

        public static ImportDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImportDAO();
                return ImportDAO.instance;
            }
        }

        private ImportDAO() { }

        public DataTable GetAll()
        {
            string query = "select * from ImportProduct";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Import GetImportMax()
        {
            List<Import> list = new List<Import>();
            string query = "SELECT TOP 1 * FROM ImportProduct ORDER BY ID DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Import type = new Import(row);
                list.Add(type);
            }
            return list[0];
        }
        public bool Insert(Import import)
        {
            string query = string.Format("SP_InsertImportProduct @IdStaff , @IdSupplier , @Note , @NameImportPorduct");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] {import.IdStaff, import.IdSupplier, import.Note,import.NameImportPorduct});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public double TotalAmountByMothAndYear(int Year, int Month)
        {
            try
            {
                return double.Parse(DataProvider.Instance.ExecuteScalar("SP_TotalImportProductByMothAndYear @Year , @Month", new object[] { Year, Month }).ToString());
            }
            catch
            {
                return 0;
            }
        }
    }
}
