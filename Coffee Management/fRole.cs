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

namespace GUI
{
    public partial class fRole : DevExpress.XtraEditors.XtraForm
    {
        public fRole()
        {
            InitializeComponent();
        }

        private void rOLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rOLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }

        private void fRole_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.Decentralization' table. You can move, or remove it, as needed.
            this.decentralizationTableAdapter.Fill(this.coffeeDataSet.Decentralization);
            // TODO: This line of code loads data into the 'coffeeDataSet.AccountRole' table. You can move, or remove it, as needed.
            this.accountRoleTableAdapter.Fill(this.coffeeDataSet.AccountRole);
            // TODO: This line of code loads data into the 'coffeeDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.coffeeDataSet.ROLE);
            // TODO: This line of code loads data into the 'coffeeDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.coffeeDataSet.ROLE);

        }

        private void rOLEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.rOLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }
    }
}