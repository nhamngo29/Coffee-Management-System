namespace GUI
{
    partial class fRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRole));
            this.coffeeDataSet = new GUI.Data.CoffeeDataSet();
            this.rOLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOLETableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.ROLETableAdapter();
            this.tableAdapterManager = new GUI.Data.CoffeeDataSetTableAdapters.TableAdapterManager();
            this.accountRoleTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.AccountRoleTableAdapter();
            this.decentralizationTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.DecentralizationTableAdapter();
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
            this.rOLEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decentralizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decentralizationGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingNavigator)).BeginInit();
            this.rOLEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decentralizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decentralizationGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            this.tableAdapterManager.AccountRoleTableAdapter = this.accountRoleTableAdapter;
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AccountTypeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillInfoTableAdapter = null;
            this.tableAdapterManager.BillTableAdapter = null;
            this.tableAdapterManager.BookingDKTableAdapter = null;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.CategoryFoodTableAdapter = null;
            this.tableAdapterManager.DecentralizationTableAdapter = this.decentralizationTableAdapter;
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
            // accountRoleTableAdapter
            // 
            this.accountRoleTableAdapter.ClearBeforeFill = true;
            // 
            // decentralizationTableAdapter
            // 
            this.decentralizationTableAdapter.ClearBeforeFill = true;
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
            this.rOLEBindingNavigator.Size = new System.Drawing.Size(1228, 25);
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
            this.rOLEBindingNavigatorSaveItem.Click += new System.EventHandler(this.rOLEBindingNavigatorSaveItem_Click_1);
            // 
            // rOLEGridControl
            // 
            this.rOLEGridControl.DataSource = this.rOLEBindingSource;
            this.rOLEGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.rOLEGridControl.Location = new System.Drawing.Point(0, 25);
            this.rOLEGridControl.MainView = this.gridView1;
            this.rOLEGridControl.Name = "rOLEGridControl";
            this.rOLEGridControl.Size = new System.Drawing.Size(1228, 293);
            this.rOLEGridControl.TabIndex = 1;
            this.rOLEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTypeName});
            this.gridView1.GridControl = this.rOLEGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colTypeName
            // 
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 1;
            // 
            // accountRoleBindingSource
            // 
            this.accountRoleBindingSource.DataMember = "FK_AccountRole_IDRole";
            this.accountRoleBindingSource.DataSource = this.rOLEBindingSource;
            // 
            // decentralizationBindingSource
            // 
            this.decentralizationBindingSource.DataMember = "FK_Decentralization_IDRole";
            this.decentralizationBindingSource.DataSource = this.rOLEBindingSource;
            // 
            // decentralizationGridControl
            // 
            this.decentralizationGridControl.DataSource = this.decentralizationBindingSource;
            this.decentralizationGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.decentralizationGridControl.Location = new System.Drawing.Point(0, 324);
            this.decentralizationGridControl.MainView = this.gridView3;
            this.decentralizationGridControl.Name = "decentralizationGridControl";
            this.decentralizationGridControl.Size = new System.Drawing.Size(1228, 389);
            this.decentralizationGridControl.TabIndex = 3;
            this.decentralizationGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.decentralizationGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // fRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 713);
            this.Controls.Add(this.decentralizationGridControl);
            this.Controls.Add(this.rOLEGridControl);
            this.Controls.Add(this.rOLEBindingNavigator);
            this.Name = "fRole";
            this.Text = "Quyền";
            this.Load += new System.EventHandler(this.fRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingNavigator)).EndInit();
            this.rOLEBindingNavigator.ResumeLayout(false);
            this.rOLEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decentralizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decentralizationGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
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
        private Data.CoffeeDataSetTableAdapters.AccountRoleTableAdapter accountRoleTableAdapter;
        private DevExpress.XtraGrid.GridControl rOLEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private System.Windows.Forms.BindingSource accountRoleBindingSource;
        private Data.CoffeeDataSetTableAdapters.DecentralizationTableAdapter decentralizationTableAdapter;
        private System.Windows.Forms.BindingSource decentralizationBindingSource;
        private DevExpress.XtraGrid.GridControl decentralizationGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}