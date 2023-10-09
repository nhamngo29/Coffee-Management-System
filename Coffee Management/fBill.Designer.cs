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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBill));
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
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPageBill.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBill
            // 
            this.gcBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBill.Location = new System.Drawing.Point(0, 90);
            this.gcBill.MainView = this.gvBill;
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(694, 295);
            this.gcBill.TabIndex = 0;
            this.gcBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill});
            // 
            // gvBill
            // 
            this.gvBill.GridControl = this.gcBill;
            this.gvBill.Name = "gvBill";
            this.gvBill.OptionsBehavior.Editable = false;
            // 
            // deFromDate
            // 
            this.deFromDate.EditValue = null;
            this.deFromDate.Location = new System.Drawing.Point(74, 34);
            this.deFromDate.Name = "deFromDate";
            this.deFromDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.deToDate.Location = new System.Drawing.Point(531, 34);
            this.deToDate.Name = "deToDate";
            this.deToDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(462, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Đến ngày";
            // 
            // btnShowBill
            // 
            this.btnShowBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowBill.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBill.Appearance.Options.UseFont = true;
            this.btnShowBill.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShowBill.ImageOptions.SvgImage")));
            this.btnShowBill.Location = new System.Drawing.Point(264, 29);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(141, 33);
            this.btnShowBill.TabIndex = 5;
            this.btnShowBill.Text = "Xem";
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstPage.Location = new System.Drawing.Point(462, 392);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(22, 23);
            this.btnFirstPage.TabIndex = 6;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPreviours
            // 
            this.btnPreviours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviours.Location = new System.Drawing.Point(490, 392);
            this.btnPreviours.Name = "btnPreviours";
            this.btnPreviours.Size = new System.Drawing.Size(22, 23);
            this.btnPreviours.TabIndex = 7;
            this.btnPreviours.Text = "<";
            this.btnPreviours.Click += new System.EventHandler(this.btnPreviours_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastPage.Location = new System.Drawing.Point(575, 392);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(22, 23);
            this.btnLastPage.TabIndex = 9;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(547, 392);
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
            this.txtNumPageBill.Location = new System.Drawing.Point(519, 393);
            this.txtNumPageBill.Name = "txtNumPageBill";
            this.txtNumPageBill.Size = new System.Drawing.Size(22, 20);
            this.txtNumPageBill.TabIndex = 10;
            this.txtNumPageBill.TextChanged += new System.EventHandler(this.txtNumPageBill_TextChanged);
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 422);
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
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "fBill";
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.fBill_Load);
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
    }
}