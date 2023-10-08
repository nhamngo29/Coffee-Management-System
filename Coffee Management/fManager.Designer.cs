﻿namespace GUI
{
    partial class fManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManager));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnShowForm = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnViewFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewCategoryFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewTable = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewBill = new DevExpress.XtraBars.BarButtonItem();
            this.btnStatistic = new DevExpress.XtraBars.BarButtonItem();
            this.bsTextDate = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnLog = new DevExpress.XtraBars.BarButtonItem();
            this.btnSendMail = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewDiscount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCateogry = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupStatictis = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.openFileDialogRestore = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.linqServerModeSource1 = new DevExpress.Data.Linq.LinqServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnShowForm,
            this.barSubItem1,
            this.btnViewFood,
            this.btnViewCategoryFood,
            this.btnViewTable,
            this.btnAccountInfo,
            this.btnLogOut,
            this.btnViewAccount,
            this.btnViewBill,
            this.btnStatistic,
            this.bsTextDate,
            this.ribbonGalleryBarItem1,
            this.btnBackup,
            this.btnRestore,
            this.btnLog,
            this.btnSendMail,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.btnViewDiscount,
            this.barButtonItem15,
            this.barButtonItem16});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 34;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage,
            this.ribbonPageManager});
            this.ribbon.Size = new System.Drawing.Size(1156, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // btnShowForm
            // 
            this.btnShowForm.Caption = "Tác vụ";
            this.btnShowForm.Id = 2;
            this.btnShowForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowForm.ImageOptions.Image")));
            this.btnShowForm.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShowForm.ImageOptions.LargeImage")));
            this.btnShowForm.LargeWidth = 75;
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowForm_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 3;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnViewFood
            // 
            this.btnViewFood.Caption = "Menu";
            this.btnViewFood.Id = 4;
            this.btnViewFood.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewFood.ImageOptions.Image")));
            this.btnViewFood.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewFood.ImageOptions.LargeImage")));
            this.btnViewFood.LargeWidth = 75;
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewFood_ItemClick);
            // 
            // btnViewCategoryFood
            // 
            this.btnViewCategoryFood.Caption = "Danh mục";
            this.btnViewCategoryFood.Id = 5;
            this.btnViewCategoryFood.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCategoryFood.ImageOptions.Image")));
            this.btnViewCategoryFood.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewCategoryFood.ImageOptions.LargeImage")));
            this.btnViewCategoryFood.LargeWidth = 75;
            this.btnViewCategoryFood.Name = "btnViewCategoryFood";
            this.btnViewCategoryFood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewCategoryFood_ItemClick);
            // 
            // btnViewTable
            // 
            this.btnViewTable.Caption = "Bàn";
            this.btnViewTable.Id = 6;
            this.btnViewTable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewTable.ImageOptions.Image")));
            this.btnViewTable.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewTable.ImageOptions.LargeImage")));
            this.btnViewTable.LargeWidth = 75;
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewTable_ItemClick);
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Caption = "Thông tin tài khoản";
            this.btnAccountInfo.Id = 7;
            this.btnAccountInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountInfo.ImageOptions.Image")));
            this.btnAccountInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAccountInfo.ImageOptions.LargeImage")));
            this.btnAccountInfo.LargeWidth = 75;
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccountInfo_ItemClick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 8;
            this.btnLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.Image")));
            this.btnLogOut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.LargeImage")));
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Caption = "Tài khoản";
            this.btnViewAccount.Id = 9;
            this.btnViewAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewAccount.ImageOptions.Image")));
            this.btnViewAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewAccount.ImageOptions.LargeImage")));
            this.btnViewAccount.LargeWidth = 75;
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewAccount_ItemClick);
            // 
            // btnViewBill
            // 
            this.btnViewBill.Caption = "Doanh thu";
            this.btnViewBill.Id = 10;
            this.btnViewBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewBill.ImageOptions.Image")));
            this.btnViewBill.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewBill.ImageOptions.LargeImage")));
            this.btnViewBill.LargeWidth = 75;
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewBill_ItemClick);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Caption = "Thống kê";
            this.btnStatistic.Id = 11;
            this.btnStatistic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistic.ImageOptions.Image")));
            this.btnStatistic.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStatistic.ImageOptions.LargeImage")));
            this.btnStatistic.LargeWidth = 75;
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStatistic_ItemClick);
            // 
            // bsTextDate
            // 
            this.bsTextDate.Caption = "barStaticItem1";
            this.bsTextDate.Id = 12;
            this.bsTextDate.Name = "bsTextDate";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 13;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // btnBackup
            // 
            this.btnBackup.Id = 18;
            this.btnBackup.Name = "btnBackup";
            // 
            // btnRestore
            // 
            this.btnRestore.Id = 19;
            this.btnRestore.Name = "btnRestore";
            // 
            // btnLog
            // 
            this.btnLog.Caption = "Nhật ký hệ thống";
            this.btnLog.Id = 16;
            this.btnLog.LargeWidth = 75;
            this.btnLog.Name = "btnLog";
            this.btnLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLog_ItemClick);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Id = 20;
            this.btnSendMail.Name = "btnSendMail";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Loại";
            this.barButtonItem1.Id = 21;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Tác vụ";
            this.barButtonItem2.Id = 22;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Tác vụ";
            this.barButtonItem6.Id = 23;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.LargeWidth = 75;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowForm_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Thông tin";
            this.barButtonItem7.Id = 24;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.LargeWidth = 75;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccountInfo_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Đăng xuất";
            this.barButtonItem8.Id = 25;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.LargeWidth = 75;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Menu";
            this.barButtonItem9.Id = 26;
            this.barButtonItem9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem9.ImageOptions.SvgImage")));
            this.barButtonItem9.LargeWidth = 75;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewFood_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Nhóm món ăn";
            this.barButtonItem10.Id = 27;
            this.barButtonItem10.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem10.ImageOptions.SvgImage")));
            this.barButtonItem10.LargeWidth = 75;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Thể loại";
            this.barButtonItem11.Id = 28;
            this.barButtonItem11.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem11.ImageOptions.SvgImage")));
            this.barButtonItem11.LargeWidth = 75;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewCategoryFood_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Bàn";
            this.barButtonItem12.Id = 29;
            this.barButtonItem12.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem12.ImageOptions.SvgImage")));
            this.barButtonItem12.LargeWidth = 75;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewTable_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Tài khoản";
            this.barButtonItem13.Id = 30;
            this.barButtonItem13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.Image")));
            this.barButtonItem13.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.LargeImage")));
            this.barButtonItem13.LargeWidth = 75;
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewAccount_ItemClick);
            // 
            // btnViewDiscount
            // 
            this.btnViewDiscount.Caption = "Mã giảm giá";
            this.btnViewDiscount.Id = 31;
            this.btnViewDiscount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDiscount.ImageOptions.Image")));
            this.btnViewDiscount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewDiscount.ImageOptions.LargeImage")));
            this.btnViewDiscount.LargeWidth = 75;
            this.btnViewDiscount.Name = "btnViewDiscount";
            this.btnViewDiscount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewDiscount_ItemClick);
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Doanh thu";
            this.barButtonItem15.Id = 32;
            this.barButtonItem15.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem15.ImageOptions.SvgImage")));
            this.barButtonItem15.LargeWidth = 75;
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewBill_ItemClick);
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Thông kê";
            this.barButtonItem16.Id = 33;
            this.barButtonItem16.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem16.ImageOptions.SvgImage")));
            this.barButtonItem16.LargeWidth = 75;
            this.barButtonItem16.Name = "barButtonItem16";
            this.barButtonItem16.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStatistic_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroupSystem});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức năng";
            // 
            // ribbonPageGroupSystem
            // 
            this.ribbonPageGroupSystem.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroupSystem.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroupSystem.Name = "ribbonPageGroupSystem";
            this.ribbonPageGroupSystem.Text = "Hệ thống";
            // 
            // ribbonPageManager
            // 
            this.ribbonPageManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCateogry,
            this.ribbonPageGroupStatictis});
            this.ribbonPageManager.Name = "ribbonPageManager";
            this.ribbonPageManager.Text = "Quản lý";
            // 
            // ribbonPageGroupCateogry
            // 
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.barButtonItem13);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewDiscount);
            this.ribbonPageGroupCateogry.Name = "ribbonPageGroupCateogry";
            this.ribbonPageGroupCateogry.Text = "Danh mục";
            // 
            // ribbonPageGroupStatictis
            // 
            this.ribbonPageGroupStatictis.ItemLinks.Add(this.barButtonItem15);
            this.ribbonPageGroupStatictis.ItemLinks.Add(this.barButtonItem16);
            this.ribbonPageGroupStatictis.Name = "ribbonPageGroupStatictis";
            this.ribbonPageGroupStatictis.Text = "Thống kê";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 620);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1156, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tác vụ";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.LargeWidth = 75;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Tác vụ";
            this.barButtonItem4.Id = 2;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.LargeWidth = 75;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Tác vụ";
            this.barButtonItem5.Id = 2;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.LargeWidth = 75;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 644);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("fManager.IconOptions.Icon")));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fManager.IconOptions.Image")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("fManager.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "fManager";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÝ QUÁN CAFE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fManager_FormClosing);
            this.Load += new System.EventHandler(this.fManager_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fManager_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqServerModeSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageManager;
        private DevExpress.XtraBars.BarButtonItem btnShowForm;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnViewFood;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCateogry;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStatictis;
        private DevExpress.XtraBars.BarButtonItem btnViewCategoryFood;
        private DevExpress.XtraBars.BarButtonItem btnViewTable;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem btnAccountInfo;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnViewAccount;
        private DevExpress.XtraBars.BarButtonItem btnViewBill;
        private DevExpress.XtraBars.BarButtonItem btnStatistic;
        private DevExpress.XtraBars.BarStaticItem bsTextDate;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
		private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
		private System.Windows.Forms.OpenFileDialog openFileDialogRestore;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraBars.BarButtonItem btnLog;
        private DevExpress.XtraBars.BarButtonItem btnSendMail;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.Data.Linq.LinqServerModeSource linqServerModeSource1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem btnViewDiscount;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
    }
}