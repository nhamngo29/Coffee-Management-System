using BUS;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Design;
using DevExpress.XtraCharts.Designer;
using DevExpress.XtraEditors;
using NPOI.SS.Formula.Functions;
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
    public partial class fStatistics : DevExpress.XtraEditors.XtraForm
    {
        Series series = new Series("Tổng tiền tháng", ViewType.Bar);
        public fStatistics()
        {
            InitializeComponent();
        }

        private void fStatistics_Load(object sender, EventArgs e)
        {
            spinEdit1.Properties.MaxValue = DateTime.Now.Year;
            // TODO: This line of code loads data into the 'coffeeDataset1.DataTableSumBillByMonth' table. You can move, or remove it, as needed.
            this.dataTableSumBillByMonthTableAdapter.FillSumBillByMonth(this.coffeeDataset1.DataTableSumBillByMonth);
            // TODO: This line of code loads data into the 'coffeeDataset.DataTableSumBillByMonth' table. You can move, or remove it, as needed.
            this.dataTableSumBillByMonthTableAdapter.FillSumBillByMonth(this.coffeeDataset.DataTableSumBillByMonth);
            // TODO: This line of code loads data into the 'coffeeDataset.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.coffeeDataset.Bill);

            performent(2023);

        }
        void performent(int nam)
        {
            chartControl1.Series.Clear();
            series.Points.Add(new SeriesPoint("Tháng 1", BillBUS.Instance.TotalAmountByMothAndYear(nam, 1)));
            series.Points.Add(new SeriesPoint("Tháng 2", BillBUS.Instance.TotalAmountByMothAndYear(nam, 2)));
            series.Points.Add(new SeriesPoint("Tháng 3", BillBUS.Instance.TotalAmountByMothAndYear(nam, 3)));
            series.Points.Add(new SeriesPoint("Tháng 4", BillBUS.Instance.TotalAmountByMothAndYear(nam, 4)));
            series.Points.Add(new SeriesPoint("Tháng 5", BillBUS.Instance.TotalAmountByMothAndYear(nam, 5)));
            series.Points.Add(new SeriesPoint("Tháng 6", BillBUS.Instance.TotalAmountByMothAndYear(nam, 6)));
            series.Points.Add(new SeriesPoint("Tháng 7", BillBUS.Instance.TotalAmountByMothAndYear(nam, 7)));
            series.Points.Add(new SeriesPoint("Tháng 8", BillBUS.Instance.TotalAmountByMothAndYear(nam, 8)));
            series.Points.Add(new SeriesPoint("Tháng 9", BillBUS.Instance.TotalAmountByMothAndYear(nam, 9)));
            series.Points.Add(new SeriesPoint("Tháng 10", BillBUS.Instance.TotalAmountByMothAndYear(nam, 10)));
            series.Points.Add(new SeriesPoint("Tháng 11", BillBUS.Instance.TotalAmountByMothAndYear(nam, 11)));
            series.Points.Add(new SeriesPoint("Tháng 12", BillBUS.Instance.TotalAmountByMothAndYear(nam, 12)));
            chartControl1.Series.Add(series);
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            performent(int.Parse(spinEdit1.Text));
        }
    }
}