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
        private void fDecentralization_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'coffeeDataSet.PhanQuyen' table. You can move, or remove it, as needed.
            this.phanQuyenTableAdapter.Fill(this.coffeeDataSet.PhanQuyen);
            // TODO: This line of code loads data into the 'coffeeDataSet.NhomNguoiDung' table. You can move, or remove it, as needed.
            this.nhomNguoiDungTableAdapter.Fill(this.coffeeDataSet.NhomNguoiDung);

        }

        private void fill_pqToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_PhanQuynTableAdapter.Fill_pq(this.coffeeDataSet.tb_PhanQuyn, tenToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void nhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.tb_PhanQuynTableAdapter.Fill_pq(this.coffeeDataSet.tb_PhanQuyn, nhomNguoiDungComboBox.SelectedText);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}