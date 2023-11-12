using System;
using System.Data;
using System.Collections.Generic;

using DAO;
using DTO;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
        }

        private AccountBUS() { }

        public bool CheckLogin(Account account)
        {
            if (account.UserName == "")
                return false;
            if (account.Password == "")
                return false;

            try
            {
                return AccountDAO.Instance.CheckLogin(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAllAcount()
        {
            try
            {
                return AccountDAO.Instance.GetAllAcount();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable table;
            try
            {
                table = AccountDAO.Instance.GetAccountByUserName(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new Account(table.Rows[0]);
        }

        public bool Insert(string userName, string displayName, int type)
        {
            try
            {
                return AccountDAO.Instance.Insert(userName, displayName, type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(string userName)
        {
            try
            {
                return AccountDAO.Instance.Delete(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetPassword(string userName)
        {
            try
            {
                return AccountDAO.Instance.ResetPassword(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateInformationAcc(string userName, string displayName, string password, string newPass)
        {
            try
            {
                return AccountDAO.Instance.UpdateInformationAcc(userName, displayName, password, newPass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateInformation(string userName, string displayName,int typeAccount ,int staff,bool active)
        {
            try
            {
                return AccountDAO.Instance.UpdateInformation(userName, displayName, typeAccount, staff, active);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Account> SearchAccountByUserName(string userName)
        {
            List<Account> listAccount = new List<Account>();
            DataTable table;
            try
            {
                table = AccountDAO.Instance.SearchAccountByUserName(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in table.Rows)
            {
                Account account = new Account(row);
                listAccount.Add(account);
            }
            return listAccount;
        }
    }
}