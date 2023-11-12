using DAO;
using DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ViewModelBillInfoBUS
    {
        static ViewModelBillInfoBUS instance;
        public static ViewModelBillInfoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ViewModelBillInfoBUS();
                return ViewModelBillInfoBUS.instance;
            }
        }
        ViewModelBillInfoBUS() { }
        public List<ViewModelBillInfo> GetByID(int id)
        {
            try
            {
                return ViewModelBillInfoDAO.Instance.GetByID(id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
