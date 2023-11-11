using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class DetailImport
    {
        public int IdImport { get; set; }
        public int IdPorduct { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string NameProduct { get; set; }

        public DetailImport(int idImport, int idPorduct, int quantity, float price, string nameProduct)
        {
            IdImport = idImport;
            IdPorduct = idPorduct;
            Quantity = quantity;
            Price = price;
            NameProduct = nameProduct;
        }

        public DetailImport()
        {
        }
        public DetailImport(DataRow row)
        {
            IdImport = (int)row["IdImport"];
            IdPorduct = (int)row["IdPorduct"];
            Quantity = (int)row["Quantity"];
            Price = (int)row["Price"];
            NameProduct = (string)row["NameProduct"];
        }
    }
}
