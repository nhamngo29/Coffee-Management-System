using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Management
{
    public partial class fRevenue : DevExpress.XtraEditors.XtraForm
    {
        public fRevenue()
        {
            InitializeComponent();
        }

        private void billBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeManagementDataSet);

        }

        private void fRevenue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeManagementDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.coffeeManagementDataSet.Bill);

        }
    }
}