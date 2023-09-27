using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Coffee_Management.Custom
{
    public class Dialog 
    {
        private string content;
        private int type;
        public readonly static int ERROR_DIALOG = 1;
        public readonly static int SUCCESS_DIALOG = 2;
        public readonly static int INFO_DIALOG = 3;
        public readonly static int WARNING_DIALOG = 4;

    }
}
