using Data.Repository.IRepository;
using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class FoodRepository : Repository<Food>, IFoodRepository
    {
        private readonly CoffeeEntitie _db=new CoffeeEntitie();
        public FoodRepository(CoffeeEntitie db) : base(db)
        {
            _db.Bookings.ToList();
            _db = db;
        }

        public void update(Food Food)
        {
            
        }
        public DataTable GetListFoodByTypeID(int TypeFoodID)
        {

            try
            {
                DataTable dataTable = new DataTable();
                using (var reader = ObjectReader.Create(_db.SP_GetListFoodByTypeFoodID(TypeFoodID)))
                {
                    dataTable.Load(reader);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetMaxID()
        {
            return _db.Foods.Select(t=>t.ID).Max();
        }
        public DataTable SearchFoodByName(string name)
        {
            try
            {
                
                var query = _db.Foods
                .Where(f => SqlFunctions.PatIndex("%" + SqlFunctions.PatIndex(name, f.Name) + "%", "") > 0)
                .ToList();
                DataTable dataTable = new DataTable();
                using (var reader = ObjectReader.Create(query))
                {
                    dataTable.Load(reader);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
