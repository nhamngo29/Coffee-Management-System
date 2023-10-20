using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.Drawing;
using System.Drawing.Printing;

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
            btnShowBill.PerformClick();

        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDateAndPage((DateTime)deFromDate.EditValue, (DateTime)deToDate.EditValue, int.Parse(txtNumPageBill.Text));
        }
        void LoadListBillByDateAndPage(DateTime fromDate, DateTime toDate, int pageNum)
        {
            try
            {
                gcBill.DataSource = BillBUS.Instance.LoadListBillByDateAndPage(fromDate, toDate, pageNum);
                gvBill.Columns[0].Caption = "Mã hóa đơn";
                gvBill.Columns[1].Caption = "Tên bàn";
                gvBill.Columns[2].Caption = "Ngày vào";
                gvBill.Columns[2].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gvBill.Columns[2].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
                gvBill.Columns[3].Caption = "Ngày ra";
                gvBill.Columns[3].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gvBill.Columns[3].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
                //gvBill.Columns[3].
                gvBill.Columns[4].Caption = "Giảm giá";
                gvBill.Columns[5].Caption = "Tổng tiền";
               
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
            if (sumRecord % 10 != 0)
            {
                lastPage++;
            }
            txtNumPageBill.Text = lastPage.ToString();
            btnFirstPage.Enabled = btnPreviours.Enabled = true;
            btnLastPage.Enabled = btnNext.Enabled = false;
        }

        private void txtNumPageBill_TextChanged(object sender, EventArgs e)
        {
            gcBill.DataSource = BillBUS.Instance.LoadListBillByDateAndPage((DateTime)deFromDate.EditValue, (DateTime)deToDate.EditValue, Convert.ToInt32(txtNumPageBill.Text));
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtNumPageBill.Text);
            if (page > 1)
                page--;
            else
            {
                btnFirstPage.Enabled = btnPreviours.Enabled = false;
                btnLastPage.Enabled = btnNext.Enabled = true;
            }
            txtNumPageBill.Text = page.ToString();
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
        private void exportButton_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExportEx_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = gcBill; // gridViewControl1 là tên của GridView của bạn

            // Tùy chỉnh trình xem in (Optional)
            link.CreateMarginalHeaderArea += (s, args) =>
            {
                args.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
                args.Graph.Font = new Font("Arial", 10, FontStyle.Bold);
            };

            link.Margins = new Margins(50, 50, 50, 50);
            link.Landscape = true;

            // Xuất dữ liệu ra file PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                link.ExportToPdf(saveFileDialog.FileName);
                MessageBox.Show("Dữ liệu đã được xuất ra file PDF.");
            }
        }

        private void gvBill_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "DateColumnFieldName") // Thay "DateColumnFieldName" bằng tên thực sự của cột bạn muốn định dạng
            {
                if (e.Value is DateTime date)
                {
                    // Định dạng giá trị của cột thành chuỗi "dd/MM/yyyy"
                    e.DisplayText = date.ToString("dd/MM/yyyy hh:mm:ss");
                }
            }
        }
    }
}