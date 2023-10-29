using System;
using System.Data;

namespace DAO
{
    public class NhomNguoiDungDAO
    {
        private static NhomNguoiDungDAO instance;

        public static NhomNguoiDungDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhomNguoiDungDAO();
                return NhomNguoiDungDAO.instance;
            }
        }

        private NhomNguoiDungDAO() { }
        public DataTable GetAll()
        {
            string query = "SP_GetAllNhomNguoiDung";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
