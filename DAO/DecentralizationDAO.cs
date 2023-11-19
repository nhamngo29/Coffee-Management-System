using DTO;
using DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DecentralizationDAO
    {
        private static DecentralizationDAO instance;

        public static DecentralizationDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DecentralizationDAO();
                return DecentralizationDAO.instance;
            }
        }
        private DecentralizationDAO() { }
        public DataTable GetAll()
        {
            string query = "select * from Decentralization";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Decentralization> GetAllList()
        {
            List<Decentralization> list = new List<Decentralization>();
            string query = "select * from Decentralization";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Decentralization type = new Decentralization(item);
                list.Add(type);
            }
            return list;
        }
        public List<Decentralization> GetDecentralizationByUser(string userName)
        {
            List<Decentralization> list = new List<Decentralization>();
            string query = "SP_GetDecentralizationByUser @UserName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {userName} );
            foreach (DataRow item in data.Rows)
            {
                Decentralization type = new Decentralization(item);
                list.Add(type);
            }
            return list;
        }


    }
}
