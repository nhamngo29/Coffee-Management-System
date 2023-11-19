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
    public partial class fScreen : DevExpress.XtraEditors.XtraForm
    {
        public fScreen()
        {
            InitializeComponent();
        }

        private void screenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.screenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }

        private void fScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.Screen' table. You can move, or remove it, as needed.
            this.screenTableAdapter.Fill(this.coffeeDataSet.Screen);

        }
    }
}