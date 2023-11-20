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
    public partial class fDecentralization : DevExpress.XtraEditors.XtraForm
    {
        public fDecentralization()
        {
            InitializeComponent();
        }

        private void rOLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rOLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }

        private void rOLEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.rOLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }

        private void rOLEBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.rOLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }

        private void Decentralization_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.AccountStaff' table. You can move, or remove it, as needed.
            this.accountStaff.FillDK(this.coffeeDataSet.AccountStaff);
            // TODO: This line of code loads data into the 'coffeeDataSet.AccountDK' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'coffeeDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.coffeeDataSet.ROLE);
            // TODO: This line of code loads data into the 'coffeeDataSet.ROLE' table. You can move, or remove it, as needed.
            //this.rOLETableAdapter.Fill(this.coffeeDataSet.ROLE);

        }

       

        private void rOLEComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void rOLEComboBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void rOLEBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.rOLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void rOLEComboBox_SelectedValueChanged_2(object sender, EventArgs e)
        {
            try
            {
                this.accountRoleDKTableAdapter.Fill(this.coffeeDataSet.AccountRoleDK, ((int)(System.Convert.ChangeType(rOLEComboBox.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}