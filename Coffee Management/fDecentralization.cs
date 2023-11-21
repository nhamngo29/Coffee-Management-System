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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.accountRoleDKTableAdapter.Fill(this.coffeeDataSet.AccountRoleDK, ((int)(System.Convert.ChangeType(roleIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fDecentralization_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.coffeeDataSet.ROLE);
            // TODO: This line of code loads data into the 'coffeeDataSet.AccountRole' table. You can move, or remove it, as needed.
            this.accountRoleTableAdapter.Fill(this.coffeeDataSet.AccountRole);

        }

      

        private void rOLEComboBox_SelectionChangeCommitted(object sender, EventArgs e)
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