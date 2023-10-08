using DAO;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using DTO;

namespace GUI
{
    public partial class fGroupFood : DevExpress.XtraEditors.XtraForm
    {
        TypeFood curTypeFood;
        public fGroupFood()
        {
            InitializeComponent();
            LoadTypeFood();
        }
        void LoadTypeFood()
        {
            try
            {
                gcGroupFood.DataSource = TypeFoodDAO.Instance.GetTypeFoodAll();
                gvGroupFood.Columns[0].Caption = "Mã nhóm";
                gvGroupFood.Columns[0].OptionsColumn.AllowEdit = false;
                gvGroupFood.Columns[1].Caption = "Tên nhóm";
                gvGroupFood.Columns[2].Caption = "Tên danh mục";
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error: " + ex);
            }
            RepositoryItemLookUpEdit myLookup = new RepositoryItemLookUpEdit();
            try
            {
                myLookup.DataSource = CategoryBUS.Instance.GetAllCategory();
                myLookup.DisplayMember = "Name";
                myLookup.ValueMember = "ID";
                myLookup.NullText = "-- Chọn loại sản phẩm --";
                gvGroupFood.Columns[2].ColumnEdit = myLookup;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }

        }
        //private void InsertCategory(GridView view, int rowHandle)
        //{
        //    string name = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
        //    if (name == "")
        //    {
        //        XtraMessageBox.Show("Tên thể loại không hợp lệ");
        //        return;
        //    }

        //    if (TypeFoodBUS.Instance.InsertCategory)
        //    {
        //        SplashScreenManager.ShowForm(typeof(WaitForm1));
        //        LoadTypeFood();
        //        SplashScreenManager.CloseForm();
        //        Log.WriteLog("add new Category: " + name);
        //    }
        //    else
        //        XtraMessageBox.Show("Thêm danh mục thất bại", "Lỗi");
        //}
        private void AddTypeFood(GridView view, int rowHandle)
        {
            string Name=view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (Name == "")
            {
                XtraMessageBox.Show("Tên loại món không hợp lệ");
                return;
            }
            string CategoryID = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (CategoryID == "")
            {
                XtraMessageBox.Show("Hãy chọn danh mục");
                return;
            }
            TypeFood newType = new TypeFood(Name, int.Parse(CategoryID));
            if (TypeFoodBUS.Instance.InsertTypeFood(newType))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadTypeFood();
                SplashScreenManager.CloseForm();
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm loại món mới thất bại", "Lỗi");
            }    
        }
        void UpdateTypeFood(GridView view, int rowHandle)
        {
            string id = view.GetRowCellValue(rowHandle, view.Columns[0]).ToString();
            if(string.IsNullOrEmpty(id))
            {
                AddTypeFood(view, rowHandle);
                return;
            }
            string Name = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (Name == "")
            {
                XtraMessageBox.Show("Tên loại món không hợp lệ");
                return;
            }
            string CategoryID = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (CategoryID == "")
            {
                XtraMessageBox.Show("Hãy chọn danh mục");
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            TypeFood newType = new TypeFood(int.Parse(id),Name, int.Parse(CategoryID));
            if(TypeFoodBUS.Instance.UpdateTypeFood(newType))
            {
                LoadTypeFood();
                SplashScreenManager.CloseForm();
                //Log.WriteLog("update Type: Name: " + newType.Name + " -> " + Name
                //             + ", Category ID: " + curFood.TypeID + " -> " + typeID
                //             + ", Price: " + curFood.Price + " -> " + price);
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Sửa thông tin món thất bại\n Không thể thay đổi thông tin loại món hiện hành", "Lỗi");
            }
        }    

        private void gcGroupFood_Validated(object sender, EventArgs e)
        {

        }

        private void gcGroupFood_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gvGroupFood_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsNewItemRow(e.RowHandle))
                AddTypeFood(view, e.RowHandle);
            else
                UpdateTypeFood(view, e.RowHandle);
        }

        private void gvGroupFood_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object id = gvGroupFood.GetRowCellValue(gvGroupFood.FocusedRowHandle, gvGroupFood.Columns[0]);
            if (id == null || id == DBNull.Value)
                return;

            object name = gvGroupFood.GetRowCellValue(gvGroupFood.FocusedRowHandle, gvGroupFood.Columns[1]);
            if (name == null || name == DBNull.Value)
                return;

            object categoryID = gvGroupFood.GetRowCellValue(gvGroupFood.FocusedRowHandle, gvGroupFood.Columns[2]);
            if (categoryID == null || categoryID == DBNull.Value)
                return;

            curTypeFood = new TypeFood(name.ToString(), (int)categoryID);
        }

        private void gcGroupFood_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadTypeFood();
            SplashScreenManager.CloseForm();
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int) gvGroupFood.GetRowCellValue(gvGroupFood.FocusedRowHandle, gvGroupFood.Columns[0]);
            string name = gvGroupFood.GetRowCellValue(gvGroupFood.FocusedRowHandle, gvGroupFood.Columns[1]).ToString();
            if (XtraMessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TypeFoodBUS.Instance.DeleteTypeFood(id))
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    LoadTypeFood();
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Đã xóa " + name, "Thông báo");
                }
                else
                    XtraMessageBox.Show("Không thể xóa món hiện hành", "Lỗi");
            }
            btnRemove.Enabled = false;
        }
    }
}