namespace GUI
{
    partial class fDecentralization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDecentralization));
            this.coffeeDataSet = new GUI.Data.CoffeeDataSet();
            this.rOLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOLETableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.ROLETableAdapter();
            this.tableAdapterManager = new GUI.Data.CoffeeDataSetTableAdapters.TableAdapterManager();
            this.rOLEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rOLEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rOLEComboBox = new System.Windows.Forms.ComboBox();
            this.accountRoleDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountRoleDKTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.AccountRoleDKTableAdapter();
            this.accountRoleDKGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountStaff = new GUI.Data.CoffeeDataSetTableAdapters.AccountStaff();
            this.accountStaffGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOB = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingNavigator)).BeginInit();
            this.rOLEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleDKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStaffGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // coffeeDataSet
            // 
            this.coffeeDataSet.DataSetName = "CoffeeDataSet";
            this.coffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rOLEBindingSource
            // 
            this.rOLEBindingSource.DataMember = "ROLE";
            this.rOLEBindingSource.DataSource = this.coffeeDataSet;
            // 
            // rOLETableAdapter
            // 
            this.rOLETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountRoleTableAdapter = null;
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AccountTypeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillInfoTableAdapter = null;
            this.tableAdapterManager.BillTableAdapter = null;
            this.tableAdapterManager.BookingDKTableAdapter = null;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.CategoryFoodTableAdapter = null;
            this.tableAdapterManager.DecentralizationTableAdapter = null;
            this.tableAdapterManager.DetailImportTableAdapter = null;
            this.tableAdapterManager.discountTableAdapter = null;
            this.tableAdapterManager.FoodTableAdapter = null;
            this.tableAdapterManager.ImportProductTableAdapter = null;
            this.tableAdapterManager.ROLETableAdapter = this.rOLETableAdapter;
            this.tableAdapterManager.ScreenTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.TableCoffeeTableAdapter = null;
            this.tableAdapterManager.TypeFoodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.Data.CoffeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rOLEBindingNavigator
            // 
            this.rOLEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rOLEBindingNavigator.BindingSource = this.rOLEBindingSource;
            this.rOLEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rOLEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rOLEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rOLEBindingNavigatorSaveItem});
            this.rOLEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rOLEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rOLEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rOLEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rOLEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rOLEBindingNavigator.Name = "rOLEBindingNavigator";
            this.rOLEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rOLEBindingNavigator.Size = new System.Drawing.Size(1046, 25);
            this.rOLEBindingNavigator.TabIndex = 0;
            this.rOLEBindingNavigator.Text = "bindingNavigator1";
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
            // rOLEBindingNavigatorSaveItem
            // 
            this.rOLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rOLEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rOLEBindingNavigatorSaveItem.Image")));
            this.rOLEBindingNavigatorSaveItem.Name = "rOLEBindingNavigatorSaveItem";
            this.rOLEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rOLEBindingNavigatorSaveItem.Text = "Save Data";
            this.rOLEBindingNavigatorSaveItem.Click += new System.EventHandler(this.rOLEBindingNavigatorSaveItem_Click_3);
            // 
            // rOLEComboBox
            // 
            this.rOLEComboBox.DataSource = this.rOLEBindingSource;
            this.rOLEComboBox.DisplayMember = "TypeName";
            this.rOLEComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rOLEComboBox.FormattingEnabled = true;
            this.rOLEComboBox.Location = new System.Drawing.Point(0, 25);
            this.rOLEComboBox.Name = "rOLEComboBox";
            this.rOLEComboBox.Size = new System.Drawing.Size(1046, 21);
            this.rOLEComboBox.TabIndex = 1;
            this.rOLEComboBox.ValueMember = "ID";
            this.rOLEComboBox.SelectedValueChanged += new System.EventHandler(this.rOLEComboBox_SelectedValueChanged_2);
            // 
            // accountRoleDKBindingSource
            // 
            this.accountRoleDKBindingSource.DataMember = "AccountRoleDK";
            this.accountRoleDKBindingSource.DataSource = this.coffeeDataSet;
            // 
            // accountRoleDKTableAdapter
            // 
            this.accountRoleDKTableAdapter.ClearBeforeFill = true;
            // 
            // accountRoleDKGridControl
            // 
            this.accountRoleDKGridControl.DataSource = this.accountRoleDKBindingSource;
            this.accountRoleDKGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.accountRoleDKGridControl.Location = new System.Drawing.Point(0, 46);
            this.accountRoleDKGridControl.MainView = this.gridView1;
            this.accountRoleDKGridControl.Name = "accountRoleDKGridControl";
            this.accountRoleDKGridControl.Size = new System.Drawing.Size(530, 459);
            this.accountRoleDKGridControl.TabIndex = 3;
            this.accountRoleDKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTypeName,
            this.colUserName,
            this.colDisplayName,
            this.colName});
            this.gridView1.GridControl = this.accountRoleDKGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colTypeName
            // 
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            // 
            // colDisplayName
            // 
            this.colDisplayName.FieldName = "DisplayName";
            this.colDisplayName.Name = "colDisplayName";
            this.colDisplayName.Visible = true;
            this.colDisplayName.VisibleIndex = 2;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            // 
            // accountDKBindingSource
            // 
            this.accountDKBindingSource.DataSource = this.coffeeDataSet;
            this.accountDKBindingSource.Position = 0;
            // 
            // accountStaffBindingSource
            // 
            this.accountStaffBindingSource.DataMember = "AccountStaff";
            this.accountStaffBindingSource.DataSource = this.coffeeDataSet;
            // 
            // accountStaff
            // 
            this.accountStaff.ClearBeforeFill = true;
            // 
            // accountStaffGridControl
            // 
            this.accountStaffGridControl.DataSource = this.accountStaffBindingSource;
            this.accountStaffGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.accountStaffGridControl.Location = new System.Drawing.Point(553, 46);
            this.accountStaffGridControl.MainView = this.gridView2;
            this.accountStaffGridControl.Name = "accountStaffGridControl";
            this.accountStaffGridControl.Size = new System.Drawing.Size(493, 459);
            this.accountStaffGridControl.TabIndex = 4;
            this.accountStaffGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName1,
            this.colName1,
            this.colDOB});
            this.gridView2.GridControl = this.accountStaffGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colUserName1
            // 
            this.colUserName1.FieldName = "UserName";
            this.colUserName1.Name = "colUserName1";
            this.colUserName1.Visible = true;
            this.colUserName1.VisibleIndex = 0;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            // 
            // colDOB
            // 
            this.colDOB.FieldName = "DOB";
            this.colDOB.Name = "colDOB";
            this.colDOB.Visible = true;
            this.colDOB.VisibleIndex = 2;
            // 
            // fDecentralization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 505);
            this.Controls.Add(this.accountStaffGridControl);
            this.Controls.Add(this.accountRoleDKGridControl);
            this.Controls.Add(this.rOLEComboBox);
            this.Controls.Add(this.rOLEBindingNavigator);
            this.Name = "fDecentralization";
            this.Text = "Decentralization";
            this.Load += new System.EventHandler(this.Decentralization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingNavigator)).EndInit();
            this.rOLEBindingNavigator.ResumeLayout(false);
            this.rOLEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleDKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStaffGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.CoffeeDataSet coffeeDataSet;
        private System.Windows.Forms.BindingSource rOLEBindingSource;
        private Data.CoffeeDataSetTableAdapters.ROLETableAdapter rOLETableAdapter;
        private Data.CoffeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rOLEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rOLEBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox rOLEComboBox;
        private System.Windows.Forms.BindingSource accountRoleDKBindingSource;
        private Data.CoffeeDataSetTableAdapters.AccountRoleDKTableAdapter accountRoleDKTableAdapter;
        private DevExpress.XtraGrid.GridControl accountRoleDKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private System.Windows.Forms.BindingSource accountDKBindingSource;
        private System.Windows.Forms.BindingSource accountStaffBindingSource;
        private Data.CoffeeDataSetTableAdapters.AccountStaff accountStaff;
        private DevExpress.XtraGrid.GridControl accountStaffGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDOB;
    }
}