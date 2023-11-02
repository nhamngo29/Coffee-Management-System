using DevExpress.Pdf.Native;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

namespace GUI
{
    public partial class FormImageViewer : DevExpress.XtraEditors.XtraForm
    {
        public FormImageViewer(byte[] imageData)
        {
            InitializeComponent();
            using (MemoryStream stream = new MemoryStream(imageData))
            {
                Image image = Image.FromStream(stream);
                pictureBox1.Image = image;
            }

        }

        private void FormImageViewer_Load(object sender, EventArgs e)
        {

        }
    }
}