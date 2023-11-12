using BUS;
using DAO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
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
    public partial class fReserva : DevExpress.XtraEditors.XtraForm
    {
        
        public fReserva()
        {
            InitializeComponent();

            
        }

        private void fReserva_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now.AddMonths(1);
            deToDate.DateTime= time;
            deToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            deFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";

        }

        private void bookingDKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingDKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeData);

        }

        private void fillDKToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookingDKTableAdapter.FillDK(this.coffeeData.BookingDK, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(deFromDate.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(deToDate.DateTime, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsNewItemRow(e.RowHandle))
                AddFood(view, e.RowHandle);
            else
                UpdateFood(view, e.RowHandle);
        }
        private void AddFood(GridView view, int rowHandle)
        {
            

            string name = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("họ tên không hợp lệ");
                return;
            }

            string email = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (email == "")
            {
                XtraMessageBox.Show("Hãy email không hợp lệ");
                return;
            }

            string number = view.GetRowCellValue(rowHandle, view.Columns[3]).ToString();
            if (number == "")
            {
                XtraMessageBox.Show("Số điện thpaji không được bỏ trống");
                return;
            }


            string quaityTemp = view.GetRowCellValue(rowHandle, view.Columns[4]).ToString();
            if (quaityTemp == "")
            {
                XtraMessageBox.Show("Số lượng không được bỏ trống");
                return;
            }
            int quantity = int.Parse(quaityTemp);
            if (quantity <= 0 || quantity > 50)
            {
                XtraMessageBox.Show("số lượng không hợp lệ");
                return;
            }
            DateTime date;
            try
            {
                 date = DateTime.Parse(view.GetRowCellValue(rowHandle, view.Columns[5]).ToString());
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Date khong hop le");
                return;
            }
            string Note= view.GetRowCellValue(rowHandle, view.Columns[6]).ToString();
            bool isCheckBoxChecked = (bool)view.GetRowCellValue(rowHandle, view.Columns[7]);
            
            //Booking newFood = new Booking(name,email,number,quantity, date,Note);
            CoffeeData a = new CoffeeData();
            //a.Booking.AddBookingRow()
            //if (BookingBus.Instance.InsertFood(newFood))
            //{
            //    SplashScreenManager.ShowForm(typeof(WaitForm));
            //    LoadFoodToGridControl();
            //    SplashScreenManager.CloseForm();
            //}
            //else
            //{
            //    SplashScreenManager.CloseForm();
            //    XtraMessageBox.Show("Thêm món mới thất bại", "Lỗi");
            //}
        }
        private void UpdateFood(GridView view, int rowHandle)
        {
            string id = view.GetRowCellValue(rowHandle, view.Columns[0]).ToString();
            if (id == "")
            {
                AddFood(view, rowHandle);
                return;
            }

            string name = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên món không hợp lệ");
                return;
            }

            string typeID = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (typeID == "")
            {
                XtraMessageBox.Show("Hãy chọn danh mục");
                return;
            }

            string priceTemp = view.GetRowCellValue(rowHandle, view.Columns[3]).ToString();
            if (priceTemp == "")
            {
                XtraMessageBox.Show("Đơn giá không được bỏ trống");
                return;
            }
            int price = int.Parse(priceTemp);
            if (price <= 0 || price > 1000000)
            {
                XtraMessageBox.Show("Đơn giá không hợp lệ");
                return;
            }

            //SplashScreenManager.ShowForm(typeof(WaitForm1));
            //Food food = new Food(int.Parse(id), name, int.Parse(typeID), price);
            //if (FoodBUS.Instance.UpdateFood(food))
            //{
            //    LoadFoodToGridControl();
            //    SplashScreenManager.CloseForm();
            //}
            //else
            //{
            //    SplashScreenManager.CloseForm();
            //    XtraMessageBox.Show("Sửa thông tin món thất bại\n Không thể thay đổi thông tin món hiện hành", "Lỗi");
            //}
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}