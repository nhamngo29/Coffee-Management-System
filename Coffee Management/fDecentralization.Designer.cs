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
            this.accountRoleDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountRoleDKTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.AccountRoleDKTableAdapter();
            this.tableAdapterManager = new GUI.Data.CoffeeDataSetTableAdapters.TableAdapterManager();
            this.accountRoleTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.AccountRoleTableAdapter();
            this.accountRoleDKBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.accountRoleDKBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.roleIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.roleIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.accountRoleDKGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accountRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountRoleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountRoleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rOLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOLETableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.ROLETableAdapter();
            this.rOLEComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleDKBindingNavigator)).BeginInit();
            this.accountRoleDKBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleDKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // coffeeDataSet
            // 
            this.coffeeDataSet.DataSetName = "CoffeeDataSet";
            this.coffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.DecentralizationTableAdapter = null;
            this.tableAdapterManager.DetailImportTableAdapter = null;
            this.tableAdapterManager.discountTableAdapter = null;
            this.tableAdapterManager.FoodTableAdapter = null;
            this.tableAdapterManager.ImportProductTableAdapter = null;
            this.tableAdapterManager.ROLETableAdapter = null;
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
            // accountRoleDKBindingNavigator
            // 
            this.accountRoleDKBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accountRoleDKBindingNavigator.BindingSource = this.accountRoleDKBindingSource;
            this.accountRoleDKBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accountRoleDKBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accountRoleDKBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.accountRoleDKBindingNavigatorSaveItem});
            this.accountRoleDKBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accountRoleDKBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accountRoleDKBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accountRoleDKBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accountRoleDKBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accountRoleDKBindingNavigator.Name = "accountRoleDKBindingNavigator";
            this.accountRoleDKBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accountRoleDKBindingNavigator.Size = new System.Drawing.Size(1097, 25);
            this.accountRoleDKBindingNavigator.TabIndex = 0;
            this.accountRoleDKBindingNavigator.Text = "bindingNavigator1";
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
            // accountRoleDKBindingNavigatorSaveItem
            // 
            this.accountRoleDKBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountRoleDKBindingNavigatorSaveItem.Enabled = false;
            this.accountRoleDKBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accountRoleDKBindingNavigatorSaveItem.Image")));
            this.accountRoleDKBindingNavigatorSaveItem.Name = "accountRoleDKBindingNavigatorSaveItem";
            this.accountRoleDKBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.accountRoleDKBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleIDToolStripLabel,
            this.roleIDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1097, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // roleIDToolStripLabel
            // 
            this.roleIDToolStripLabel.Name = "roleIDToolStripLabel";
            this.roleIDToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.roleIDToolStripLabel.Text = "RoleID:";
            // 
            // roleIDToolStripTextBox
            // 
            this.roleIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roleIDToolStripTextBox.Name = "roleIDToolStripTextBox";
            this.roleIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // accountRoleDKGridControl
            // 
            this.accountRoleDKGridControl.DataSource = this.accountRoleDKBindingSource;
            this.accountRoleDKGridControl.Location = new System.Drawing.Point(695, 189);
            this.accountRoleDKGridControl.MainView = this.gridView1;
            this.accountRoleDKGridControl.Name = "accountRoleDKGridControl";
            this.accountRoleDKGridControl.Size = new System.Drawing.Size(355, 287);
            this.accountRoleDKGridControl.TabIndex = 2;
            this.accountRoleDKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.accountRoleDKGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // accountRoleBindingSource
            // 
            this.accountRoleBindingSource.DataMember = "AccountRole";
            this.accountRoleBindingSource.DataSource = this.coffeeDataSet;
            // 
            // accountRoleBindingSource1
            // 
            this.accountRoleBindingSource1.DataMember = "AccountRole";
            this.accountRoleBindingSource1.DataSource = this.coffeeDataSet;
            // 
            // accountRoleBindingSource2
            // 
            this.accountRoleBindingSource2.DataMember = "AccountRole";
            this.accountRoleBindingSource2.DataSource = this.coffeeDataSet;
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
            // rOLEComboBox
            // 
            this.rOLEComboBox.DataSource = this.rOLEBindingSource;
            this.rOLEComboBox.DisplayMember = "TypeName";
            this.rOLEComboBox.FormattingEnabled = true;
            this.rOLEComboBox.Location = new System.Drawing.Point(705, 129);
            this.rOLEComboBox.Name = "rOLEComboBox";
            this.rOLEComboBox.Size = new System.Drawing.Size(355, 21);
            this.rOLEComboBox.TabIndex = 3;
            this.rOLEComboBox.ValueMember = "ID";
            this.rOLEComboBox.SelectionChangeCommitted += new System.EventHandler(this.rOLEComboBox_SelectionChangeCommitted);
            // 
            // fDecentralization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 525);
            this.Controls.Add(this.rOLEComboBox);
            this.Controls.Add(this.accountRoleDKGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.accountRoleDKBindingNavigator);
            this.Name = "fDecentralization";
            this.Text = "Decentralization";
            this.Load += new System.EventHandler(this.fDecentralization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleDKBindingNavigator)).EndInit();
            this.accountRoleDKBindingNavigator.ResumeLayout(false);
            this.accountRoleDKBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleDKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRoleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.CoffeeDataSet coffeeDataSet;
        private System.Windows.Forms.BindingSource accountRoleDKBindingSource;
        private Data.CoffeeDataSetTableAdapters.AccountRoleDKTableAdapter accountRoleDKTableAdapter;
        private Data.CoffeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator accountRoleDKBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton accountRoleDKBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel roleIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox roleIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private Data.CoffeeDataSetTableAdapters.AccountRoleTableAdapter accountRoleTableAdapter;
        private DevExpress.XtraGrid.GridControl accountRoleDKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource accountRoleBindingSource;
        private System.Windows.Forms.BindingSource accountRoleBindingSource1;
        private System.Windows.Forms.BindingSource accountRoleBindingSource2;
        private System.Windows.Forms.BindingSource rOLEBindingSource;
        private Data.CoffeeDataSetTableAdapters.ROLETableAdapter rOLETableAdapter;
        private System.Windows.Forms.ComboBox rOLEComboBox;
    }
}