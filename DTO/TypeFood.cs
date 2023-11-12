using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TypeFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
        public TypeFood(int id, string name, string nameCategory,int idCategory)
        {
            Id = id;
            Name = name;
            NameCategory=nameCategory;
            IdCategory = idCategory;
        }
        public TypeFood(DataRow row)
        {
            Id = (int)row["Id"];
            Name = (string)row["Name"];
            IdCategory = (int)row["IdCategory"];
        }
        public TypeFood(string name, int idCategory)
        {
            IdCategory=idCategory;
            Name= name;
        }
        public TypeFood(int id,string name,int idCategory)
        {
            Id = id;
            Name = name;
            IdCategory = idCategory;
        }
    }
}
