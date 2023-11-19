using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
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
        private Account loginAccount { get; set; }
        public int result = 0;
        List<string> DVT = new List<string> { "Kilôgam (kg)", "Gram (g)", "Lít (l)", "Mililit (ml)", "Thùng", "Két" };
        public AddImportProduct(Account acc)
        {
            InitializeComponent();
            LoadCBNCC();
            LoadInit();
            cboDVT.DataSource = DVT;
            dataList = new BindingList<DetailImport>();
            loginAccount= acc;
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
        void clear()
        {
            txtTenSanPham.Text=null;
            nbSoLuong.Value = 1;
            nbGia.Value = 1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string TenSP = txtTenSanPham.Text;
            int sl = Convert.ToInt32(nbSoLuong.Value);
            string dvt = cboDVT.SelectedItem.ToString();
            float gia = float.Parse(nbGia.Value.ToString());
            if (string.IsNullOrEmpty(TenSP))
                MessageBox.Show("Tên sản phẩm không được để trống");
            else if (sl <= 0)
                MessageBox.Show("Số lượng phải lớn hơn không");
            else if (string.IsNullOrEmpty(dvt))
                MessageBox.Show("Vui lòng chọn đơn vị tính");
            else if (gia <= 0)
                MessageBox.Show("Giá phải lớn hơn không");
            else
            {
                dataList.Add(new DetailImport(sl, gia, TenSP, dvt, sl * gia));
                clear();
                LoadGrid();
            }
        }

        private void AddImportProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime a = dateTime.DateTime;
            string TenPhieu = txtTenPhieu.Text;
            string Note = txtNote.Text;
            string Supplier = cboNCC.SelectedValue.ToString();
            int MaPhieu = int.Parse(txtMaPhieu.Text);
            if (string.IsNullOrEmpty(Supplier))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp");
                result = -1;
            }
            else
            {

                ImportBUS.Instance.InsertImport(new Import(a, loginAccount.IdStaff, Supplier, Note, TenPhieu));
                result = 1;
                int rowHandle = 0;
                while (gridView1.IsValidRowHandle(rowHandle))
                {
                    var data = gridView1.GetRow(rowHandle);
                    if (data is DetailImport)
                    {
                        DetailImport detail = (DetailImport)data;
                        detail.IdImport = MaPhieu;
                        DetailImportBUS.Instance.InsertImport(detail);
                    }
                    rowHandle++;
                }
                if (XtraMessageBox.Show(string.Format("Bạn có muốn in phiếu thu cho {0} không ?", TenPhieu),
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    XtraReport1 report = new XtraReport1();
                    report.Parameters["MaPhieu"].Value = MaPhieu;
                    report.Parameters["TenPhieu"].Value = TenPhieu;
                    report.Parameters["NgayLap"].Value = a;
                    report.Parameters["Note"].Value = Note;
                    report.Parameters["NameStaff"].Value = loginAccount.DisplayName;
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();//show lên
                    SplashScreenManager.CloseForm();
                }    
                    this.Close();
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
    }
}