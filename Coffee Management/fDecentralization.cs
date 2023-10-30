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

        private void account1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.account1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }

        private void fill_IDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.account1TableAdapter.Fill_ID(this.coffeeDataSet.Account1, ((int)(System.Convert.ChangeType(maIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fDecentralization_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.coffeeDataSet.Account);
            // TODO: This line of code loads data into the 'coffeeDataSet.AccountType' table. You can move, or remove it, as needed.
            this.accountTypeTableAdapter.Fill(this.coffeeDataSet.AccountType);

        }

        private void select_US_NToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.accountTableAdapter.select_US_N(this.coffeeDataSet.Account);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void accountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.account1TableAdapter.Fill_ID(this.coffeeDataSet.Account1, ((int)(System.Convert.ChangeType(accountTypeComboBox.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}