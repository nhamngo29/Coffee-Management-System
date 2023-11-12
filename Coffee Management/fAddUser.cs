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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }

        private void accountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.getFillUserTableAdapter.Fill(this.coffeeDataSet.getFillUser, accountTypeComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void LoadComboByCondition()
        {
            if (accountTypeComboBox.SelectedValue != null)
                this.getFillUserTableAdapter.Fill(this.coffeeDataSet.getFillUser,accountTypeComboBox.SelectedValue.ToString());
        }

        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow item in gridView2.GetSelectedRows())
            //{
            //    // Nhớ kiểm tra trước khi thêm trùng khóa chính
            //    if (this.account1TableAdapter.KTKC(item.Cells[0].Value.ToString(), ((int)(Convert.ChangeType(accountTypeComboBox.SelectedValue.ToString(), typeof(int))))) == null)
            //    {
            //        MessageBox.Show("Đã tồn tại");
            //    }
            //    else
            //    {
            //        this.account1TableAdapter.InsertQuery(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), ((int)(Convert.ChangeType(accountTypeComboBox.SelectedValue.ToString(), typeof(int))), ((Convert.ChangeType(item.Cells[4].Value.ToString(), typeof(int?)), typeof(int))), ((bool)(Convert.ChangeType(item.Cells[5].ToString(), typeof(bool)))))); //accountTypeComboBox.SelectedValue.ToString(), string.Empty);
            //    }
            //}
            LoadComboByCondition();
        }
    }
}