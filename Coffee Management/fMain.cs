﻿using System;
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

            IsMdiContainer = true;
            Form frm = this.CheckFormExist(typeof(fSales));
            //Form frm=this.CheckFormExist(typeof(fAccountInformation));
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
            timer1.Start();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnDatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fReservation));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fReservation f = new fReservation();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.NgayGio.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}
