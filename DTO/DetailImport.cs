﻿using System;
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
        public int ID { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string NameProduct { get; set; }
        public string Unit {  get; set; }

        public DetailImport(int idImport, int iD, int quantity, float price, string nameProduct, string unit)
        {
            IdImport = idImport;
            ID = iD;
            Quantity = quantity;
            Price = price;
            NameProduct = nameProduct;
            Unit = unit;
        }

        public DetailImport()
        {
        }
        public DetailImport(DataRow row)
        {
            IdImport = (int)row["IdImport"];
            ID = (int)row["ID"];
            Quantity = (int)row["Quantity"];
            Price = (int)row["Price"];
            NameProduct = (string)row["NameProduct"];
            Unit = (string)row["Unit"];
        }
    }
}
