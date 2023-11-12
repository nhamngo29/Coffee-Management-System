using DAO;
using DTO;
using System;
using System.Data;

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
        public Staff GetByID(int ID)
        {
            try
            {
                return StaffDAO.Instance.GetByID(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
