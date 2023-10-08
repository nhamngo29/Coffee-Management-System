using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using BUS;
using DTO;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class fDiscount : DevExpress.XtraEditors.XtraForm
    {
        Discount curDiscount;
        public fDiscount()
        {
            InitializeComponent();
            LoadDiscountGirdLoad();
            btnRemove.Enabled = false;
        }
        void LoadDiscountGirdLoad()
        {
            try
            {
                gcDiscount.DataSource = DiscountBUS.Instance.GetAllDiscount();
                gvDiscount.Columns[0].Caption = "Mã giảm giá";
                gvDiscount.Columns[0].OptionsColumn.AllowEdit = false;
                gvDiscount.Columns[1].Caption = "Phần trăm";
                gvDiscount.Columns[2].Caption = "Số lượng";
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fAddDisscount f = new fAddDisscount();
            f.ShowDialog();
            LoadDiscountGirdLoad();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDiscountGirdLoad();
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvDiscount.GetRowCellValue(gvDiscount.FocusedRowHandle, gvDiscount.Columns[0]).ToString();
            if (XtraMessageBox.Show("Xóa ma giảm giá " + id + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DiscountBUS.Instance.Delete(id))
                {
                    XtraMessageBox.Show("Xóa mã giảm thành công", "Thông báo");
                    LoadDiscountGirdLoad();
                }
                else
                    XtraMessageBox.Show("Xóa danh mục thất bại\nDanh mục được xóa phải rỗng", "Lỗi");
            }
            btnRemove.Enabled = false;
        }

        private void gcDiscount_DoubleClick(object sender, EventArgs e)
        {
            if (gvDiscount.FocusedRowHandle >= 0)
                btnRemove.Enabled = true;
        }
    }
}