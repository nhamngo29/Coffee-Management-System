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
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.loaiToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.loaiToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.getFillUserGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.getFullUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getFullUserTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.getFullUserTableAdapter();
            this.getFullUserGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingNavigator)).BeginInit();
            this.accountTypeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getFillUserBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getFillUserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFullUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFullUserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.accountTypeBindingNavigator.Size = new System.Drawing.Size(1037, 25);
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
            this.accountTypeComboBox.DataSource = this.accountTypeBindingSource;
            this.accountTypeComboBox.DisplayMember = "TypeName";
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Location = new System.Drawing.Point(783, 93);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(242, 21);
            this.accountTypeComboBox.TabIndex = 1;
            this.accountTypeComboBox.ValueMember = "ID";
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
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loaiToolStripLabel,
            this.loaiToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1037, 25);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // loaiToolStripLabel
            // 
            this.loaiToolStripLabel.Name = "loaiToolStripLabel";
            this.loaiToolStripLabel.Size = new System.Drawing.Size(29, 22);
            this.loaiToolStripLabel.Text = "loai:";
            // 
            // loaiToolStripTextBox
            // 
            this.loaiToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loaiToolStripTextBox.Name = "loaiToolStripTextBox";
            this.loaiToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // getFillUserGridControl
            // 
            this.getFillUserGridControl.DataSource = this.getFillUserBindingSource;
            this.getFillUserGridControl.Location = new System.Drawing.Point(12, 124);
            this.getFillUserGridControl.MainView = this.gridView1;
            this.getFillUserGridControl.Name = "getFillUserGridControl";
            this.getFillUserGridControl.Size = new System.Drawing.Size(344, 291);
            this.getFillUserGridControl.TabIndex = 3;
            this.getFillUserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colDisplayName,
            this.colTypeID,
            this.colTypeName,
            this.colActive});
            this.gridView1.GridControl = this.getFillUserGridControl;
            this.gridView1.Name = "gridView1";
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
            this.getFullUserGridControl.DataSource = this.getFullUserBindingSource;
            this.getFullUserGridControl.Location = new System.Drawing.Point(578, 124);
            this.getFullUserGridControl.MainView = this.gridView2;
            this.getFullUserGridControl.Name = "getFullUserGridControl";
            this.getFullUserGridControl.Size = new System.Drawing.Size(447, 291);
            this.getFullUserGridControl.TabIndex = 4;
            this.getFullUserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
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
            // fAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 505);
            this.Controls.Add(this.getFullUserGridControl);
            this.Controls.Add(this.getFillUserGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.accountTypeComboBox);
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
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getFillUserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFullUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFullUserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel loaiToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox loaiToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl getFillUserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private System.Windows.Forms.BindingSource getFullUserBindingSource;
        private Data.CoffeeDataSetTableAdapters.getFullUserTableAdapter getFullUserTableAdapter;
        private DevExpress.XtraGrid.GridControl getFullUserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayName1;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeID1;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName1;
        private DevExpress.XtraGrid.Columns.GridColumn colActive1;
    }
}