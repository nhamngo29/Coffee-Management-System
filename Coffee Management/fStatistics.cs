using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DevExpress.XtraEditors;
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
        public fStatistics()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.billTableAdapter.FillBy(this.dataSet11.Bill);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fStatistics_Load(object sender, EventArgs e)
        {
            ThongKe rpt = new ThongKe();
            ParameterFieldDefinitions pFieldDefinitions = rpt.DataDefinition.ParameterFields;
            ParameterFieldDefinition pfdDate = pFieldDefinitions["Date"];
            ParameterDiscreteValue pdvdate = new ParameterDiscreteValue();
            pdvdate.Value = DateTime.Now;
            pfdDate.CurrentValues.Clear();
            pfdDate.CurrentValues.Add(pdvdate);
            pfdDate.ApplyCurrentValues(pfdDate.CurrentValues);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}