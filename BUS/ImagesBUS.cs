using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public  class ImagesBUS
    {
        private static ImagesBUS instance;

        public static ImagesBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImagesBUS();
                return ImagesBUS.instance;
            }
        }

        private ImagesBUS()
        {

        }

        public DataTable GetAll()
        {
            try
            {
                return ImageDAO.Instance.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
