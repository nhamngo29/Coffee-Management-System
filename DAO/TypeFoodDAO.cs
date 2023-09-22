using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TypeFoodDAO
    {
        static TypeFoodDAO instance;

        public static TypeFoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TypeFoodDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public List<TypeFood> GetCategoryByID(int id)
        {
            List<TypeFood> list = new List<TypeFood>();
            string query = "SP_GetTypeFoodByIdCategory " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                TypeFood type = new TypeFood(row);
                list.Add(type);
            }
            return list;
        }
        public List<TypeFood> GetTypeFood()
        {
            List<TypeFood> list = new List<TypeFood>();
            string query = "SP_GetTypeListIdNameNameCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                TypeFood type = new TypeFood((int)row["Mã loại"], row["Tên loại"].ToString(), row["Tên thể loại"].ToString(), (int)row["IdCategory"]);
                list.Add(type);
            }
            return list;
        }
        public List<TypeFood> GetTypeFoodAll()
        {
            List<TypeFood> list = new List<TypeFood>();
            string query = "Select * from typeFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TypeFood type = new TypeFood(item);
                list.Add(type);
            }
            return list;
        }
        public bool Insert(TypeFood c)
        {
            string query = "SP_InsertTypeFood  @Name , @IdCategory";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.Name, c.IdCategory });
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result > 0;
        }
        public bool Update(TypeFood a)
        {
            string query = "SP_UpdateTypeFood @Id,  @Name , @IdCategory";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {a.Id, a.Name, a.IdCategory });
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result > 0;
        }
    }
}
