using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid;

using BUS;

namespace GUI
{
    public partial class fTable : DevExpress.XtraEditors.XtraForm
    {
        string curTable;

        public fTable()
        {
            InitializeComponent();
            LoadTable();
            btnRemove.Enabled = false;
        }

        private void LoadTable()
        {
            try
            {
                gcTable.DataSource = TableBUS.Instance.GetAllTable();
                gvTable.Columns[0].Caption = "Mã số";
                gvTable.Columns[0].OptionsColumn.AllowEdit = false;
                gvTable.Columns[1].Caption = "Tên bàn";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        mark:
            fAddTable f = new fAddTable();
            f.ShowDialog();
            if (f.Table == -1)
                return;
            string table = "Bàn " + f.Table;
            for (int i = 0; i < gvTable.RowCount ; i++)
            {
                if (table.Equals(gvTable.GetRowCellValue(i, gvTable.Columns[1]).ToString()))
                {
                    XtraMessageBox.Show("Tên bàn này đã tồn tại!");
                    goto mark;
                }
            }

            if (TableBUS.Instance.InsertTable(table))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadTable();
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm bàn mới thành công");
                int tableID = (int)gvTable.GetRowCellValue(gvTable.RowCount - 1, gvTable.Columns[0]);
            }
            else
                XtraMessageBox.Show("Thêm bàn mới thất bại!", "Lỗi");
        }

        private void gcTable_DoubleClick(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            int id = (int)gvTable.GetRowCellValue(gvTable.FocusedRowHandle, gvTable.Columns[0]);
            string name = gvTable.GetRowCellValue(gvTable.FocusedRowHandle, gvTable.Columns[1]).ToString();

            if (XtraMessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TableBUS.Instance.DeleteTable(id))
                {
                    LoadTable();
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Đã xóa " + name, "Thông báo");
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Không thể xóa bàn đang có người", "Lỗi");
                }
            }
            btnRemove.Enabled = false;
        }

        private void gvTable_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            string name = view.GetRowCellValue(e.RowHandle, view.Columns[1]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên bàn không hợp lệ", "Lỗi");
                return;
            }

            for (int i = 0; i < gvTable.RowCount - 1; i++)
            {
                if (name.Equals(gvTable.GetRowCellValue(i, gvTable.Columns[1]).ToString()))
                {
                    XtraMessageBox.Show("Tên bàn này đã tồn tại!");
                    gvTable.SetRowCellValue(gvTable.FocusedRowHandle, gvTable.Columns[1], curTable);
                    return;
                }
            }
            int id = (int)view.GetRowCellValue(e.RowHandle, view.Columns[0]);
            if (TableBUS.Instance.UpdateTable(id, name))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadTable();
                SplashScreenManager.CloseForm();
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Sửa thông tin bàn thất bại!!", "Lỗi");
            }
        }

        private void gvTable_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            curTable = gvTable.GetRowCellValue(gvTable.FocusedRowHandle, gvTable.Columns[1]).ToString();
        }

        private void gvTable_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }

        private void fTable_Load(object sender, EventArgs e)
        {

        }
    }
}