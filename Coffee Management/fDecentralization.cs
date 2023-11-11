using DevExpress.XtraEditors;
using GUI.Data.CoffeeDataSetTableAdapters;
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
    public partial class fDecentralization : DevExpress.XtraEditors.XtraForm
    {

        public fDecentralization()
        {
            InitializeComponent();
        }

        private void account1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.account1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);

        }
        private void fDecentralization_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.PhanQuyen' table. You can move, or remove it, as needed.
            this.phanQuyenTableAdapter.Fill(this.coffeeDataSet.PhanQuyen);
            // TODO: This line of code loads data into the 'coffeeDataSet.Screen' table. You can move, or remove it, as needed.
            this.screenTableAdapter.Fill(this.coffeeDataSet.Screen);

            // TODO: This line of code loads data into the 'coffeeDataSet.PhanQuyen' table. You can move, or remove it, as needed.
            this.phanQuyenTableAdapter.Fill(this.coffeeDataSet.PhanQuyen);
            // TODO: This line of code loads data into the 'coffeeDataSet.NhomNguoiDung' table. You can move, or remove it, as needed.
            this.nhomNguoiDungTableAdapter.Fill(this.coffeeDataSet.NhomNguoiDung);


        }
        public void LoadDataCondition()
        {
            this.getPhanQuyenTableAdapter.Fill(this.coffeeDataSet.getPhanQuyen, ((int)(System.Convert.ChangeType(nhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString(), typeof(int)))));
        }
        
        private void nhomNguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadDataCondition();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int _NhomNguoiDung = ((int)(System.Convert.ChangeType(nhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString(), typeof(int))));
            foreach (DataGridViewRow item in getPhanQuyenDataGridView.Rows)
            {
                if(getPhanQuyenTableAdapter.GDB_KTKC(_NhomNguoiDung, item.Cells[0].Value.ToString()) == null)
                {
                    try
                    {
                        phanQuyenTableAdapter.Insert(_NhomNguoiDung,item.Cells[0].Value.ToString(), (bool)(item.Cells[2].Value));
                    }
                    catch
                    {
                        phanQuyenTableAdapter.Insert(_NhomNguoiDung,item.Cells[0].Value.ToString(), false);
                    }
                }
                else
                {
                    phanQuyenTableAdapter.UpdateQuery((item.Cells[2] == null) ? false:(bool)(item.Cells[2].Value), _NhomNguoiDung, item.Cells[0].Value.ToString());
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

