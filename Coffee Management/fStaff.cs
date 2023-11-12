using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
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
    public partial class fStaff : DevExpress.XtraEditors.XtraForm
    {
        public fStaff()
        {
            InitializeComponent();
            Load();
        }
        private void Staff()
        {
            try
            {
                gc.DataSource = AccountBUS.Instance.GetAllAcount();
                gv.Columns[1].Caption = "Họ Tên";
                gv.Columns[2].Caption = "Ngày sinh";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
        private void fStaff_Load(object sender, EventArgs e)
        {
            Load();
        }
        private void Load()
        {
            try
            {
                gc.DataSource = StaffBUS.Instance.GetAll();
                gv.Columns[0].Caption = "Mã số";
                gv.Columns[0].OptionsColumn.AllowEdit = false;
                gv.Columns[1].Caption = "Tên nhân viên";
                gv.Columns[2].Caption = "Ngày sinh";
                gv.Columns[2].DisplayFormat.FormatString="dd/mm/yyyy";
                gv.Columns[2].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gv.Columns[2].ColumnEdit = new RepositoryItemDateEdit();
                RepositoryItemDateEdit dateEdit = gv.Columns[2].ColumnEdit as RepositoryItemDateEdit;
                dateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                dateEdit.DisplayFormat.FormatString = "dd/MM/yyyy"; // Định dạng ngày tháng của bạn
               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void gc_Click(object sender, EventArgs e)
        {

        }

        private void gc_DoubleClick(object sender, EventArgs e)
        {
            if (gv.FocusedRowHandle >= 0)
            {
                btnRemove.Enabled = true;
                btnResetPassword.Enabled = true;
            }
        }
        private void InsertAccount(GridView view, int rowHandle)
        {
            string userName = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            DateTime dateTime= DateTime.Now;
            if (userName == "")
            {
                XtraMessageBox.Show("Tên không hợp lệ");
                return;
            }
            if (StaffBUS.Instance.Insert(userName, dateTime))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                Load();
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm nhân viên thành công", "Thông báo");
            }
            else
                XtraMessageBox.Show("Thêm tài khoản mới thất bại", "Lỗi");
        }
        void UpdateAccount(GridView view, int rowHandle)
        {
            string id = view.GetRowCellValue(rowHandle, view.Columns[0]).ToString();
            if (id == "")
            {
                InsertAccount(view, rowHandle);
                return;
            }
            string name = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên không hợp lệ");
                return;
            }
            DateTime dateTime = (DateTime)view.GetRowCellValue(rowHandle, view.Columns[2]);
            if (dateTime == null)
            {
                XtraMessageBox.Show("Hãy chọn ngày sinh");
                return;
            }
            if (StaffBUS.Instance.Update(int.Parse(id), name, dateTime))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                SplashScreenManager.CloseForm();
                //Log.WriteLog("update Category: " + curName + " -> " + name);
            }
            else
                XtraMessageBox.Show("Update account thất bại", "Lỗi");
        }
        private void gv_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.IsNewItemRow(e.RowHandle))
                InsertAccount(view, e.RowHandle);
            else
            {
                UpdateAccount(view, e.RowHandle);
            }
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fullName = gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[1]).ToString();
            
            if (XtraMessageBox.Show("Xóa " + fullName + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (StaffBUS.Instance.Delete(int.Parse(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]).ToString())))
                {
                    XtraMessageBox.Show("Xóa tài khoản thành công");
                    Load();
                }
                else
                    XtraMessageBox.Show("Xóa tài khoản thất bại", "Lỗi");
            }
            btnRemove.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                gc.DataSource = AccountBUS.Instance.SearchAccountByUserName(txtSearchAccount.Text);
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Load();
            SplashScreenManager.CloseForm();
        }

        private void fStaff_Load_1(object sender, EventArgs e)
        {

        }

        private void fStaff_Load_2(object sender, EventArgs e)
        {

        }

        private void fStaff_Load_3(object sender, EventArgs e)
        {

        }
    }
}