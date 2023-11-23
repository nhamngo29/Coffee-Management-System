using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DecentralizationBUS
    {
        private static DecentralizationBUS instance;

        public static DecentralizationBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DecentralizationBUS();
                return DecentralizationBUS.instance;
            }
        }

        private DecentralizationBUS() { }
        public DataTable GetAll()
        {

            try
            {
                return DecentralizationDAO.Instance.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Decentralization> GetAllList()
        {
            try
            {
                return DecentralizationDAO.Instance.GetAllList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Decentralization> GetDecentralizationByUser(string userName)
        {
            try
            {
                return DecentralizationDAO.Instance.GetDecentralizationByUser(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
