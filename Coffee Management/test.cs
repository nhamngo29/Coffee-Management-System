using System;
using LibrarySQL;

using System.Windows.Forms;


namespace Coffee_Management
{
    public partial class test : Form
    {

        SQL_Connection conn;
        public test()
        {
            InitializeComponent();
            conn = new SQL_Connection(Properties.Settings.Default.ConnectionString);
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            conn.CreateConnection();
            if(conn.TestConnection())
            {
                MessageBox.Show("Kết nối thành công", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Kết nối không thành công", "Thông báo");
            }    
        }
    }
}
