using BUS;
using DevExpress.XtraCharts;
using System;


namespace GUI
{
    public partial class fStatisticsImport : DevExpress.XtraEditors.XtraForm
    {
        Series series = new Series("Tổng tiền tháng", ViewType.Bar);
        public fStatisticsImport()
        {
            InitializeComponent();
            this.Load += fStatistics_Load;
        }
        private void fStatistics_Load(object sender, EventArgs e)
        {
            spinEdit1.Properties.MaxValue = DateTime.Now.Year;

            performent(2023);
        }
        void performent(int nam)
        {
            chartControl1.Series.Clear();
            series.Points.Add(new SeriesPoint("Tháng 1", ImportBUS.Instance.TotalAmountByMothAndYear(nam, 1)));
            series.Points.Add(new SeriesPoint("Tháng 2", ImportBUS.Instance.TotalAmountByMothAndYear(nam, 2)));
            series.Points.Add(new SeriesPoint("Tháng 3", ImportBUS.Instance.TotalAmountByMothAndYear(nam, 3)));
            series.Points.Add(new SeriesPoint("Tháng 4", ImportBUS.Instance.TotalAmountByMothAndYear(nam, 4)));
            series.Points.Add(new SeriesPoint("Tháng 5", ImportBUS.Instance.TotalAmountByMothAndYear(nam, 5)));
            series.Points.Add(new SeriesPoint("Tháng 6", ImportBUS.Instance.TotalAmountByMothAndYear(nam, 6)));
            series.Points.Add(new SeriesPoint("Tháng 7", ImportBUS.Instance.TotalAmountByMothAndYear(nam, 7)));
            series.Points.Add(new SeriesPoint("Tháng 8", ImportBUS.Instance.TotalAmountByMothAndYear(nam, 8)));
            series.Points.Add(new SeriesPoint("Tháng 9", ImportBUS.Instance.TotalAmountByMothAndYear(nam, 9)));
            series.Points.Add(new SeriesPoint("Tháng 10",ImportBUS.Instance.TotalAmountByMothAndYear(nam, 10)));
            series.Points.Add(new SeriesPoint("Tháng 11",ImportBUS.Instance.TotalAmountByMothAndYear(nam, 11)));
            series.Points.Add(new SeriesPoint("Tháng 12", ImportBUS.Instance.TotalAmountByMothAndYear(nam, 12)));
            chartControl1.Series.Add(series);
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            performent(int.Parse(spinEdit1.Text));
        }

        private void fStatisticsImport_Load(object sender, EventArgs e)
        {

        }
    }
}