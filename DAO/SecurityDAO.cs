using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SecurityDAO
    {
        private static SecurityDAO instance;

        public static SecurityDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SecurityDAO();
                return SecurityDAO.instance;
            }
        }

        private SecurityDAO() { }

        public void BackupData(string strpath)
        {
            string query = string.Format("BACKUP DATABASE CoffeeManagement TO DISK='{0}'", strpath);
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RestoreData(string strpath)
        {
            string query = string.Format("USE master RESTORE DATABASE CoffeeManagement FROM DISK='{0}'", strpath);
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}