using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using System.IO;
using DevExpress.LookAndFeel;

using DTO;
using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;

namespace GUI
{
    public partial class fManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static int countBooking = 0;
        public Account loginAccount;
        List<Decentralization> lDecentralization = new List<Decentralization>();
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; DisplayAccount(loginAccount.TypeID); }//Loại tài khonar của admin sẽ là 1 
        }

        public fManager(Account loginAccount)
        {
            SplashScreenManager.ShowForm(typeof(SplashScreen1));
            InitializeComponent();

            this.LoginAccount = loginAccount;
            lDecentralization = DecentralizationBUS.Instance.GetDecentralizationByUser(loginAccount.UserName);
            LoadManHinh();
        }
        void LoadManHinh()
        {
            foreach (Decentralization item in lDecentralization)
            {
                switch (item.IDRole)
                {
                    case 1:
                        ribbonPageManager.Visible = true;
                        CheckAllChildVisible(this.ribbonPageManager, item.IDScreen, item.Visible);
                        break;
                    case 2:
                        break;
                    case 3:
                        ribbonPageManager.Visible = true;
                        ribbonPage1.Visible= true;
                        CheckAllChildVisible(this.ribbonPageManager, item.IDScreen, item.Visible);
                        CheckAllChildVisible(this.ribbonPage1, item.IDScreen, item.Visible);
                        break;
                    case 4:
                        ribbonPage1.Visible = true;
                        CheckAllChildVisible(this.ribbonPage1, item.IDScreen, item.Visible);
                        break;
                }
            }
        }

        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;

        }
        private void CheckAllChildVisible(RibbonPage mnuItems, string Screen, bool Visible)
        {
            foreach (RibbonPageGroup group in mnuItems.Groups)
            {
                foreach (BarItemLink link in group.ItemLinks)
                {
                    if (link.Item is BarButtonItem)
                    {
                        if (string.Equals(link.Item.Tag.ToString(), Screen))
                        {
                            link.Item.Enabled = Visible;
                            link.Item.Visibility = 0;
                            return;
                        }
                    }
                }
            }
        }
        private void fManager_Load(object sender, EventArgs e)
        {
            ribbonPageGroupSystem.Text = loginAccount.DisplayName;
            this.NhanVien.Text += loginAccount.DisplayName;
            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Start();
            barButtonItem6.PerformClick();
            SplashScreenManager.CloseForm();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.NgayGio.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void DisplayAccount(int type)//type này là loại account người qunar lý sẽ là 1 còn nhân viên khác 1
        {
           /* ribbonPageManager.Visible = type == 1;*/ // nếu đây là số một thì sẽ là true
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

        private void btnShowForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fMain));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fMain f = new fMain(LoginAccount);
                f.MdiParent = this;
                f.Show();
            }
        }



        private void btnAccountInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fAccountInformation));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fAccountInformation f = new fAccountInformation(loginAccount);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void btnViewFood_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form frm = this.CheckFormExist(typeof(fFood));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fFood f = new fFood();
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnViewCategoryFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fCategory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fCategory f = new fCategory();
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fGroupFood));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fGroupFood f = new fGroupFood();
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }
        private void btnViewTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fTable));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fTable f = new fTable();
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnViewAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fAccount));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fAccount f = new fAccount();
                f.LoginUserName = loginAccount.UserName;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnViewBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fBill));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fBill f = new fBill();
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnStatistic_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form frm = this.CheckFormExist(typeof(fStatistics));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fStatistics f = new fStatistics();
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }
        private void btnLog_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void fManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                fManager_Load(sender, e);
        }

        private void fManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            string fileName = "Skins.txt";
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.Close();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnViewDiscount_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fDiscount));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fDiscount f = new fDiscount();
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fReservation));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fReservation f = new fReservation(loginAccount);
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fStaff));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fStaff f = new fStaff();
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }




        private void btnNhapKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fImport));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fImport f = new fImport(loginAccount);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fStatisticsImport));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fStatisticsImport f = new fStatisticsImport();
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnMonitor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fScreen));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fScreen f = new fScreen();
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }
    }
}