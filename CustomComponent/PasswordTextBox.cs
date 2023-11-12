using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomComponent
{
    
    public class PasswordTextBox : TextBox
    {
        private bool isValid = false;

        public PasswordTextBox()
        {
            this.TextChanged += PasswordTextBox_TextChanged;
        }

        
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            var regexItem = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*\W).{6,}$");
            string st = this.Text;

            if (!regexItem.IsMatch(st))
            {
                errorProvider.SetError(this, "Mật khẩu phải bao gồm chữ hoa, thường, số và ký tự đặt biệt !");
                isValid = false;
                this.Focus();
            }
            else
            {
                errorProvider.Clear();
                isValid = true;
            }
        }

        private ErrorProvider errorProvider = new ErrorProvider();
    }


}
