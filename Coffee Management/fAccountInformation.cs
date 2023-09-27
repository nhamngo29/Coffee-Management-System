using DevExpress.XtraEditors;
using DTO;
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
    public partial class fAccountInformation : DevExpress.XtraEditors.XtraForm
    {
        Account acc { get; set; }
        public fAccountInformation(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
           
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void fAccountInformation_Load(object sender, EventArgs e)
        {

        }
    }
}