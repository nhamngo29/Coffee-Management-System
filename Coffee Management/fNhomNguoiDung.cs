using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DTO;
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
    public partial class fNhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public fNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void fNhomNguoiDung_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            try
            {
                gc.DataSource = NhomNguoiDungBUS.Instance.GetAll();
                gv.Columns[0].Caption = "Mã số";
                gv.Columns[0].OptionsColumn.AllowEdit = false;
                gv.Columns[1].Caption = "Nhóm account";
                gv.Columns[2].Caption = "Tên";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }

            RepositoryItemLookUpEdit myLookup = new RepositoryItemLookUpEdit();
            try
            {
                myLookup.DataSource = AccountTypeBUS.Instance.GetAllAccountType();
                myLookup.DisplayMember = "TypeName";
                myLookup.ValueMember = "ID";
                myLookup.NullText = "-- Chọn loại --";
                gv.Columns[1].ColumnEdit = myLookup;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
    }
}