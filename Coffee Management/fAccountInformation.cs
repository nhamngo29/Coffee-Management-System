using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

using DTO;
using BUS;
using System.Security.Cryptography;

namespace GUI
{
    public partial class fAccountInformation : DevExpress.XtraEditors.XtraForm
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public fAccountInformation(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
        }
        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }
            //str_md5=str_md5.Reverse().ToString();
            return str_md5;
        }
        private void UpdateAccount()
        {
            string displayName = txtDisplayName.Text;
            string password = GetMD5(txtPassword.Text);
            string newPass = txtNewPassword.Text;
            string retypePass = txtRetypePass.Text;
            string userName = txtUserName.Text;

            if (!newPass.Equals(retypePass))
                MessageBox.Show("Mật khẩu nhập lại không đúng");
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                newPass = GetMD5(newPass);
                if (AccountBUS.Instance.UpdateInformationAcc(userName, displayName, password, newPass))
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            if (LoginAccount.Password == "C4CA4238A0B923820DCC509A6F75849B")
            {
                XtraMessageBox.Show("Nhằm đảm bảo bảo mật bạn cần đặt mất khẩu mới trước khi thoát");
            }
            else
            {
                this.Close();
            }
        }

        private void fAccountInformation_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
            txtNewPassword.Text = string.Empty;
            txtRetypePass.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            if (LoginAccount.Password == "C4CA4238A0B923820DCC509A6F75849B")
            {
                XtraMessageBox.Show("Nhằm đảm bảo bảo mật bạn cần đặt mất khẩu mới trước khi thoát");
            }
            else
            {
                this.Close();
            }
        }
    }
}