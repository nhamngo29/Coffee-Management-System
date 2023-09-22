﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Security.Cryptography;
using DTO;
using System.Text;
using System.Linq;
namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
        }
        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }
            //str_md5=str_md5.Reverse().ToString();
            return str_md5;
        }
        public bool CheckLogin(Account account)
        {
            string HasPassword = GetMD5(account.Password);//Mã hóa password
            string query = "SP_Login @UserName , @Password";//query đẻ sự dụng 
            DataTable result = new DataTable();
            try
            {
                result = DataProvider.Instance.ExecuteQuery(query, new object[] { account.UserName, HasPassword });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result.Rows.Count > 0;//lớn hơn 0 thì trả về true nguowjkc lại trả về flase
        }
        public DataTable GetAllAcount()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAllAccount");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAccountByUserName(string userName)
        {
            string query = "SP_GetAccountByUserName @UserName";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(string userName, string displayName, int typeID)
        {
            string query = string.Format("SP_InsertAccount @UserName , @DisplayName , @TypeID");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { userName, displayName, typeID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("SP_ResetPassword @UserName");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool Delete(string userName)
        {
            string query = string.Format("SP_DeleteAccount @UserName");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdateInformation(string userName, string displayName, string password, string newPass)
        {
            string query = "SP_UpdateAccount @UserName , @DisplayName , @Password , @NewPass";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { userName, displayName, password, newPass });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdateInformation(string userName,string displayName,int typeAccount)
        {
            string query = "SP_UpdateAccountFromAdmin @UserName , @DisplayName , @TypeAccount";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { userName, displayName,typeAccount });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public DataTable SearchAccountByUserName(string userName)
        {

            string query = string.Format("SP_SearchAccountByUserName @UserName");

            DataTable table = new DataTable();
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}