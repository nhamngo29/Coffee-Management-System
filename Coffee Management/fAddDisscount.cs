using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;
namespace GUI
{
    public partial class fAddDisscount : DevExpress.XtraEditors.XtraForm
    {
        public fAddDisscount()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (DiscountBUS.Instance.Insert((int)numericUpDown2.Value,(int)numericUpDown1.Value))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công vui lòng thử lại");
                }    
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void fAddDisscount_Load(object sender, EventArgs e)
        {

        }
    }
}