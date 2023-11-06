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
    public partial class fAddUser : DevExpress.XtraEditors.XtraForm
    {
        public fAddUser()
        {
            InitializeComponent();
        }

        private void accountTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }

        private void fAddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.getFullUser' table. You can move, or remove it, as needed.
            this.getFullUserTableAdapter.Fill(this.coffeeDataSet.getFullUser);
            // TODO: This line of code loads data into the 'coffeeDataSet.AccountType' table. You can move, or remove it, as needed.
            this.accountTypeTableAdapter.Fill(this.coffeeDataSet.AccountType);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getFillUserTableAdapter.Fill(this.coffeeDataSet.getFillUser, loaiToolStripTextBox.Text);
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
                this.getFillUserTableAdapter.Fill(this.coffeeDataSet.getFillUser, accountTypeComboBox.SelectedText);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}