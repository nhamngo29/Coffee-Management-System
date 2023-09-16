using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coffee_Management
{
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        private Form CheckFormExist(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.None;
            IsMdiContainer = true;
            Form frm = this.CheckFormExist(typeof(fSales));

            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fSales f = new fSales();
                f.MaximizeBox = true;
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}
