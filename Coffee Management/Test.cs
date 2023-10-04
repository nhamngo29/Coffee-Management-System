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
    public partial class Test : DevExpress.XtraEditors.XtraForm
    {
        public Test()
        {
            InitializeComponent();
        }

        private void typeFoodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeFoodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeManagementDataSet);

        }

        private void Test_Load(object sender, EventArgs e)
        {
            
            this.foodTableAdapter.Fill(this.coffeeManagementDataSet.Food);
            // TODO: This line of code loads data into the 'coffeeManagementDataSet.Food' table. You can move, or remove it, as needed.
            this.foodTableAdapter.Fill(this.coffeeManagementDataSet.Food);
            // TODO: This line of code loads data into the 'coffeeManagementDataSet.TypeFood' table. You can move, or remove it, as needed.
            this.typeFoodTableAdapter.Fill(this.coffeeManagementDataSet.TypeFood);
            
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}