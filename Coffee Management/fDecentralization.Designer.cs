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
            this.account1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.account1TableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.Account1TableAdapter();
            this.tableAdapterManager = new GUI.Data.CoffeeDataSetTableAdapters.TableAdapterManager();
            this.account1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.account1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fill_IDToolStrip = new System.Windows.Forms.ToolStrip();
            this.maIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fill_IDToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account1BindingNavigator)).BeginInit();
            this.account1BindingNavigator.SuspendLayout();
            this.fill_IDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // coffeeDataSet
            // 
            this.coffeeDataSet.DataSetName = "CoffeeDataSet";
            this.coffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // account1BindingSource
            // 
            this.account1BindingSource.DataMember = "Account1";
            this.account1BindingSource.DataSource = this.coffeeDataSet;
            // 
            // account1TableAdapter
            // 
            this.account1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Account1TableAdapter = this.account1TableAdapter;
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AccountTypeTableAdapter = null;
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
            // account1BindingNavigator
            // 
            this.account1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.account1BindingNavigator.BindingSource = this.account1BindingSource;
            this.account1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.account1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.account1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.account1BindingNavigatorSaveItem});
            this.account1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.account1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.account1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.account1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.account1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.account1BindingNavigator.Name = "account1BindingNavigator";
            this.account1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.account1BindingNavigator.Size = new System.Drawing.Size(783, 25);
            this.account1BindingNavigator.TabIndex = 0;
            this.account1BindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // account1BindingNavigatorSaveItem
            // 
            this.account1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.account1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("account1BindingNavigatorSaveItem.Image")));
            this.account1BindingNavigatorSaveItem.Name = "account1BindingNavigatorSaveItem";
            this.account1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.account1BindingNavigatorSaveItem.Text = "Save Data";
            this.account1BindingNavigatorSaveItem.Click += new System.EventHandler(this.account1BindingNavigatorSaveItem_Click);
            // 
            // fill_IDToolStrip
            // 
            this.fill_IDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maIDToolStripLabel,
            this.maIDToolStripTextBox,
            this.fill_IDToolStripButton});
            this.fill_IDToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fill_IDToolStrip.Name = "fill_IDToolStrip";
            this.fill_IDToolStrip.Size = new System.Drawing.Size(783, 25);
            this.fill_IDToolStrip.TabIndex = 1;
            this.fill_IDToolStrip.Text = "fill_IDToolStrip";
            // 
            // maIDToolStripLabel
            // 
            this.maIDToolStripLabel.Name = "maIDToolStripLabel";
            this.maIDToolStripLabel.Size = new System.Drawing.Size(38, 22);
            this.maIDToolStripLabel.Text = "maID:";
            // 
            // maIDToolStripTextBox
            // 
            this.maIDToolStripTextBox.Name = "maIDToolStripTextBox";
            this.maIDToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fill_IDToolStripButton
            // 
            this.fill_IDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fill_IDToolStripButton.Name = "fill_IDToolStripButton";
            this.fill_IDToolStripButton.Size = new System.Drawing.Size(42, 19);
            this.fill_IDToolStripButton.Text = "Fill_ID";
            this.fill_IDToolStripButton.Click += new System.EventHandler(this.fill_IDToolStripButton_Click);
            // 
            // fDecentralization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 391);
            this.Controls.Add(this.fill_IDToolStrip);
            this.Controls.Add(this.account1BindingNavigator);
            this.Name = "fDecentralization";
            this.Text = "fDecentralization";
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account1BindingNavigator)).EndInit();
            this.account1BindingNavigator.ResumeLayout(false);
            this.account1BindingNavigator.PerformLayout();
            this.fill_IDToolStrip.ResumeLayout(false);
            this.fill_IDToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.CoffeeDataSet coffeeDataSet;
        private System.Windows.Forms.BindingSource account1BindingSource;
        private Data.CoffeeDataSetTableAdapters.Account1TableAdapter account1TableAdapter;
        private Data.CoffeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator account1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton account1BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fill_IDToolStrip;
        private System.Windows.Forms.ToolStripLabel maIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fill_IDToolStripButton;
    }
}