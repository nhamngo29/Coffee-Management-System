using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomComponent
{
    public class CustomMessageBox : Form
    {
        private Button btnOK;
        private Button btnCancel;

        public CustomMessageBox(string message,string ok,string cannel)
        {
            InitializeComponents(message,ok,cannel);
        }

        private void InitializeComponents(string message, string ok, string cannel)
        {
            this.Text = "Thông báo";
            this.Size = new System.Drawing.Size(300, 150);

            Label lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.Location = new System.Drawing.Point(20, 20);
            lblMessage.Size = new System.Drawing.Size(260, 40);
            this.Controls.Add(lblMessage);

            btnOK = new Button();
            btnOK.Text =ok;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(50, 80);
            btnOK.Click += btnOK_Click;
            this.Controls.Add(btnOK);

            btnCancel = new Button();
            btnCancel.Text = cannel;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(150, 80);
            btnCancel.Click += btnCancel_Click;
            this.Controls.Add(btnCancel);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
    }
}
