using DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ViewModelBillInfoDAO
    {
        static ViewModelBillInfoDAO instance;

        public static ViewModelBillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ViewModelBillInfoDAO();
                return ViewModelBillInfoDAO.instance;
            }
        }
        private ViewModelBillInfoDAO() { }
        public List<ViewModelBillInfo> GetByID(int id)
        {
            List<ViewModelBillInfo> list = new List<ViewModelBillInfo>();
            string query = "SP_GetBillInfoByIDBill @IDBIll";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                ViewModelBillInfo type = new ViewModelBillInfo(item);
                list.Add(type);
            }
            return list;
        }
    }
}
