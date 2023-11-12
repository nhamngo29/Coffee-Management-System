﻿using BUS;
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
    public partial class fImport : DevExpress.XtraEditors.XtraForm
    {
        public fImport()
        {
            InitializeComponent();
        }

        private void Import_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            gcImport.DataSource = ImportBUS.Instance.GetAll();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddImportProduct addImportProduct = new AddImportProduct();
            addImportProduct.ShowDialog();
        }
    }
}