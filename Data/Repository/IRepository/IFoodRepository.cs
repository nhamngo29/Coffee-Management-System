using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.IRepository
{
    public interface IFoodRepository : IRepository<Food>
    {
        void update(Food Food);
        int GetMaxID();
        DataTable GetListFoodByTypeID(int TypeFoodID);
        DataTable SearchFoodByName(string name);
    }
}
