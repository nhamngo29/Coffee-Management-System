using System.Data;

namespace DTO
{
    public class BillInfo
    {
        public int ID { get; set; }
        public int BillID { get; set; }
        public int FoodID { get; set; }
        public int Amount { get; set; }

        public BillInfo(int id, int billID, int foodID, int amount)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Amount = amount;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["billID"];
            this.FoodID = (int)row["foodID"];
            this.Amount = (int)row["amount"];
        }
    }
}