using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

using BUS;

namespace GUI
{
    public partial class fBill : DevExpress.XtraEditors.XtraForm
    {

        public fBill()
        {
            InitializeComponent();
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            deFromDate.EditValue = new DateTime(today.Year, today.Month, 1);
            deToDate.EditValue = deFromDate.DateTime.AddMonths(1).AddDays(-1);
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadListBillByDateAndPage((DateTime)deFromDate.EditValue, (DateTime)deToDate.EditValue, int.Parse(txtNumPageBill.Text));
            SplashScreenManager.CloseForm();
        }

        void LoadListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                gcBill.DataSource = BillBUS.Instance.GetListBillByDate(fromDate, toDate);
                gvBill.Columns[0].Caption = "Mã hóa đơn";
                gvBill.Columns[1].Caption = "Tên bàn";
                gvBill.Columns[2].Caption = "Ngày vào";
                gvBill.Columns[3].Caption = "Giảm giá";
                gvBill.Columns[4].Caption = "Tổng tiền";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
        void LoadListBillByDateAndPage(DateTime fromDate, DateTime toDate,int pageNum)
        {
            try
            {
                gcBill.DataSource = BillBUS.Instance.LoadListBillByDateAndPage(fromDate, toDate, pageNum);
                gvBill.Columns[0].Caption = "Mã hóa đơn";
                gvBill.Columns[1].Caption = "Tên bàn";
                gvBill.Columns[2].Caption = "Ngày vào";
                gvBill.Columns[3].Caption = "Giảm giá";
                gvBill.Columns[4].Caption = "Tổng tiền";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            txtNumPageBill.Text = "1";
            btnFirstPage.Enabled = btnPreviours.Enabled = false;
            btnLastPage.Enabled = btnNext.Enabled = true;
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            DateTime fromDate = (DateTime)deFromDate.EditValue;
            DateTime toDate = (DateTime)deToDate.EditValue;
            int sumRecord = BillBUS.Instance.GetNumBillListByDateAndPage(fromDate, toDate);
            int lastPage = sumRecord / 10;
            if (sumRecord%10!=0)
            {
                lastPage++;
            }
            txtNumPageBill.Text=lastPage.ToString();
            btnFirstPage.Enabled = btnPreviours.Enabled = true;
            btnLastPage.Enabled = btnNext.Enabled = false;
        }

        private void txtNumPageBill_TextChanged(object sender, EventArgs e)
        {
            gcBill.DataSource = BillBUS.Instance.LoadListBillByDateAndPage((DateTime)deFromDate.EditValue, (DateTime)deToDate.EditValue,Convert.ToInt32(txtNumPageBill.Text));
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            int page=Convert.ToInt32(txtNumPageBill.Text);
            if (page > 1)
                page--;
            else
            {
                btnFirstPage.Enabled = btnPreviours.Enabled = false;
                btnLastPage.Enabled = btnNext.Enabled = true;
            }    
            txtNumPageBill.Text=page.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DateTime fromDate = (DateTime)deFromDate.EditValue;
            int page = Convert.ToInt32(txtNumPageBill.Text);
            DateTime toDate = (DateTime)deToDate.EditValue;
            int sumRecord = BillBUS.Instance.GetNumBillListByDateAndPage(fromDate, toDate);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
            {
                lastPage++;
            }
            if (page < lastPage)
                page++;
            else
            {
                btnFirstPage.Enabled = btnPreviours.Enabled = true;
                btnLastPage.Enabled = btnNext.Enabled = false;
            }    
            txtNumPageBill.Text = page.ToString();
        }
    }
}