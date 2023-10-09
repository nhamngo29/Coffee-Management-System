using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TextEditController.IME;
using DevExpress.XtraReports.UI;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fReservation : DevExpress.XtraEditors.XtraForm
    {
        public fReservation()
        {
            InitializeComponent();
        }

        private void bookingDKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingDKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }

        

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookingDKTableAdapter.FillDK(this.coffeeDataSet.BookingDK, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(deFromDate.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(deToDate.DateTime, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        
        private void fReservation_Load(object sender, EventArgs e)
        {
            deToDate.DateTime = DateTime.Now.AddMonths(1);
            btnShowBill.PerformClick();
        }
    }
}