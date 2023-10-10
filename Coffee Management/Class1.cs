using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static public class Class1
    {
        public static void CloseAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                    form.Close();
            }
        }
    }
}
