using BUS;
using DAO;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Management
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        private string captchaText;
        public fLogin()
        {
            InitializeComponent();
            this.Load += FLogin_Load;
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtUserName.Focus();
            Reset();
        }

        private Bitmap drawImage(string txt, int w, int h)
        {
            w = w + 20;
            h = h + 20;
            Bitmap bt = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bt);
            SolidBrush sb = new SolidBrush(Color.White);
            g.FillRectangle(sb, 0, 0, bt.Width, bt.Height);
            System.Drawing.Font font = new System.Drawing.Font("Tahoma", 30);
            sb = new SolidBrush(Color.Blue);
            g.DrawString(txt, font, sb, bt.Width / 2 - (txt.Length / 2) * font.Size, (bt.Height / 2) - font.Size);
            // Tạo hiệu ứng cho captcha
            // vẽ dấu chấm
            int count = 0;
            Random rand = new Random();
            while (count < 800)
            {
                sb = new SolidBrush(Color.YellowGreen);
                g.FillEllipse(sb, rand.Next(0, bt.Width), rand.Next(0, bt.Height), 4, 2);
                count++;
            }
            count = 0;
            // vẽ đường gạch ngang
            while (count < 25)
            {
                g.DrawLine(new Pen(Color.Pink), rand.Next(0, bt.Width), rand.Next(0, bt.Height), rand.Next(0, bt.Width), rand.Next(0, bt.Height));
                count++;
            }
            // End tạo hiệu ứng
            return bt;
        }

        public String randomString()
        {
            Random rnd = new Random();
            int number = rnd.Next(10000, 99999);
            string text = md5(number.ToString());
            text = text.ToUpper();
            text = text.Substring(0, 6);
            return text;

        }
        private void Reset()
        {
            captchaText = this.randomString();
            txtCaptcha.Text = "";
            // vẽ captcha lên panel 1
            panel.BackgroundImage = drawImage(captchaText, panel.Width, panel.Height);
        }
        public static string md5(String data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }
        public static byte[] encryptData(String data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        private void fLogin_Load(object sender, EventArgs e)
        {
            Reset();
            this.StartPosition= FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(fSplah));
            Account account = new Account(txtUserName.Text, txtPassword.Text);
            SplashScreenManager.CloseForm();
            try
            {
                if (AccountDAO.Instance.CheckLogin(account))//kiểm tra đang nhập
                {
                    if (txtCaptcha.Text == captchaText)//kiểm tra mã captcha
                    {

                        Account acc = AccountBUS.Instance.GetAccountByUserName(account.UserName);//lấy account theo username
                        if (txtPassword.Text == "1")//mật khẩu nhập vào là một thì sẽ chuyển đến trang profile để đổi mật khẩu
                        {
                            fAccountInformation form = new fAccountInformation(acc);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            txtPassword.Text = string.Empty;
                            txtUserName.Text = string.Empty;
                            txtCaptcha.Text = string.Empty;
                            Program._fMain = new fMain();//chuyển đến trang manager
                            this.Hide();
                            Program._fMain.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn đã nhập sai mã captch");
                        txtCaptcha.Clear();
                        txtCaptcha.Focus();
                        Reset();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btnEyePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = !txtPassword.Properties.UseSystemPasswordChar;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                this.Close();
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void btnResertCaptch_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}