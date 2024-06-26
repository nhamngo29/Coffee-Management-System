﻿using System;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class fAddTable : DevExpress.XtraEditors.XtraForm
    {
        public int Table { get; set; }

        public fAddTable()
        {
            InitializeComponent();
            this.FormClosing += FAddTable_FormClosing;
        }

        private void FAddTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTable.Text == "")
                Table = -1;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtTable.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập dữ liệu!!");
                return;
            }

            int temp;
            if (int.TryParse(txtTable.Text, out temp) == false)
            {
                XtraMessageBox.Show("Dữ liệu không hợp lệ!!");
                txtTable.Focus();
                return;
            }
            else
            {
               
                    Table = temp;
                    this.Close();
            }
        }

        
    }
}