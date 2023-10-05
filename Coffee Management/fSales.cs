using System;
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
using System.IO;
using System.Reflection;
using static DevExpress.Skins.SolidColorHelper;
using DevExpress.XtraWaitForm;

namespace Coffee_Management
{
    public partial class fSales : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton currentClickButton = new SimpleButton();
        public fSales()
        {
            InitializeComponent();
            currentClickButton = null;
            btnChangeTable.Enabled = false;
            btnBillardTable.Enabled = false;
            SplashScreenManager.ShowForm(typeof(fSplah));
            SplashScreenManager.CloseForm();
            this.Load += F_Load;
        }

        private void F_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadCategory();
            LoadLookUpEditTable();
        }

        private void LoadTable()
        {
            flpListTable.Controls.Clear();
            List<Table> tableList = TableBUS.Instance.GetTableList();

            foreach (Table item in tableList)
            {
                SimpleButton button = new SimpleButton() { Width = 80, Height = 80 };
                button.Text = item.Name;
                button.Click += Button_Click; ;
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

        private void Button_Click(object sender, EventArgs e)
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
            lbNumberTb.Text = tableID.ToString();
            lbStatus.Text = ((sender as SimpleButton).Tag as Table).Status;
            ShowBill(tableID);
            currentClickButton = sender as SimpleButton;
            btnChangeTable.Enabled = true;
            btnBillardTable.Enabled = true;
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
            Food a = FoodBUS.Instance.GetFoodByID((int)lkedPickFood.EditValue);
            string resourcesDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", a.Image+".jpg");
            if (File.Exists(resourcesDirectory))
            {
                try
                {
                    // Đọc tệp hình ảnh
                    using (var imageStream = File.OpenRead(resourcesDirectory))
                    {
                        Image image = Image.FromStream(imageStream);
                        pbxBox.Image = image;
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi khi đọc tệp hình ảnh.
                    Console.WriteLine("Lỗi khi đọc tệp hình ảnh: " + ex.Message);
                }
               
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;//lấy bàn 
            if (table == null)//kiểm tra chọn
            {
                XtraMessageBox.Show("Hãy chọn bàn");
                return;
            }
            if (spAmount.Value == 0)//kiểm số luowjgn thêm nếu như 0 thì không đươhjc thêm
                return;
            int amount = (int)spAmount.Value;//số lượng thêm
            int billID = BillBUS.Instance.GetUnCheckBillIDByTableID(table.ID);//lấy id bill và kiểm tra đã có bill hay chưa
            if (lkedPickFood.EditValue == null)//kiểm tra món chọn
            {
                XtraMessageBox.Show("Hãy chọn món");
                return;
            }
            int foodID = (int)lkedPickFood.EditValue;//id của món chọn
            if (billID == -1)//bill mới
            {
                try
                {
                    BillBUS.Instance.InsertBill(table.ID);//thêm bill mới
                    BillInfoBUS.Instance.InsertBillInfo(BillBUS.Instance.GetMaxBillID(), foodID, amount);//thêm chi tiết hoa đơn
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex);
                }
            }
            else//bill cũ
            {
                try
                {
                    BillInfoBUS.Instance.InsertBillInfo(billID, foodID, amount);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Eror: " + ex);
                }
            }
            ShowBill(table.ID);//show ra bill
            LoadTable();
            LoadLookUpEditTable();
        }
        private void ShowBill(int tableID)
        {
            lsvBill.Items.Clear();
            List<TempBill> listTempBill = new List<TempBill>();
            try
            {
                listTempBill = TempBillBUS.Instance.GetListTempBillByTableID(tableID);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }

            int totalPrice = 0;
            foreach (TempBill item in listTempBill)
            {
                ListViewItem lsvItem = new ListViewItem(item.Food.ToString());
                lsvItem.SubItems.Add(item.AmountFood.ToString());
                lsvItem.SubItems.Add(string.Format("{0:0,0 VND}", item.Price));
                lsvItem.SubItems.Add(string.Format("{0:0,0 VND}", item.Total));
                totalPrice += item.Total;
                lsvBill.Items.Add(lsvItem);
            }
            // Thread.CurrentThread.CurrentCulture = culture;
            txtTotalPrice.Text = string.Format("{0:0,0 VND}", totalPrice);
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;
            int id2;
            if (lkedPickTable.EditValue == null)
            {
                XtraMessageBox.Show("Hãy chọn bàn muốn chuyển");
                return;
            }
            else
                id2 = (int)lkedPickTable.EditValue;

            if(id2==id1)
            {
                XtraMessageBox.Show("Hãy 2 bàn phải khác nhau");
                return;
            }
            if (XtraMessageBox.Show(string.Format("Bạn có thật sự muốn chuyển {0} sang {1} ?",
                (lsvBill.Tag as Table).Name, lkedPickTable.Text),
                "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableBUS.Instance.SwitchTable(id1, id2);
                LoadTable();
                LoadLookUpEditTable();
                btnChangeTable.Enabled = false;
                btnBillardTable.Enabled = false;
                foreach (SimpleButton item in flpListTable.Controls)
                    if ((item.Tag as Table).ID == id2)
                    {
                        lsvBill.Tag = item.Tag;
                        break;
                    }
            }
        }

        private void btnBillardTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;
            int id2;
            if (lkedPickTable.EditValue == null)
            {
                XtraMessageBox.Show("Hãy chọn bàn muốn gộp");
                return;
            }
            else
                id2 = (int)lkedPickTable.EditValue;

            if (XtraMessageBox.Show(string.Format("Bạn có thật sự muốn gộp bàn {0} sang {1}?",
                (lsvBill.Tag as Table).Name, lkedPickTable.Text),
                "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableBUS.Instance.MergeTable(id1, id2);
                LoadTable();
                LoadLookUpEditTable();
                btnBillardTable.Enabled = false;
                foreach (SimpleButton item in flpListTable.Controls)
                    if ((item.Tag as Table).ID == id2)
                    {
                        lsvBill.Tag = item.Tag;
                        break;
                    }
            }
        }
    }
}