using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;

using BUS;
using DTO;
using System.IO;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing.Imaging;

namespace GUI
{
    public partial class fFood : DevExpress.XtraEditors.XtraForm
    {
        Food curFood;

        public fFood()
        {
            InitializeComponent();
            btnRemove.Enabled = false;
            btnSearch.Enabled = false;
            this.gvFood.RowCellClick += GvFood_RowCellClick;
            LoadFoodToGridControl();
        }

        private void GvFood_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.Columns[5] != null)
            {
                byte[] imageData = view.GetRowCellValue(e.RowHandle, e.Column) as byte[];
                if (imageData != null)
                {
                    ShowImageInPopup(imageData);
                }
            }
        }

        private void LoadFoodToGridControl()
        {
            try
            {
                gcFood.DataSource = FoodBUS.Instance.GetAllFood();
                gvFood.Columns[0].Caption = "Mã số";
                gvFood.Columns[0].OptionsColumn.AllowEdit = false;
                gvFood.Columns[1].Caption = "Tên";
                gvFood.Columns[2].Caption = "Loại";
                gvFood.Columns[3].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                gvFood.Columns[3].DisplayFormat.FormatString = "{0:0,0 VND}";
                gvFood.Columns[3].Caption = "Đơn giá";
                gvFood.Columns[4].Caption = "Mô tả";
                gvFood.Columns[5].Caption = "Hình ảnh";

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }

            RepositoryItemLookUpEdit myLookup = new RepositoryItemLookUpEdit();
            try
            {
                myLookup.DataSource = TypeFoodBUS.Instance.GetAllTypeFood();
                myLookup.DisplayMember = "Name";
                myLookup.ValueMember = "Id";
                myLookup.NullText = "-- Chọn loại sản phẩm --";
                gvFood.Columns[2].ColumnEdit = myLookup;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
        private void RepositoryItemLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit edit = sender as LookUpEdit;
            if (Convert.ToInt32(edit.EditValue) == 2)
                return;
            else
                XtraMessageBox.Show("Value changed");
        }
        private void gvFood_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsNewItemRow(e.RowHandle))
                AddFood(view, e.RowHandle);
            else
                UpdateFood(view, e.RowHandle);
        }
        private byte[] GetImageBytesFromRow(int rowHandle, GridView view)
        {
            byte[] imageData = null;

            // Kiểm tra xem có hình ảnh trong cột không
            if (view.IsDataRow(rowHandle) && view.GetRowCellValue(rowHandle, "Image Food") != null)
            {
                // Lấy đường dẫn hình ảnh từ cột dữ liệu
                string imagePath = view.GetRowCellValue(rowHandle, "Image Food").ToString();

                // Chuyển hình ảnh thành mảng byte[]
                if (!string.IsNullOrEmpty(imagePath))
                {
                    using (Image image = Image.FromFile(imagePath))
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, ImageFormat.Jpeg); // Thay đổi định dạng tùy theo loại hình ảnh
                        imageData = ms.ToArray();
                    }
                }
            }

            return imageData;
        }

        private void AddFood(GridView view, int rowHandle)
        {
            string name = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên món không hợp lệ");
                view.DeleteRow(rowHandle);
                return;
            }

            string typeID = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (typeID == "")
            {
                XtraMessageBox.Show("Hãy chọn danh mục");
                view.DeleteRow(rowHandle);
                return;
            }

            string priceTemp = view.GetRowCellValue(rowHandle, view.Columns[3]).ToString();
            if (priceTemp == "")
            {
                XtraMessageBox.Show("Đơn giá không được bỏ trống");
                view.DeleteRow(rowHandle);
                return;
            }
            int price = int.Parse(priceTemp);
            if (price <= 0 || price > 10000000)
            {
                XtraMessageBox.Show("Đơn giá không hợp lệ");
                view.DeleteRow(rowHandle);
                return;
            }
            //byte[] ImageFood = Convert.FromBase64String(view.GetRowCellValue(rowHandle, view.Columns[6]).ToString());

            byte[] imageData = view.GetRowCellValue(rowHandle, view.Columns[5]) as byte[];
            if (imageData == null)
            {
                XtraMessageBox.Show("Hình ảnh không được để trống");
                view.DeleteRow(rowHandle);
                return;
            }
            for (int i = 0; i < gvFood.RowCount - 1; i++)
            {
                if (name.Equals(gvFood.GetRowCellValue(i, gvFood.Columns[1]).ToString()))
                {
                    XtraMessageBox.Show("Tên món này đã tồn tại!");
                    return;
                }
            }

            Food newFood = new Food(name, int.Parse(typeID), price, "", imageData);
            if (FoodBUS.Instance.InsertFood(newFood))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadFoodToGridControl();
                XtraMessageBox.Show("Thêm món mới thành công", "Thông báo");
                SplashScreenManager.CloseForm();
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm món mới thất bại", "Lỗi");
                {
                }
            }
        }
        private void UpdateFood(GridView view, int rowHandle)
        {
            string id = view.GetRowCellValue(rowHandle, view.Columns[0]).ToString();
            if (id == "")
            {
                AddFood(view, rowHandle);
                view.DeleteRow(rowHandle);
                return;
            }

            string name = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên món không hợp lệ");
                view.DeleteRow(rowHandle);
                return;
            }

            string typeID = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (typeID == "")
            {
                XtraMessageBox.Show("Hãy chọn danh mục");
                view.DeleteRow(rowHandle);
                return;
            }

            string priceTemp = view.GetRowCellValue(rowHandle, view.Columns[3]).ToString();
            if (priceTemp == "")
            {
                XtraMessageBox.Show("Đơn giá không được bỏ trống");
                view.DeleteRow(rowHandle);
                return;
            }
            int price = int.Parse(priceTemp);
            if (price <= 0 || price > 1000000)
            {
                XtraMessageBox.Show("Đơn giá không hợp lệ");
                view.DeleteRow(rowHandle);
                return;
            }
            byte[] imageData = view.GetRowCellValue(rowHandle, view.Columns[5]) as byte[];
            if (imageData == null)
            {
                XtraMessageBox.Show("Hình ảnh không được để trống");
                view.DeleteRow(rowHandle);
                return;
            }
            for (int i = 0; i < gvFood.RowCount - 1; i++)
            {
                if (name.Equals(gvFood.GetRowCellValue(i, gvFood.Columns[1]).ToString())&&i!=rowHandle)
                {
                    XtraMessageBox.Show("Tên món này đã tồn tại!");
                    return;
                }
            }

            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Food food = new Food(int.Parse(id), name, int.Parse(typeID), price, "", imageData);
            if (FoodBUS.Instance.UpdateFood(food))
            {
                LoadFoodToGridControl();
                SplashScreenManager.CloseForm();
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Sửa thông tin món thất bại\n Không thể thay đổi thông tin món hiện hành", "Lỗi");
            }
        }

        private void gcFood_DoubleClick(object sender, EventArgs e)
        {
            if (gvFood.FocusedRowHandle >= 0)
                btnRemove.Enabled = true;
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int)gvFood.GetRowCellValue(gvFood.FocusedRowHandle, gvFood.Columns[0]);
            string name = gvFood.GetRowCellValue(gvFood.FocusedRowHandle, gvFood.Columns[1]).ToString();

            if (XtraMessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (FoodBUS.Instance.DeleteFood(id))
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    LoadFoodToGridControl();
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Đã xóa " + name, "Thông báo");
                }
                else
                    XtraMessageBox.Show("Không thể xóa món hiện hành", "Lỗi");
            }
            btnRemove.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadFoodToGridControl();
            SplashScreenManager.CloseForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                gcFood.DataSource = FoodBUS.Instance.SearchFoodByName(txtSearchFood.Text);
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchFood.Text != "")
                btnSearch.Enabled = true;
            else
                btnSearch.Enabled = false;
        }

        private void gvFood_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object id = gvFood.GetRowCellValue(gvFood.FocusedRowHandle, gvFood.Columns[0]);
            if (id == null || id == DBNull.Value)
                return;

            object name = gvFood.GetRowCellValue(gvFood.FocusedRowHandle, gvFood.Columns[1]);
            if (name == null || name == DBNull.Value)
                return;

            object categoryID = gvFood.GetRowCellValue(gvFood.FocusedRowHandle, gvFood.Columns[2]);
            if (categoryID == null || categoryID == DBNull.Value)
                return;

            object price = gvFood.GetRowCellValue(gvFood.FocusedRowHandle, gvFood.Columns[3]);
            if (price == null || price == DBNull.Value)
                return;

            curFood = new Food(name.ToString(), (int)categoryID, (int)price,  "", null);
        }
        private void ShowImageInPopup(byte[] imageData)
        {
            // Tạo một form popup hoặc UserControl để hiển thị hình ảnh lớn
            // Hiển thị hình ảnh bằng PictureBox hoặc một điều khiển tương tự.
            // Đặt dữ liệu hình ảnh cho PictureBox.

            FormImageViewer imagePopup = new FormImageViewer(imageData);
            imagePopup.ShowDialog();
        }

        private void fFood_Load(object sender, EventArgs e)
        {

        }
    }
}