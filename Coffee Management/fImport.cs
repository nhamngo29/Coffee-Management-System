using BUS;
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

namespace GUI
{
    public partial class fImport : DevExpress.XtraEditors.XtraForm
    {
        private Account loginAccount { get; set; }
        public fImport(Account log)
        {
            InitializeComponent();
            loginAccount = log;
        }

        private void Import_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            gcImport.DataSource = ImportBUS.Instance.GetAll();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddImportProduct addImportProduct = new AddImportProduct(loginAccount);
            addImportProduct.ShowDialog();
            if(addImportProduct.result== 0)
                return;
            if(addImportProduct.result== 1)
            {
                MessageBox.Show("Nhạp hàng thành công");
            }
        }
    }
}