using System;
using System.Collections.Generic;
using System.Data;
namespace DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodDAO();
                return FoodDAO.instance;
            }
        }

        private FoodDAO() { }

        public DataTable GetAllFood()
        {
            string query = "SP_GetAllFood";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetListFoodByTypeID(int TypeFoodID)
        {
            string query = "SP_GetListFoodByTypeFoodID @TypeFoodID";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { TypeFoodID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DTO.Food GetFoodByID(int ID)
        {
            List<DTO.Food> list = new List<DTO.Food>();
            string query = "SP_GetFoodByID "+ID;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO.Food type = new DTO.Food(row);
                list.Add(type);
            }
            return list[0];
        }    

        public DataTable SearchFoodByName(string name)
        {
            string query = string.Format("SP_SearchFoodByName @Name");
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertFood(DTO.Food newFood)
        {
            string query = string.Format("SP_InsertFood @Name , @TypeID , @Price , @Image");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { newFood.Name, newFood.TypeID, newFood.Price,newFood.ImageFood });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdateFood(DTO.Food food)
        {
            string query = string.Format("SP_UpdateFood @ID , @Name , @TypeID , @Price , @Image");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { food.ID, food.Name, food.TypeID, food.Price,food.ImageFood });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool isExist(string Name)
        {
            try
            {
                return  DataProvider.Instance.ExecuteNonQuery($"SELECT * FROM Food WHERE UPPER(Name) = UPPER(N'{Name}')")>0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return false;
        }
        public bool DeleteFood(int ID)
        {
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery("SP_DeleteFood @ID", new object[] { ID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}