using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraSplashScreen;

namespace GUI
{
    public partial class fReservation : DevExpress.XtraEditors.XtraForm
    {
        Account acc;
        Staff staff;
        public fReservation(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
            staff = StaffBUS.Instance.GetByID(acc.IdStaff);
            this.Load += fReservation_Load;
            gridView1.CellValueChanging += GridView1_CellValueChanging;
        }

       

        private void bookingDKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingDKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }

        private void fillDKToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookingDKTableAdapter1.FillDK(this.coffeeDataSet1.BookingDK, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(deFromDate.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(deToDate.DateTime, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fReservation_Load(object sender, EventArgs e)
        {
            deToDate.DateTime = DateTime.Now.AddMonths(1);
            btnShowBill.PerformClick();
            gridView1.RowCellClick += GridView1_RowCellClick;
        }

        private void GridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            XtraMessageBox.Show("Đã tích " + e.Column.AbsoluteIndex);
            if (e.Column.VisibleIndex == 7 || e.Column.AbsoluteIndex==7)
            {
               
                bool isChecked = (bool)gridView1.GetRowCellValue(e.RowHandle, e.Column);
                if (isChecked)
                {
                    XtraMessageBox.Show("Đã tích");
                }    
                else
                {
                    XtraMessageBox.Show("Bỏ tích");
                }    
            }
        }

        private void deToDate_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bookingDKBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingDKBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.coffeeDataSet1);
            //try
            //{
            //    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            //    smtpClient.Port = 587;
            //    smtpClient.Credentials = new NetworkCredential("nhamngoinfo@gmail.com", "kdfd cgix gbew cosz");

            //    // Tạo đối tượng MailMessage
            //    MailMessage mail = new MailMessage();
            //    mail.From = new MailAddress("nhamngoinfo@gmail.com");
            //    mail.To.Add("nhamngooinfo@gmail.com"); // Địa chỉ email người nhận
            //    mail.Subject = "Xác nhân thông tin đặt bàn.";
            //    mail.Body = "Nội dung email";

            //    // Gửi email
            //    smtpClient.Send(mail);

            //    Console.WriteLine("Email đã được gửi thành công!");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Lỗi: ");
            //}
            
        }

        private void fillDKToolStripButton_Click_1(object sender, EventArgs e)
        {
            

        }

        private void gridView1_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            XtraMessageBox.Show("Đã tích " + e.Column.AbsoluteIndex);
        }
        private void GridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colConfirm)
            {

                bool isChecked = (bool)gridView1.GetRowCellValue(e.RowHandle, e.Column);
                string Fullname = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[1]).ToString();
                string Email = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[2]).ToString();
                string NumberPhone = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[3]).ToString();
                string Quantity = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[4]).ToString();
                string Time = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[5]).ToString();

                if (isChecked)
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    MailAddress myemail = new MailAddress("nhamngoinfo@gmail.com", "Coffee Z");
                    MailAddress mail_to = new MailAddress(Email, Fullname);

                    string password = "kdfd cgix gbew cosz";

                    SmtpClient client_smtp = new SmtpClient("smtp.gmail.com", 587);
                    client_smtp.EnableSsl = true;
                    client_smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client_smtp.UseDefaultCredentials = false;
                    client_smtp.Credentials = new NetworkCredential(myemail.Address, password);

                    MailMessage message = new MailMessage(myemail, mail_to);
                    message.Subject = "Xác Nhận Đơn Đặt Bàn tại Quán Cà Phê Coffee Z";
                    string body = $"Chào quý khách hàng thân mến,\n\n" +
                        $"Chúng tôi xin trân trọng thông báo rằng đơn đặt bàn của quý khách tại Quán Cà Phê Coffee Z đã được xác nhận thành công. Chúng tôi rất hân hạnh được phục vụ quý khách vào ngày và giờ như sau:\n\n" +
                        $"Ngày và giờ: {Time}\n" +
                        $"Số lượng người: {Quantity}\n" +
                        $"Số diện thoại đặt bàn: {NumberPhone}\n" +
                        $"Tên của quý khách: {Fullname}\n\n" +
                        $"Chúng tôi luôn cam kết cung cấp dịch vụ tốt nhất và không ngừng nỗ lực để mang đến trải nghiệm đáng nhớ tại Quán Cà Phê Coffee Z. Chúng tôi rất mong được chào đón quý khách và đảm bảo rằng bạn sẽ có một thời gian tuyệt vời tại quán của chúng tôi.\n\n" +
                        $"Nếu có bất kỳ câu hỏi hoặc yêu cầu nào thêm, vui lòng liên hệ với chúng tôi qua số điện thoại: 0779442612 hoặc email: nhamngooinfo@gmail.com.\n\n" +
                        $"Chúng tôi xin chân thành cảm ơn quý khách đã chọn Quán Cà Phê Coffee Z cho buổi gặp mặt đặc biệt của mình. Rất mong sớm được phục vụ quý khách!\n\n" +
                        $"Trân trọng\n" +
                        $"{staff.Name}\n" +
                        $"Giờ xác nhận {DateTime.Now}\n" +
                        $"Quán Cà Phê Coffee Z\n140 Lê Trọng Tấn, Phương Tây Thạnh, Q.Tân Phú, TP.HCM";



                    message.Body = body;


                    try
                    {
                        client_smtp.Send(message);
                        SplashScreenManager.CloseForm();
                        XtraMessageBox.Show("Đơn hàng đã được gửi xác nhân đến email của khách hàng");
                        bookingDKBindingNavigatorSaveItem.PerformClick();

                    }
                    catch (Exception ex)
                    {
                        SplashScreenManager.CloseForm();
                        Console.WriteLine("Lỗi: ");
                    }

                }
            }
        }

        private void bookingDKGridControl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}