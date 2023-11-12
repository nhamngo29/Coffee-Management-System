using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class Screen
    {
        public string Id {  get; set; }
        public string Name { get; set; }

        public Screen(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public Screen()
        {
        }
        public Screen(DataRow row)
        {
            Id = row["Id"].ToString();
            Name = row["Name"].ToString();
        }
    }
}
