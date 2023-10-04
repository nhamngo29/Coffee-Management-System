namespace Coffee_Management
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label priceLabel;
            this.bar11 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar12 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.coffeeManagementDataSet = new Coffee_Management.CoffeeManagementDataSet();
            this.typeFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeFoodTableAdapter = new Coffee_Management.CoffeeManagementDataSetTableAdapters.TypeFoodTableAdapter();
            this.tableAdapterManager = new Coffee_Management.CoffeeManagementDataSetTableAdapters.TableAdapterManager();
            this.typeFoodGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTableAdapter = new Coffee_Management.CoffeeManagementDataSetTableAdapters.FoodTableAdapter();
            this.foodGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.priceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lkedPickCategory = new DevExpress.XtraEditors.LookUpEdit();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeFoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeFoodGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bar11
            // 
            this.bar11.BarName = "Main menu";
            this.bar11.DockCol = 0;
            this.bar11.DockRow = 0;
            this.bar11.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar11.OptionsBar.MultiLine = true;
            this.bar11.OptionsBar.UseWholeRow = true;
            this.bar11.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6,
            this.bar12});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnPhucHoi,
            this.btnGhi,
            this.btnHuy,
            this.btnLamMoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar6;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar12;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // bar12
            // 
            this.bar12.BarName = "Status bar";
            this.bar12.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar12.DockCol = 0;
            this.bar12.DockRow = 0;
            this.bar12.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar12.OptionsBar.AllowQuickCustomization = false;
            this.bar12.OptionsBar.DrawDragBorder = false;
            this.bar12.OptionsBar.UseWholeRow = true;
            this.bar12.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1075, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 691);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1075, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 667);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1075, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 667);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dropDownButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1075, 35);
            this.panelControl1.TabIndex = 4;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Location = new System.Drawing.Point(333, 5);
            this.dropDownButton1.MenuManager = this.barManager1;
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(343, 23);
            this.dropDownButton1.TabIndex = 0;
            this.dropDownButton1.Text = "dropDownButton1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.typeFoodGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 59);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1075, 313);
            this.panelControl2.TabIndex = 5;
            // 
            // coffeeManagementDataSet
            // 
            this.coffeeManagementDataSet.DataSetName = "CoffeeManagementDataSet";
            this.coffeeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeFoodBindingSource
            // 
            this.typeFoodBindingSource.DataMember = "TypeFood";
            this.typeFoodBindingSource.DataSource = this.coffeeManagementDataSet;
            // 
            // typeFoodTableAdapter
            // 
            this.typeFoodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AccountTypeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillInfoTableAdapter = null;
            this.tableAdapterManager.BillTableAdapter = null;
            this.tableAdapterManager.CategoryFoodTableAdapter = null;
            this.tableAdapterManager.discountTableAdapter = null;
            this.tableAdapterManager.FoodTableAdapter = this.foodTableAdapter;
            this.tableAdapterManager.ReservationsTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.TableCoffeeTableAdapter = null;
            this.tableAdapterManager.TypeFoodTableAdapter = this.typeFoodTableAdapter;
            this.tableAdapterManager.UpdateOrder = Coffee_Management.CoffeeManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // typeFoodGridControl
            // 
            this.typeFoodGridControl.DataSource = this.typeFoodBindingSource;
            this.typeFoodGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeFoodGridControl.Location = new System.Drawing.Point(2, 2);
            this.typeFoodGridControl.MainView = this.gridView1;
            this.typeFoodGridControl.MenuManager = this.barManager1;
            this.typeFoodGridControl.Name = "typeFoodGridControl";
            this.typeFoodGridControl.Size = new System.Drawing.Size(1071, 309);
            this.typeFoodGridControl.TabIndex = 0;
            this.typeFoodGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colIdCategory});
            this.gridView1.GridControl = this.typeFoodGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colIdCategory
            // 
            this.colIdCategory.FieldName = "IdCategory";
            this.colIdCategory.Name = "colIdCategory";
            this.colIdCategory.Visible = true;
            this.colIdCategory.VisibleIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.foodGridControl);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(548, 372);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(527, 319);
            this.panelControl3.TabIndex = 6;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "FK_Food_Type";
            this.foodBindingSource.DataSource = this.typeFoodBindingSource;
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // foodGridControl
            // 
            this.foodGridControl.DataSource = this.foodBindingSource;
            this.foodGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodGridControl.Location = new System.Drawing.Point(2, 2);
            this.foodGridControl.MainView = this.gridView2;
            this.foodGridControl.MenuManager = this.barManager1;
            this.foodGridControl.Name = "foodGridControl";
            this.foodGridControl.Size = new System.Drawing.Size(523, 315);
            this.foodGridControl.TabIndex = 0;
            this.foodGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colName1,
            this.colType,
            this.colPrice});
            this.gridView2.GridControl = this.foodGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(38, 433);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(22, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // iDSpinEdit
            // 
            this.iDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.foodBindingSource, "ID", true));
            this.iDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iDSpinEdit.Location = new System.Drawing.Point(92, 430);
            this.iDSpinEdit.MenuManager = this.barManager1;
            this.iDSpinEdit.Name = "iDSpinEdit";
            this.iDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iDSpinEdit.Size = new System.Drawing.Size(121, 20);
            this.iDSpinEdit.TabIndex = 8;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 465);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Name:";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.foodBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(92, 462);
            this.nameTextEdit.MenuManager = this.barManager1;
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(121, 20);
            this.nameTextEdit.TabIndex = 10;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(21, 498);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(35, 13);
            typeLabel.TabIndex = 11;
            typeLabel.Text = "Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Type", true));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(92, 495);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 12;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(22, 530);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Price:";
            // 
            // priceSpinEdit
            // 
            this.priceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.foodBindingSource, "Price", true));
            this.priceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.priceSpinEdit.Location = new System.Drawing.Point(92, 528);
            this.priceSpinEdit.MenuManager = this.barManager1;
            this.priceSpinEdit.Name = "priceSpinEdit";
            this.priceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.priceSpinEdit.Size = new System.Drawing.Size(121, 20);
            this.priceSpinEdit.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coffee_Management.Properties.Resources.logoo;
            this.pictureBox1.Location = new System.Drawing.Point(219, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lkedPickCategory
            // 
            this.lkedPickCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkedPickCategory.Location = new System.Drawing.Point(25, 582);
            this.lkedPickCategory.Name = "lkedPickCategory";
            this.lkedPickCategory.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.lkedPickCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkedPickCategory.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lkedPickCategory.Properties.Appearance.Options.UseBackColor = true;
            this.lkedPickCategory.Properties.Appearance.Options.UseFont = true;
            this.lkedPickCategory.Properties.Appearance.Options.UseForeColor = true;
            this.lkedPickCategory.Properties.AutoHeight = false;
            this.lkedPickCategory.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lkedPickCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkedPickCategory.Properties.NullText = "-- Chọn danh mục --";
            this.lkedPickCategory.Size = new System.Drawing.Size(189, 32);
            this.lkedPickCategory.TabIndex = 16;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 711);
            this.Controls.Add(this.lkedPickCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceSpinEdit);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDSpinEdit);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeFoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeFoodGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickCategory.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar11;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar12;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource typeFoodBindingSource;
        private CoffeeManagementDataSet coffeeManagementDataSet;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private CoffeeManagementDataSetTableAdapters.TypeFoodTableAdapter typeFoodTableAdapter;
        private CoffeeManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl typeFoodGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategory;
        private CoffeeManagementDataSetTableAdapters.FoodTableAdapter foodTableAdapter;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private DevExpress.XtraEditors.SpinEdit priceSpinEdit;
        private System.Windows.Forms.ComboBox typeComboBox;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.SpinEdit iDSpinEdit;
        private DevExpress.XtraGrid.GridControl foodGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LookUpEdit lkedPickCategory;
    }
}