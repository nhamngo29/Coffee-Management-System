namespace GUI
{
    partial class fAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddUser));
            this.coffeeDataSet = new GUI.Data.CoffeeDataSet();
            this.accountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTypeTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.AccountTypeTableAdapter();
            this.tableAdapterManager = new GUI.Data.CoffeeDataSetTableAdapters.TableAdapterManager();
            this.accountTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.accountTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.getFillUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getFillUserTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.getFillUserTableAdapter();
            this.getFullUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getFullUserTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.getFullUserTableAdapter();
            this.getFullUserGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getFillUserGridControl = new DevExpress.XtraGrid.GridControl();
            this.grvFill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingNavigator)).BeginInit();
            this.accountTypeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getFillUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFullUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFullUserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getFillUserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFill)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // coffeeDataSet
            // 
            this.coffeeDataSet.DataSetName = "CoffeeDataSet";
            this.coffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTypeBindingSource
            // 
            this.accountTypeBindingSource.DataMember = "AccountType";
            this.accountTypeBindingSource.DataSource = this.coffeeDataSet;
            // 
            // accountTypeTableAdapter
            // 
            this.accountTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Account1TableAdapter = null;
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AccountTypeTableAdapter = this.accountTypeTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillInfoTableAdapter = null;
            this.tableAdapterManager.BillTableAdapter = null;
            this.tableAdapterManager.BookingDKTableAdapter = null;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.CategoryFoodTableAdapter = null;
            this.tableAdapterManager.discountTableAdapter = null;
            this.tableAdapterManager.FoodTableAdapter = null;
            this.tableAdapterManager.NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.PhanQuyenTableAdapter = null;
            this.tableAdapterManager.ScreenTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.TableCoffeeTableAdapter = null;
            this.tableAdapterManager.TypeFoodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.Data.CoffeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accountTypeBindingNavigator
            // 
            this.accountTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accountTypeBindingNavigator.BindingSource = this.accountTypeBindingSource;
            this.accountTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accountTypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accountTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.accountTypeBindingNavigatorSaveItem});
            this.accountTypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accountTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accountTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accountTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accountTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accountTypeBindingNavigator.Name = "accountTypeBindingNavigator";
            this.accountTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accountTypeBindingNavigator.Size = new System.Drawing.Size(1166, 25);
            this.accountTypeBindingNavigator.TabIndex = 0;
            this.accountTypeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // accountTypeBindingNavigatorSaveItem
            // 
            this.accountTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accountTypeBindingNavigatorSaveItem.Image")));
            this.accountTypeBindingNavigatorSaveItem.Name = "accountTypeBindingNavigatorSaveItem";
            this.accountTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.accountTypeBindingNavigatorSaveItem.Text = "Save Data";
            this.accountTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.accountTypeBindingNavigatorSaveItem_Click);
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountTypeComboBox.DataSource = this.accountTypeBindingSource;
            this.accountTypeComboBox.DisplayMember = "TypeName";
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Location = new System.Drawing.Point(284, 24);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(282, 21);
            this.accountTypeComboBox.TabIndex = 1;
            this.accountTypeComboBox.ValueMember = "TypeName";
            this.accountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.accountTypeComboBox_SelectedIndexChanged);
            // 
            // getFillUserBindingSource
            // 
            this.getFillUserBindingSource.DataMember = "getFillUser";
            this.getFillUserBindingSource.DataSource = this.coffeeDataSet;
            // 
            // getFillUserTableAdapter
            // 
            this.getFillUserTableAdapter.ClearBeforeFill = true;
            // 
            // getFullUserBindingSource
            // 
            this.getFullUserBindingSource.DataMember = "getFullUser";
            this.getFullUserBindingSource.DataSource = this.coffeeDataSet;
            // 
            // getFullUserTableAdapter
            // 
            this.getFullUserTableAdapter.ClearBeforeFill = true;
            // 
            // getFullUserGridControl
            // 
            this.getFullUserGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getFullUserGridControl.DataSource = this.getFullUserBindingSource;
            this.getFullUserGridControl.Location = new System.Drawing.Point(0, 58);
            this.getFullUserGridControl.MainView = this.gridView2;
            this.getFullUserGridControl.Name = "getFullUserGridControl";
            this.getFullUserGridControl.Size = new System.Drawing.Size(374, 600);
            this.getFullUserGridControl.TabIndex = 4;
            this.getFullUserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName1,
            this.colDisplayName1,
            this.colTypeID1,
            this.colTypeName1,
            this.colActive1});
            this.gridView2.GridControl = this.getFullUserGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colUserName1
            // 
            this.colUserName1.FieldName = "UserName";
            this.colUserName1.Name = "colUserName1";
            this.colUserName1.Visible = true;
            this.colUserName1.VisibleIndex = 0;
            // 
            // colDisplayName1
            // 
            this.colDisplayName1.FieldName = "DisplayName";
            this.colDisplayName1.Name = "colDisplayName1";
            this.colDisplayName1.Visible = true;
            this.colDisplayName1.VisibleIndex = 1;
            // 
            // colTypeID1
            // 
            this.colTypeID1.FieldName = "TypeID";
            this.colTypeID1.Name = "colTypeID1";
            this.colTypeID1.Visible = true;
            this.colTypeID1.VisibleIndex = 2;
            // 
            // colTypeName1
            // 
            this.colTypeName1.FieldName = "TypeName";
            this.colTypeName1.Name = "colTypeName1";
            this.colTypeName1.Visible = true;
            this.colTypeName1.VisibleIndex = 3;
            // 
            // colActive1
            // 
            this.colActive1.FieldName = "Active";
            this.colActive1.Name = "colActive1";
            this.colActive1.Visible = true;
            this.colActive1.VisibleIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loại tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách tài khoản";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.getFullUserGridControl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 658);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(481, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 658);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(685, 600);
            this.panel4.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getFillUserGridControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản phân quyèn";
            // 
            // getFillUserGridControl
            // 
            this.getFillUserGridControl.DataSource = this.getFillUserBindingSource;
            this.getFillUserGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getFillUserGridControl.Location = new System.Drawing.Point(3, 25);
            this.getFillUserGridControl.MainView = this.grvFill;
            this.getFillUserGridControl.Name = "getFillUserGridControl";
            this.getFillUserGridControl.Size = new System.Drawing.Size(679, 572);
            this.getFillUserGridControl.TabIndex = 4;
            this.getFillUserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvFill});
            // 
            // grvFill
            // 
            this.grvFill.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvFill.Appearance.FocusedRow.Options.UseFont = true;
            this.grvFill.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvFill.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvFill.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvFill.Appearance.Row.Options.UseFont = true;
            this.grvFill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colDisplayName,
            this.colTypeID,
            this.colTypeName,
            this.colActive});
            this.grvFill.GridControl = this.getFillUserGridControl;
            this.grvFill.Name = "grvFill";
            this.grvFill.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUserName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colDisplayName
            // 
            this.colDisplayName.FieldName = "DisplayName";
            this.colDisplayName.Name = "colDisplayName";
            this.colDisplayName.Visible = true;
            this.colDisplayName.VisibleIndex = 1;
            // 
            // colTypeID
            // 
            this.colTypeID.FieldName = "TypeID";
            this.colTypeID.Name = "colTypeID";
            this.colTypeID.Visible = true;
            this.colTypeID.VisibleIndex = 2;
            // 
            // colTypeName
            // 
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 3;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.accountTypeComboBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 58);
            this.panel3.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel6.Controls.Add(this.btnDelUser);
            this.panel6.Controls.Add(this.btnAddUser);
            this.panel6.Location = new System.Drawing.Point(383, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(89, 270);
            this.panel6.TabIndex = 12;
            // 
            // btnDelUser
            // 
            this.btnDelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelUser.Location = new System.Drawing.Point(6, 158);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(78, 43);
            this.btnDelUser.TabIndex = 8;
            this.btnDelUser.Text = "<<";
            this.btnDelUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(6, 69);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(78, 43);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = ">>";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click_1);
            // 
            // fAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 708);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accountTypeBindingNavigator);
            this.Name = "fAddUser";
            this.Text = "Thêm người dùng vào nhóm người dùng";
            this.Load += new System.EventHandler(this.fAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingNavigator)).EndInit();
            this.accountTypeBindingNavigator.ResumeLayout(false);
            this.accountTypeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getFillUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFullUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFullUserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getFillUserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.CoffeeDataSet coffeeDataSet;
        private System.Windows.Forms.BindingSource accountTypeBindingSource;
        private Data.CoffeeDataSetTableAdapters.AccountTypeTableAdapter accountTypeTableAdapter;
        private Data.CoffeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator accountTypeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton accountTypeBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.BindingSource getFillUserBindingSource;
        private Data.CoffeeDataSetTableAdapters.getFillUserTableAdapter getFillUserTableAdapter;
        private System.Windows.Forms.BindingSource getFullUserBindingSource;
        private Data.CoffeeDataSetTableAdapters.getFullUserTableAdapter getFullUserTableAdapter;
        private DevExpress.XtraGrid.GridControl getFullUserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayName1;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeID1;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName1;
        private DevExpress.XtraGrid.Columns.GridColumn colActive1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl getFillUserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grvFill;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
    }
}