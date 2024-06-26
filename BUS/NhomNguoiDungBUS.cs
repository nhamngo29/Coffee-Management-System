﻿using DAO;
using System;
using System.Data;


namespace BUS
{
    public class NhomNguoiDungBUS
    {
        private static NhomNguoiDungBUS instance;

        public static NhomNguoiDungBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhomNguoiDungBUS();
                return NhomNguoiDungBUS.instance;
            }
        }

        private NhomNguoiDungBUS()
        {

        }
        public DataTable GetAll()
        {
            try
            {
                return NhomNguoiDungDAO.Instance.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
