using System;
using System.Collections.Generic;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class TypeFoodBUS
    {
        static TypeFoodBUS instance;
        public static TypeFoodBUS Instance
        {
            get
            {
                if(instance==null)
                    instance = new TypeFoodBUS();
                return TypeFoodBUS.instance;
            }
        }
        TypeFoodBUS() { }
        public List<TypeFood> GetAllTypeFoodByIdCategoryID(int CategororyID)
        {
            try
            {
                return TypeFoodDAO.Instance.GetCategoryByID(CategororyID);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<TypeFood> GetAllTypeFood()
        {
            try
            {
                return TypeFoodDAO.Instance.GetTypeFood();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool InsertCategory(string name,int IdCategory)
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
        public bool InsertTypeFood(TypeFood c)
        {
            return TypeFoodDAO.Instance.Insert(c);
        }
        public bool UpdateTypeFood(TypeFood c)
        {
            return TypeFoodDAO.Instance.Update(c);
        }
        public bool DeleteTypeFood(int id)
        {
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery("SP_DeleteTypeFood @ID", new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

    }
}
