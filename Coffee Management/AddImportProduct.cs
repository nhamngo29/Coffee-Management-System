using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class AddImportProduct : DevExpress.XtraEditors.XtraForm
    {
        private BindingList<DetailImport> dataList;
        List<string> DVT = new List<string> { "Kilôgam (kg)", "Gram (g)", "Lít (l)", "Mililit (ml)", "Thùng", "Két" };
        
        public AddImportProduct()
        {
            InitializeComponent();
            LoadCBNCC();
            LoadInit();
            cboDVT.DataSource= DVT;
            dataList = new BindingList<DetailImport>();
        }

        

        void LoadInit()
        {
            dateTime.EditValue = DateTime.Now;
            txtMaPhieu.Text = (ImportBUS.Instance.GetImportPorudctMax().ID + 1).ToString();
            txtTenPhieu.Text = "Phiêu nhập hàng số " + txtMaPhieu.Text;
        }    
        void LoadCBNCC()///load cbo nhà cung cấp
        {
            cboNCC.DataSource = SupplierBUS.Instance.GetAll();
            cboNCC.ValueMember = "IdSupplier";
            cboNCC.DisplayMember = "Name";
        }
        void LoadGrid()
        {
            gridControl1.DataSource = dataList;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string TenSP = txtTenSanPham.Text;
            int sl = Convert.ToInt32(nbSoLuong.Value);
            string dvt = cboDVT.SelectedItem.ToString();
            float gia = float.Parse(nbGia.Value.ToString());
            if (string.IsNullOrEmpty(TenSP))
                MessageBox.Show("Tên sản phẩm không được để trống");
            else if(sl<=0)
                MessageBox.Show("Số lượng phải lớn hơn không");
            else if(string.IsNullOrEmpty(dvt))
                MessageBox.Show("Vui lòng chọn đơn vị tính");
            else if(gia<=0)
                MessageBox.Show("Giá phải lớn hơn không");
            else
            {
                dataList.Add(new DetailImport(sl, gia, TenSP, dvt,sl*gia));
                LoadGrid();
            }    
        }

        private void AddImportProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime a = dateTime.DateTime;
            string TenPhieu=txtTenPhieu.Text;
            string Note=txtNote.Text;
            string Supplier=cboNCC.SelectedValue.ToString();
            if(string.IsNullOrEmpty(Supplier))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp");
            }
            else
            {
                ImportBUS.Instance.InsertImport(new Import(a,1,Supplier,Note));
            }
        }
    }
}