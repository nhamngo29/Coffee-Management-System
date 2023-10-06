using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
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

namespace Coffee_Management
{
    public partial class fFood : DevExpress.XtraEditors.XtraForm
    {
        public fFood()
        {
            InitializeComponent();
        }

        private void foodDKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void fillDKToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.foodDKTableAdapter.FillDK(this.coffeeDataset.FoodDK, ((int)(System.Convert.ChangeType(typeToolStripTextBox.Text, typeof(int)))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void foodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.foodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeData);

        }

        private void fFood_Load(object sender, EventArgs e)
        {
            
            this.foodTableAdapter.Fill(this.coffeeData.Food);
            RepositoryItemLookUpEdit myLookup = new RepositoryItemLookUpEdit();
            try
            {
                myLookup.DataSource = TypeFoodBUS.Instance.GetAllTypeFood();
                ludType.Properties.DataSource = TypeFoodBUS.Instance.GetAllTypeFood();
                ludType.Properties.DisplayMember = "Name";
                ludType.Properties.ValueMember = "Id";
                ludType.Properties.NullText = "-- Chọn loại sản phẩm --";
                myLookup.DisplayMember = "Name";
                myLookup.ValueMember = "Id";
                myLookup.NullText = "-- Chọn loại sản phẩm --";
                gridView1.Columns[2].ColumnEdit = myLookup;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }

        private void gridView1_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                int[] selectedRows = view.GetSelectedRows();
                if (selectedRows.Length > 0)
                {
                    object Name = view.GetRowCellValue(selectedRows[0], "Name");
                    object value=view.GetRowCellValue(selectedRows[0], "Type");
                    object price= view.GetRowCellValue(selectedRows[0], "Price");
                    object image = view.GetRowCellValue(selectedRows[0], "Image");
                    object Describe = view.GetRowCellValue(selectedRows[0], "Describe");
                    
                    txtNameFood.Text = Name.ToString();
                    nbrPrice.Value = (int)price;
                    txtDescribe.Text = Describe.ToString();
                    string resourcesDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", image.ToString() + ".jpg");
                    if (File.Exists(resourcesDirectory))
                    {
                        try
                        {
                            // Đọc tệp hình ảnh
                            using (var imageStream = File.OpenRead(resourcesDirectory))
                            {
                                Image imagep = Image.FromStream(imageStream);
                                pictureBox1.Image = imagep;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Xử lý ngoại lệ nếu có lỗi khi đọc tệp hình ảnh.
                            Console.WriteLine("Lỗi khi đọc tệp hình ảnh: " + ex.Message);
                        }

                    }
                }
            }
        }
    }
}