using System.Data;

namespace DTO
{
    public class TempBill
    {
        public string Food { get; set; }
        public int AmountFood { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }

        public TempBill(string foodName, int amount, int price, int totalPrice = 0)
        {
            this.Food = foodName;
            this.AmountFood = amount;
            this.Price = price;
            this.Total = totalPrice;
        }

        public TempBill(DataRow row)
        {
            this.Food = row["Name"].ToString();
            this.AmountFood = (int)row["Amount"];
            this.Price = (int)row["Price"];
            this.Total = (int)row["TotalPrice"];
        }
    }
}