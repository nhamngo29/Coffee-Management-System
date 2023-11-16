using System;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static fLogin _fLogin;
        public static fManager _fManager;
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _fLogin = new fLogin();
            Application.Run(_fLogin);
        }
    }
}