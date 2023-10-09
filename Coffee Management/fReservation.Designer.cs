namespace GUI
{
    partial class fReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReservation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowBill = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deToDate = new DevExpress.XtraEditors.DateEdit();
            this.deFromDate = new DevExpress.XtraEditors.DateEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookingDKGridControl = new DevExpress.XtraGrid.GridControl();
            this.bookingDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDataSet = new GUI.CoffeeDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBookingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bookingDKTableAdapter = new GUI.CoffeeDataSetTableAdapters.BookingDKTableAdapter();
            this.tableAdapterManager = new GUI.CoffeeDataSetTableAdapters.TableAdapterManager();
            this.bookingDKBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bookingDKBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDKBindingNavigator)).BeginInit();
            this.bookingDKBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowBill);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.deToDate);
            this.panel1.Controls.Add(this.deFromDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 63);
            this.panel1.TabIndex = 0;
            // 
            // btnShowBill
            // 
            this.btnShowBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowBill.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnShowBill.Appearance.Options.UseFont = true;
            this.btnShowBill.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShowBill.ImageOptions.SvgImage")));
            this.btnShowBill.Location = new System.Drawing.Point(466, 12);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(141, 33);
            this.btnShowBill.TabIndex = 10;
            this.btnShowBill.Text = "Xem";
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(664, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 18);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Đến ngày";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(214, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Từ ngày";
            // 
            // deToDate
            // 
            this.deToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deToDate.EditValue = null;
            this.deToDate.Location = new System.Drawing.Point(733, 17);
            this.deToDate.Name = "deToDate";
            this.deToDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.deToDate.Properties.Appearance.Options.UseFont = true;
            this.deToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deToDate.Size = new System.Drawing.Size(151, 24);
            this.deToDate.TabIndex = 6;
            // 
            // deFromDate
            // 
            this.deFromDate.EditValue = new System.DateTime(2023, 10, 9, 0, 29, 46, 0);
            this.deFromDate.Location = new System.Drawing.Point(276, 17);
            this.deFromDate.Name = "deFromDate";
            this.deFromDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.deFromDate.Properties.Appearance.Options.UseFont = true;
            this.deFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFromDate.Size = new System.Drawing.Size(151, 24);
            this.deFromDate.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bookingDKGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 522);
            this.panel2.TabIndex = 1;
            // 
            // bookingDKGridControl
            // 
            this.bookingDKGridControl.DataSource = this.bookingDKBindingSource;
            this.bookingDKGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingDKGridControl.Location = new System.Drawing.Point(0, 0);
            this.bookingDKGridControl.MainView = this.gridView1;
            this.bookingDKGridControl.Name = "bookingDKGridControl";
            this.bookingDKGridControl.Size = new System.Drawing.Size(1124, 522);
            this.bookingDKGridControl.TabIndex = 0;
            this.bookingDKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bookingDKBindingSource
            // 
            this.bookingDKBindingSource.DataMember = "BookingDK";
            this.bookingDKBindingSource.DataSource = this.coffeeDataSet;
            // 
            // coffeeDataSet
            // 
            this.coffeeDataSet.DataSetName = "CoffeeDataSet";
            this.coffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFullName,
            this.colEmail,
            this.colNumberPhone,
            this.colQuantity,
            this.colBookingTime,
            this.colNote,
            this.colstatus});
            this.gridView1.GridControl = this.bookingDKGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            // 
            // colNumberPhone
            // 
            this.colNumberPhone.FieldName = "NumberPhone";
            this.colNumberPhone.Name = "colNumberPhone";
            this.colNumberPhone.Visible = true;
            this.colNumberPhone.VisibleIndex = 3;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 4;
            // 
            // colBookingTime
            // 
            this.colBookingTime.FieldName = "BookingTime";
            this.colBookingTime.Name = "colBookingTime";
            this.colBookingTime.Visible = true;
            this.colBookingTime.VisibleIndex = 5;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 6;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 7;
            // 
            // bookingDKTableAdapter
            // 
            this.bookingDKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AccountTypeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillInfoTableAdapter = null;
            this.tableAdapterManager.BillTableAdapter = null;
            this.tableAdapterManager.BookingDKTableAdapter = this.bookingDKTableAdapter;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.CategoryFoodTableAdapter = null;
            this.tableAdapterManager.discountTableAdapter = null;
            this.tableAdapterManager.FoodTableAdapter = null;
            this.tableAdapterManager.ReservationsTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.TableCoffeeTableAdapter = null;
            this.tableAdapterManager.TypeFoodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.CoffeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookingDKBindingNavigator
            // 
            this.bookingDKBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookingDKBindingNavigator.BindingSource = this.bookingDKBindingSource;
            this.bookingDKBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookingDKBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookingDKBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookingDKBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bookingDKBindingNavigatorSaveItem});
            this.bookingDKBindingNavigator.Location = new System.Drawing.Point(0, 560);
            this.bookingDKBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookingDKBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookingDKBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookingDKBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookingDKBindingNavigator.Name = "bookingDKBindingNavigator";
            this.bookingDKBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookingDKBindingNavigator.Size = new System.Drawing.Size(1124, 25);
            this.bookingDKBindingNavigator.TabIndex = 2;
            this.bookingDKBindingNavigator.Text = "bindingNavigator1";
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
            // bookingDKBindingNavigatorSaveItem
            // 
            this.bookingDKBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingDKBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingDKBindingNavigatorSaveItem.Image")));
            this.bookingDKBindingNavigatorSaveItem.Name = "bookingDKBindingNavigatorSaveItem";
            this.bookingDKBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bookingDKBindingNavigatorSaveItem.Text = "Save Data";
            this.bookingDKBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookingDKBindingNavigatorSaveItem_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1124, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 585);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1124, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 585);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1124, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 585);
            // 
            // fReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 585);
            this.Controls.Add(this.bookingDKBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "fReservation";
            this.Text = "fReservation";
            this.Load += new System.EventHandler(this.fReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDKBindingNavigator)).EndInit();
            this.bookingDKBindingNavigator.ResumeLayout(false);
            this.bookingDKBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnShowBill;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deToDate;
        private DevExpress.XtraEditors.DateEdit deFromDate;
        private System.Windows.Forms.Panel panel2;
        private CoffeeDataSet coffeeDataSet;
        private System.Windows.Forms.BindingSource bookingDKBindingSource;
        private CoffeeDataSetTableAdapters.BookingDKTableAdapter bookingDKTableAdapter;
        private CoffeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookingDKBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bookingDKBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl bookingDKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colBookingTime;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}