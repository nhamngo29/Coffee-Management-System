using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

       
        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffDAO();
                return StaffDAO.instance;
            }
        }
        public StaffDAO()
        {
        }
        public DataTable GetAll()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Select * from staff");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(string name,DateTime DOB)
        {
            string query = "SP_InsertStaff @Name , @DOB";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name,DOB });
            return result > 0;
        }

        public bool Update(int id, string name, DateTime DOB)
        {
            string query = "SP_UpdateStaff @ID , @Name , @DOB";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name,DOB });
            return result > 0;
        }

        public bool Delete(int id)
        {
            string query = string.Format("SP_DeleteStaff @ID");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
        public Staff GetByID(int id)
        {
            List<DTO.Staff> list = new List<DTO.Staff>();
            string query = "select * from staff where ID=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO.Staff type = new DTO.Staff(row);
                list.Add(type);
            }
            return list[0];
        }
    }
}
