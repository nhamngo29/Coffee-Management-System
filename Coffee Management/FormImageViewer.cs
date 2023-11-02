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

namespace GUI
{
    public partial class FormImageViewer : DevExpress.XtraEditors.XtraForm
    {
        public FormImageViewer()
        {
            InitializeComponent();
        }
        public FormImageViewer(string imagePath)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(imagePath);
        }
        private void FormImageViewer_Load(object sender, EventArgs e)
        {

        }
    }
}