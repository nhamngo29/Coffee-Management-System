using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomComponent
{
    public class txtChuVaSo : TextBox
    {
        public txtChuVaSo()
        {
            this.KeyPress += TxtChuVaSo_KeyPress;
        }

        private void TxtChuVaSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // Từ chối ký tự đó
                e.Handled = true;
            }
        }
    }
}
