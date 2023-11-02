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
            LoadFoodToGridControl();
            this.gvFood.RowCellClick += GvFood_RowCellClick;
            this.gvFood.RowClick += GvFood_RowClick;
        }

        private void GvFood_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                object imageValue = gvFood.GetRowCellValue(e.RowHandle, "Hình ảnh");

                if (imageValue != null)
                {
                    byte[] imageData = imageValue as byte[];

                    if (imageData != null)
                    {
                        // Tạo một cửa sổ hoặc form popup để hiển thị hình ảnh
                        Form imageForm = new Form();
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                        pictureBox.Dock = DockStyle.Fill;
                        imageForm.Controls.Add(pictureBox);
                        imageForm.Size = pictureBox.Image.Size;
                        imageForm.ShowDialog();
                    }
                }
            }
        }

        private void GvFood_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2 && e.Column.FieldName == "Hình ảnh")
            {
                object imageValue = gvFood.GetRowCellValue(e.RowHandle, "Hình ảnh");

                if (imageValue != null)
                {
                    // Kiểm tra nếu giá trị không rỗng
                    byte[] imageData = imageValue as byte[]; // Giả sử dữ liệu hình ảnh được lưu trong cột dưới dạng mảng byte

                    if (imageData != null)
                    {
                        // Ở đây, bạn có thể hiển thị hình ảnh trong một cửa sổ mới hoặc một form popup.
                        // Ví dụ, bạn có thể sử dụng một PictureBox để hiển thị hình ảnh.

                        Form imageForm = new Form();
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                        pictureBox.Dock = DockStyle.Fill;
                        imageForm.Controls.Add(pictureBox);
                        imageForm.Size = pictureBox.Image.Size;
                        imageForm.ShowDialog();
                    }
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
                gvFood.Columns[3].Caption = "Đơn giá";
                gvFood.Columns[4].Caption = "Hình ảnh";
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
            if (view.IsNewItemRow(e.RowHandle))//
                AddFood(view, e.RowHandle);
            else
                UpdateFood(view, e.RowHandle);
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

            if (FoodBUS.Instance.isExist(name))
            {
                Food newFood = new Food(name, int.Parse(typeID), price, "", "",null);
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
                }
            }
            else
            {
                XtraMessageBox.Show("Món đã tồn tại vui lòng thử lại");
                view.DeleteRow(rowHandle);
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

            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Food food = new Food(int.Parse(id), name, int.Parse(typeID), price,"","",null);
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
                
            curFood = new Food(name.ToString(), (int)categoryID, (int)price,"","",null);
        }

        private void gcFood_Click(object sender, EventArgs e)
        {

        }

        private void fFood_Load(object sender, EventArgs e)
        {

        }

        private void gvFood_RowClick_1(object sender, RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location);

                if (hitInfo.InRowCell && hitInfo.Column.FieldName == "ImageFood")
                {
                    string imagePath = view.GetRowCellValue(e.RowHandle, "ImagePathColumn").ToString();

                    // Mở một cửa sổ xem hình ảnh lớn tại đây
                    FormImageViewer imageViewer = new FormImageViewer(imagePath);
                    imageViewer.ShowDialog();
                }
            }
        }
        private void gvFood_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }
    }
}