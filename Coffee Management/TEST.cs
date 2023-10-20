using BUS;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TEST : DevExpress.XtraEditors.XtraForm
    {
        public TEST()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            gcBill.DataSource = ImagesBUS.Instance.GetAll();
            gvBill.Columns[0].Caption = "ID";
            gvBill.Columns[1].Caption = "Image";
        }


        private void gcBill_Click(object sender, EventArgs e)
        {

        }
    }
}