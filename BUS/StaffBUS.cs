using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StaffBUS
    {

        private static StaffBUS instance;

        public static StaffBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffBUS();
                return StaffBUS.instance;
            }
        }

        private StaffBUS() { }
        public DataTable GetAll()
        {
            try
            {
                return StaffDAO.Instance.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(string name, DateTime DOB)
        {

            return StaffDAO.Instance.Insert(name, DOB);
        }

        public bool Update(int id, string name, DateTime DOB)
        {
            return StaffDAO.Instance.Update(id, name, DOB);
        }

        public bool Delete(int id)
        {
            return StaffDAO.Instance.Delete(id);
        }
    }
}
