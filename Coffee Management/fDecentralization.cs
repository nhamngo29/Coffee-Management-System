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
    }
}