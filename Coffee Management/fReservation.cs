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
    public partial class fReservation : DevExpress.XtraEditors.XtraForm
    {
        public fReservation()
        {
            InitializeComponent();
        }

        private void reservationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeManagementDataSet);

        }

        private void fReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeManagementDataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.coffeeManagementDataSet.Reservations);

        }
    }
}