﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using BUS;
using DTO;
using DevExpress.XtraPrinting;
using System.Drawing;

namespace Coffee_Management
{
    public partial class f : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton currentClickButton = new SimpleButton();
        public f()
        {
            InitializeComponent();
            currentClickButton = null;
            this.Load += F_Load;
        }

        private void F_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadCategory();
        }

        private void LoadTable()
        {
            flpListTable.Controls.Clear();
            List<Table> tableList = TableBUS.Instance.GetTableList();

            foreach (Table item in tableList)
            {
                SimpleButton button = new SimpleButton() { Width = 80, Height = 80 };
                button.Text = item.Name;
                button.Click += btn_Click;
                button.Tag = item;
                button.ImageList = imageList;

                switch (item.Status)
                {
                    case "Có người":
                        button.ImageIndex = 0;
                        break;
                    default:
                        break;
                }
                flpListTable.Controls.Add(button);
            }
        }
        private void LoadCategory()
        {
            lkedPickCategory.Properties.DataSource = CategoryBUS.Instance.GetAllCategory();
            lkedPickCategory.Properties.DisplayMember = "Name";
            lkedPickCategory.Properties.ValueMember = "ID";
        }
        private void LoadLookUpEditTable()
        {
            lkedPickTable.Properties.DataSource = TableBUS.Instance.GetTableList();
            lkedPickTable.Properties.DisplayMember = "Name";
            lkedPickTable.Properties.ValueMember = "ID";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((sender as SimpleButton) != currentClickButton)
            {
                if (currentClickButton != null)
                {
                    if ((currentClickButton.Tag as Table).Status == "Có người")
                        currentClickButton.ImageIndex = 0;
                    else
                        currentClickButton.ImageIndex = -1;
                }
            }

            (sender as SimpleButton).ImageIndex = 1;
            int tableID = ((sender as SimpleButton).Tag as Table).ID;
            lsvBill.Tag = (sender as SimpleButton).Tag;
            //ShowBill(tableID);
            currentClickButton = sender as SimpleButton;
            btnChangeTable.Enabled = true;
            btnBillardTable.Enabled = true;
        }
        void GetListTypeByCategory(int categoryID)
        {
            lkedPickType.Properties.DataSource = TypeFoodBUS.Instance.GetAllTypeFoodByIdCategoryID(categoryID);
            lkedPickType.Properties.DisplayMember = "Name";
            lkedPickType.Properties.ValueMember = "Id";
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lkedPickCategory_EditValueChanged(object sender, EventArgs e)
        {
            int id = (int)lkedPickCategory.EditValue;
            GetListTypeByCategory(id);
        }

        private void lkedPickType_EditValueChanged(object sender, EventArgs e)
        {
            int id = (int)lkedPickType.EditValue;
            GetListFoodByType(id);
        }
        private void GetListFoodByType(int Type)
        {
            lkedPickFood.Properties.DataSource = FoodBUS.Instance.GetListFoodByCategoryID(Type);
            lkedPickFood.Properties.DisplayMember = "Name";
            lkedPickFood.Properties.ValueMember = "ID";
        }

        private void grBanAn_Enter(object sender, EventArgs e)
        {

        }
        void loadImage()
        {

        }
        private void lkedPickFood_EditValueChanged(object sender, EventArgs e)
        {
            Food a= FoodBUS.Instance.GetFoodByID((int)lkedPickFood.EditValue);
            pbxBox.Image = Image.FromFile($@"D:\Learn\PhanTrienPhanMemUngDungThongMinh\Desktop\Coffee Management\Coffee Management\Resources\{a.Image}.jpg");
        }
    }
}