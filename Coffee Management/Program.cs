using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Coffee_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static fSales _fSales = null;
        public static fLogin _fLogin = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _fLogin=new fLogin();
            Application.Run(_fLogin);
        }
    }
}
