using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class fConfigure : DevExpress.XtraEditors.XtraForm
    {
        public fConfigure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void fConfigure_Load(object sender, EventArgs e)
        {

        }

        private void cboServer_DropDown(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            cboServer.DataSource = DAO.DataProvider.Instance.GetServerName();
            cboServer.DisplayMember = "ServerName";
            SplashScreenManager.CloseForm();
        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            cboDatabase.DataSource = DAO.DataProvider.Instance.GetDBName(cboServer.Text, txtUsername.Text, txtPassword.Text);
            cboDatabase.DisplayMember = "name";
        }

        private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            DAO.DataProvider.Instance.SaveConfig(cboServer.Text, txtUsername.Text, txtPassword.Text, cboDatabase.Text);
            XtraMessageBox.Show("Hoàn thành cấu hình", "Thông báo");
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}