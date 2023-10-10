using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;


using BUS;
using DTO;
using System.IO;
using System.Drawing;
using MimeKit;
using System.Net.Mail;
using System.Threading.Tasks;
using MailKit.Security;
using System.Net.Http;
using System.Text;

namespace GUI
{
    public partial class fMain : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton currentClickButton = new SimpleButton();
        private Account loginAccount { get; set; }
        public fMain(Account acc)
        {
            InitializeComponent();
            loginAccount = acc;
            currentClickButton = null;
            btnGopBan.Enabled = false;
            btnChuyenBan.Enabled = false;
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadTable();
            LoadCategory();
            LoadLookUpEditTable();
            SplashScreenManager.CloseForm();
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
        void LoadTypeFood()
        {
            //lkedPickType.Properties.AllowUpdatePopupWidth=
        }
        private void LoadLookUpEditTable()
        {
            lkedPickTable.Properties.DataSource = TableBUS.Instance.GetTableList();
            lkedPickTable.Properties.DisplayMember = "Name";
            lkedPickTable.Properties.ValueMember = "ID";
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

        void btn_Click(object sender, EventArgs e)
        {
            if ((sender as SimpleButton) != currentClickButton)
            {
                if (currentClickButton != null)
                {
                    if ((currentClickButton.Tag as Table).Status == "Có người")
                    {
                        currentClickButton.ImageIndex = 0;
                        lbStatus.Text = "Có người";
                    }
                    else
                    {
                        currentClickButton.ImageIndex = -1;
                        lbStatus.Text = "Sẵn sàng";
                    }
                }
            }

            (sender as SimpleButton).ImageIndex = 1;
            int tableID = ((sender as SimpleButton).Tag as Table).ID;
            lbNumberTb.Text = tableID.ToString();
            lsvBill.Tag = (sender as SimpleButton).Tag;
            ShowBill(tableID);
            currentClickButton = sender as SimpleButton;
            btnChuyenBan.Enabled = true;
            btnGopBan.Enabled = true;
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
        void GetListTypeByCategory(int categoryID)
        {
            lkedPickType.Properties.DataSource = TypeFoodBUS.Instance.GetAllTypeFoodByIdCategoryID(categoryID);
            lkedPickType.Properties.DisplayMember = "Name";
            lkedPickType.Properties.ValueMember = "Id";
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

        private void btnChangeTable_Click(object sender, EventArgs e)
        {

        }


        private static MimeMessage CreateMimeMessageExportToPdfe(MemoryStream stream)
        {
            // Instantiate a report. 
            // Email export options are already specified at design time.                
            XtraReport report = new XtraReport();

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Someone", "nhamngoinfo@gmail.com"));
            message.To.Add(new MailboxAddress(report.ExportOptions.Email.RecipientName,
                report.ExportOptions.Email.RecipientAddress));
            message.Subject = report.ExportOptions.Email.Subject;
            var builder = new BodyBuilder();
            builder.TextBody = "This is a test e-mail message sent by an application.";
            // Create a new attachment and add the PDF document.
            report.ExportToPdf(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            builder.Attachments.Add("TestReport.pdf", stream.ToArray(), new ContentType("application", "pdf"));
            message.Body = builder.ToMessageBody();
            return message;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;//lấy ra id table
            if (table == null)
                return;

            int billID = -1;
            try
            {
                billID = BillBUS.Instance.GetUnCheckBillIDByTableID(table.ID);//kiểm tra bàn đã có bill hay chưa
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }

            int discount = NumDiscount; //mã giảm giá
            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]) * 1000;//lấy sos tiền hóa đơn
            double finalPrice = totalPrice - (totalPrice / 100) * discount;//tính sosos tiền được giảm
            if (billID != -1)
            {
                if (XtraMessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}?", table.Name),
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Print bill
                    List<TempBill> lstTempBill = new List<TempBill>();
                    try
                    {
                        lstTempBill = TempBillBUS.Instance.GetListTempBillByTableID(table.ID);//lấy ra nhưng món ăn trong bill đó
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Error: " + ex);
                    }

                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    XtraReport report = new XtraReport();
                    report.DataSource = lstTempBill;
                    report.Parameters["TableName"].Value = table.ID;//chuyền paramenter vào report
                    report.Parameters["Discount"].Value = discount;//chuyền paramenter vào report
                    report.Parameters["CreateDate"].Value = DateTime.Now;//chuyền paramenter vào report
                    report.Parameters["TotalPrice"].Value = finalPrice;//chuyền paramenter vào report
                    report.Parameters["NameStaff"].Value = loginAccount.DisplayName;//chuyền paramenter vào report
                    report.Parameters["Discount"].Value = NumDiscount;//chuyền paramenter vào report
                    ReportPrintTool tool = new ReportPrintTool(report);//khợi tạo rồi show lên
                    tool.ShowPreview();//show lên
                    SplashScreenManager.CloseForm();
                    // Save bill to database
                    report.PrintingSystem.AfterBuildPages += PrintingSystem_AfterBuildPages;

                }
            }
        }

        private async void PrintingSystem_AfterBuildPages(object sender, EventArgs e)
        {
            int discount = NumDiscount; //mã giảm giá
            Table table = lsvBill.Tag as Table;//lấy ra id table
            int billID = BillBUS.Instance.GetUnCheckBillIDByTableID(table.ID);//kiểm tra bàn đã có bill hay chưa
            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]) * 1000;//lấy sos tiền hóa đơn
            double finalPrice = totalPrice - (totalPrice / 100) * discount;//tính sosos tiền được giảm
            BillBUS.Instance.CheckOut(billID, discount, (int)finalPrice);//chuyển giảm giá và tổng tiền để lưu vào csdl nhằm mục sự dung cho sau này
            string botToken = "6491672688:AAFsnvJcdDuQH-MikAw91VrnFGlRBkp07xU";
            long chatId = -4054499094;
            string messageText = $"Có hóa đơn mới: {billID} \nSố tiền: {totalPrice}\nGiảm giá: {discount}\nSố tiền trả: {finalPrice}\nNhân viên: {loginAccount.DisplayName}\nNgày giờ: {DateTime.Now.ToString("dd/mm/yyyyy hh:mm:ss")}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = $"https://api.telegram.org/bot{botToken}/sendMessage";
                    var content = new StringContent($"{{\"chat_id\": \"{chatId}\", \"text\": \"{messageText}\"}}", Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            ShowBill(table.ID);
            LoadTable();
            LoadLookUpEditTable();
        }

        private void fMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadTable();
                LoadCategory();
                LoadLookUpEditTable();
                SplashScreenManager.CloseForm();
            }
        }


        private void btnBillardTable_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lsvBill.FocusedItem.Text);
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                XtraMessageBox.Show("Hãy chọn bàn");
                return;
            }

            if (spAmount.Value == 0)
                return;
            int amount = (int)spAmount.Value;

            int billID = BillBUS.Instance.GetUnCheckBillIDByTableID(table.ID);
            string FoodName = lsvBill.FocusedItem.Text.ToString();
            if (string.IsNullOrEmpty(FoodName))
            {
                XtraMessageBox.Show("Hãy chọn món");
                return;
            }
            else
            {
                if (XtraMessageBox.Show(string.Format("Bạn có thật sự muốn xóa món {0} số lượng {1} ra khỏi bill {2}?",
               FoodName, amount, billID), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        BillInfoBUS.Instance.DeleteFoodBillInfo(billID, FoodName, amount);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Eror: " + ex);
                    }
                }
            }
            ShowBill(table.ID);
            LoadTable();
            LoadLookUpEditTable();
        }
        static int NumDiscount = 0;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int num = DiscountBUS.Instance.GetUnCheckBillIDByTableID(txtCodeDisscount.Text);
            if (num > 0)
            {
                XtraMessageBox.Show(String.Format("Được giảm {0} %", num), "Thông báo");
                NumDiscount = num;
            }
            else
            {
                XtraMessageBox.Show(String.Format("Mã giảm giá không tồn tại hoặc đã hết hạn"), "Thông báo");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lsvBill.FocusedItem.Text);
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                XtraMessageBox.Show("Hãy chọn bàn");
                return;
            }

            if (spAmount.Value == 0)
                return;
            int amount = (int)spAmount.Value;

            int billID = BillBUS.Instance.GetUnCheckBillIDByTableID(table.ID);
            string FoodName = lsvBill.FocusedItem.Text.ToString();
            if (string.IsNullOrEmpty(FoodName))
            {
                XtraMessageBox.Show("Hãy chọn món");
                return;
            }
            else
            {
                if (XtraMessageBox.Show(string.Format("Bạn có thật sự muốn xóa món {0} số lượng {1} ra khỏi bill {2}?",
               FoodName, amount, billID), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        BillInfoBUS.Instance.DeleteFoodBillInfo(billID, FoodName, amount);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Eror: " + ex);
                    }
                }
            }
            ShowBill(table.ID);
            LoadTable();
            LoadLookUpEditTable();
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
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

        private void btnChuyenBan_Click(object sender, EventArgs e)
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

            if (XtraMessageBox.Show(string.Format("Bạn có thật sự muốn chuyển {0} sang {1}?",
                (lsvBill.Tag as Table).Name, lkedPickTable.Text),
                "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableBUS.Instance.SwitchTable(id1, id2);
                LoadTable();
                LoadLookUpEditTable();
                btnChuyenBan.Enabled = false;
                btnGopBan.Enabled = false;
                foreach (SimpleButton item in flpListTable.Controls)
                    if ((item.Tag as Table).ID == id2)
                    {
                        lsvBill.Tag = item.Tag;
                        break;
                    }
            }
        }

        private void btnGopBan_Click(object sender, EventArgs e)
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
                btnGopBan.Enabled = false;
                foreach (SimpleButton item in flpListTable.Controls)
                    if ((item.Tag as Table).ID == id2)
                    {
                        lsvBill.Tag = item.Tag;
                        break;
                    }
            }
        }

        private void lkedPickFood_EditValueChanged(object sender, EventArgs e)
        {
            Food a = FoodBUS.Instance.GetFoodByID((int)lkedPickFood.EditValue);
            string resourcesDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", a.Image + ".jpg");
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
    }
}