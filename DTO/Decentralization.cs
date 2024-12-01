using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Decentralization
    {
        public int IDRole { get; set; }
        public string IDScreen { get; set; }
        public bool Visible { get; set; }

        public Decentralization()
        {
        }

        public Decentralization(int iDRole, string iDScreen, bool visible)
        {
            IDRole = iDRole;
            IDScreen = iDScreen;
            Visible = visible;
        }
        public Decentralization(DataRow row)
        {
            IDRole = (int)row["IDRole"];
            IDScreen = (string)row["IDScreen"];
            Visible = (bool)row["Visible"];
        }
    }
}
