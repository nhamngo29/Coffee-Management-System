﻿using DevExpress.XtraBars.Ribbon;
using DTO;
using LibrarySQL;
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
        Account acc { get; set; }
        public fMain()
        {
            acc = new Account("admin", "admin");
            InitializeComponent();
            this.acc = acc;
            this.NhanVien.Text += acc.DisplayName;
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
            this.SetStyle((ControlStyles)RibbonControlStyle.Office2019, true);
            this.LookAndFeel.SetSkinStyle("Office 2019 Colorful");
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

        private void btnDatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form frm = this.CheckFormExist(typeof(fReservation));
            //if (frm != null)
            //{
            //    frm.Activate();
            //}
            //else
            //{
            //    //fReservation f = new fReservation();
            //    f.MdiParent = this;
            //    f.Show();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.NgayGio.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            
        }

        private void btnRevenue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form frm = this.CheckFormExist(typeof(fReservation));
            //if (frm != null)
            //{
            //    frm.Activate();
            //}
            //else
            //{
            //    //fRevenue f = new fRevenue();
            //    f.MdiParent = this;
            //    f.Show();
            //}
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}
