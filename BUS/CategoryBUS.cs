using System;
using System.Data;
using System.Collections.Generic;

using DAO;
using DTO;

namespace BUS
{
    public class CategoryBUS
    {
        private static CategoryBUS instance;

        public static CategoryBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryBUS();
                return CategoryBUS.instance;
            }
        }

        private CategoryBUS() { }

        public DataTable GetAllCategory()
        {
            try
            {
                return CategoryDAO.Instance.GetAllCategory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertCategory(string name)
        {
            try
            {
                return CategoryDAO.Instance.InsertCategory(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateCategory(int id, string name)
        {
            try
            {
                return CategoryDAO.Instance.UpdateCategory(id, name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeteleCategory(int id)
        {
            try
            {
                return CategoryDAO.Instance.DeteleCategory(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Category> SearchCategoryByName(string name)
        {
            try
            {
                return CategoryDAO.Instance.SearchCategoryByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}