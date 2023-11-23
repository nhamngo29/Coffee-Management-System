using DevExpress.XtraEditors;
using GUI.Data;
using GUI.Data.CoffeeDataSetTableAdapters;
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
                this.accountRoleDKTableAdapter.Fill(this.coffeeDataSet.AccountRoleDK, ((int)(System.Convert.ChangeType(rOLEComboBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fDecentralization_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.coffeeDataSet.Account);
            // TODO: This line of code loads data into the 'coffeeDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.coffeeDataSet.ROLE);
            // TODO: This line of code loads data into the 'coffeeDataSet.AccountRole' table. You can move, or remove it, as needed.
            this.accountRoleTableAdapter.Fill(this.coffeeDataSet.AccountRole);

        }
        private void rOLEComboBox_EditValueChanged(object sender, EventArgs e)
        {
            int IdRole = int.Parse(rOLEComboBox.EditValue.ToString());
            FillData(IdRole);
        }

        private void accountRoleDKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {



        }
        private void FillData(int roleId)
        {
            try
            {
                this.accountRoleDKTableAdapter.Fill(this.coffeeDataSet.AccountRoleDK, roleId);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.accountRoleNotEXISTSTableAdapter.FillAccountRoleDK(this.coffeeDataSet.AccountRoleNotEXISTSDK, roleId);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(gridView2.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                string UserName = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "UserName").ToString();
                int IdRole = int.Parse(rOLEComboBox.EditValue.ToString());
                if(accountRoleTableAdapter.Insert(IdRole, UserName, "")>0)
                    MessageBox.Show("Thêm thành công");
                FillData(IdRole);
            }    
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản và role");
            }    

        }

        private void btnDeleteAccountRole_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                string UserName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UserName").ToString();
                int IdRole = int.Parse(rOLEComboBox.EditValue.ToString());
                string TenNhomQuyen= rOLEComboBox.SelectedText.ToString();
                CoffeeDataSet.AccountRoleRow rowToDelete = coffeeDataSet.AccountRole.FirstOrDefault(t=>t.IDAccount== UserName && t.IDRole==IdRole);
                if (rowToDelete != null)
                {
                    if (XtraMessageBox.Show(string.Format("Bạn có chắc chắn xóa user {0} ra khỏi nhóm quyền {1} không ?", UserName, TenNhomQuyen),
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        accountRoleTableAdapter.DeleteQuery(IdRole, UserName);
                        FillData(IdRole);
                        MessageBox.Show("Xóa thành công");
                    }
                        
                }
                else
                {
                    MessageBox.Show("Dòng không tồn tại trong DataTable");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản và role");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}