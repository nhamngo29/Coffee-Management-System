namespace GUI
{
    partial class fBill
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBill));
            this.gvlvBillInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amnout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBill = new DevExpress.XtraGrid.GridControl();
            this.gvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.deFromDate = new DevExpress.XtraEditors.DateEdit();
            this.deToDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnShowBill = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirstPage = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreviours = new DevExpress.XtraEditors.SimpleButton();
            this.btnLastPage = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.txtNumPageBill = new DevExpress.XtraEditors.TextEdit();
            this.btnExportEx = new CustomComponent.ButtonBoTron();
            ((System.ComponentModel.ISupportInitialize)(this.gvlvBillInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPageBill.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvlvBillInfo
            // 
            this.gvlvBillInfo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvlvBillInfo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvlvBillInfo.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvlvBillInfo.Appearance.Row.Options.UseFont = true;
            this.gvlvBillInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Name,
            this.Amnout,
            this.Price,
            this.Total});
            this.gvlvBillInfo.GridControl = this.gcBill;
            this.gvlvBillInfo.Name = "gvlvBillInfo";
            // 
            // ID
            // 
            this.ID.Caption = "Mã món";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // Name
            // 
            this.Name.Caption = "Tên món";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 1;
            // 
            // Amnout
            // 
            this.Amnout.Caption = "Số lượng";
            this.Amnout.FieldName = "Amnout";
            this.Amnout.Name = "Amnout";
            this.Amnout.Visible = true;
            this.Amnout.VisibleIndex = 2;
            // 
            // Price
            // 
            this.Price.Caption = "Giá";
            this.Price.DisplayFormat.FormatString = "{0:0,0 VND}";
            this.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 3;
            // 
            // Total
            // 
            this.Total.Caption = "Tổng tiền";
            this.Total.DisplayFormat.FormatString = "{0:0,0 VND}";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 4;
            // 
            // gcBill
            // 
            this.gcBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode2.LevelTemplate = this.gvlvBillInfo;
            gridLevelNode2.RelationName = "Chi tiết hóa đơn";
            this.gcBill.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gcBill.Location = new System.Drawing.Point(0, 90);
            this.gcBill.MainView = this.gvBill;
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(961, 295);
            this.gcBill.TabIndex = 0;
            this.gcBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill,
            this.gvlvBillInfo});
            this.gcBill.Click += new System.EventHandler(this.gcBill_Click);
            // 
            // gvBill
            // 
            this.gvBill.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvBill.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.gvBill.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBill.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvBill.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvBill.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvBill.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvBill.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBill.Appearance.Row.Options.UseFont = true;
            this.gvBill.GridControl = this.gcBill;
            this.gvBill.Name = "gvBill";
            this.gvBill.OptionsBehavior.Editable = false;
            this.gvBill.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvBill_MasterRowEmpty);
            this.gvBill.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvBill_MasterRowGetChildList);
            this.gvBill.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvBill_MasterRowGetRelationName);
            this.gvBill.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvBill_MasterRowGetRelationCount);
            this.gvBill.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvBill_CustomColumnDisplayText);
            // 
            // deFromDate
            // 
            this.deFromDate.EditValue = null;
            this.deFromDate.Location = new System.Drawing.Point(74, 34);
            this.deFromDate.Name = "deFromDate";
            this.deFromDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.deFromDate.Properties.Appearance.Options.UseFont = true;
            this.deFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFromDate.Size = new System.Drawing.Size(151, 24);
            this.deFromDate.TabIndex = 1;
            // 
            // deToDate
            // 
            this.deToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deToDate.EditValue = null;
            this.deToDate.Location = new System.Drawing.Point(798, 34);
            this.deToDate.Name = "deToDate";
            this.deToDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.deToDate.Properties.Appearance.Options.UseFont = true;
            this.deToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Size = new System.Drawing.Size(151, 24);
            this.deToDate.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 18);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Từ ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(729, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Đến ngày";
            // 
            // btnShowBill
            // 
            this.btnShowBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowBill.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnShowBill.Appearance.Options.UseFont = true;
            this.btnShowBill.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShowBill.ImageOptions.SvgImage")));
            this.btnShowBill.Location = new System.Drawing.Point(397, 29);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(141, 33);
            this.btnShowBill.TabIndex = 5;
            this.btnShowBill.Text = "Xem";
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstPage.Location = new System.Drawing.Point(729, 392);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(22, 23);
            this.btnFirstPage.TabIndex = 6;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPreviours
            // 
            this.btnPreviours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviours.Location = new System.Drawing.Point(757, 392);
            this.btnPreviours.Name = "btnPreviours";
            this.btnPreviours.Size = new System.Drawing.Size(22, 23);
            this.btnPreviours.TabIndex = 7;
            this.btnPreviours.Text = "<";
            this.btnPreviours.Click += new System.EventHandler(this.btnPreviours_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastPage.Location = new System.Drawing.Point(842, 392);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(22, 23);
            this.btnLastPage.TabIndex = 9;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(814, 392);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(22, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtNumPageBill
            // 
            this.txtNumPageBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumPageBill.EditValue = "1";
            this.txtNumPageBill.Location = new System.Drawing.Point(786, 393);
            this.txtNumPageBill.Name = "txtNumPageBill";
            this.txtNumPageBill.Size = new System.Drawing.Size(22, 20);
            this.txtNumPageBill.TabIndex = 10;
            this.txtNumPageBill.TextChanged += new System.EventHandler(this.txtNumPageBill_TextChanged);
            // 
            // btnExportEx
            // 
            this.btnExportEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExportEx.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExportEx.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExportEx.BorderRadius = 10;
            this.btnExportEx.BorderSize = 0;
            this.btnExportEx.FlatAppearance.BorderSize = 0;
            this.btnExportEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportEx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportEx.ForeColor = System.Drawing.Color.White;
            this.btnExportEx.Image = ((System.Drawing.Image)(resources.GetObject("btnExportEx.Image")));
            this.btnExportEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportEx.Location = new System.Drawing.Point(13, 387);
            this.btnExportEx.Name = "btnExportEx";
            this.btnExportEx.Size = new System.Drawing.Size(92, 32);
            this.btnExportEx.TabIndex = 11;
            this.btnExportEx.Text = "Xuất";
            this.btnExportEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportEx.TextColor = System.Drawing.Color.White;
            this.btnExportEx.UseVisualStyleBackColor = false;
            this.btnExportEx.Click += new System.EventHandler(this.btnExportEx_Click);
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 422);
            this.Controls.Add(this.btnExportEx);
            this.Controls.Add(this.txtNumPageBill);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPreviours);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnShowBill);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deToDate);
            this.Controls.Add(this.deFromDate);
            this.Controls.Add(this.gcBill);

            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.fBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvlvBillInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPageBill.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill;
        private DevExpress.XtraEditors.DateEdit deFromDate;
        private DevExpress.XtraEditors.DateEdit deToDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnShowBill;
        private DevExpress.XtraEditors.SimpleButton btnFirstPage;
        private DevExpress.XtraEditors.SimpleButton btnPreviours;
        private DevExpress.XtraEditors.SimpleButton btnLastPage;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.TextEdit txtNumPageBill;
        private CustomComponent.ButtonBoTron btnExportEx;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlvBillInfo;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn Amnout;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
    }
}