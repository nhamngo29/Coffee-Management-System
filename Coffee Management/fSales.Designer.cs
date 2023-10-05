namespace Coffee_Management
{
    partial class fSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSales));
            this.grBanAn = new System.Windows.Forms.GroupBox();
            this.flpListTable = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new CustomComponent.ButtonBoTron();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lkedPickTable = new DevExpress.XtraEditors.LookUpEdit();
            this.btnBillardTable = new CustomComponent.ButtonBoTron();
            this.btnChangeTable = new CustomComponent.ButtonBoTron();
            this.btnEdit = new CustomComponent.ButtonBoTron();
            this.btnAddFood = new CustomComponent.ButtonBoTron();
            this.pbxBox = new System.Windows.Forms.PictureBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbNumberTb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.spAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lkedPickType = new DevExpress.XtraEditors.LookUpEdit();
            this.lkedPickCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lkedPickFood = new DevExpress.XtraEditors.LookUpEdit();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.grBanAn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickFood.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grBanAn
            // 
            this.grBanAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBanAn.Controls.Add(this.flpListTable);
            this.grBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grBanAn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBanAn.ForeColor = System.Drawing.Color.Black;
            this.grBanAn.Location = new System.Drawing.Point(12, 3);
            this.grBanAn.Name = "grBanAn";
            this.grBanAn.Size = new System.Drawing.Size(536, 807);
            this.grBanAn.TabIndex = 0;
            this.grBanAn.TabStop = false;
            this.grBanAn.Text = "Bán ăn";
            this.grBanAn.Enter += new System.EventHandler(this.grBanAn_Enter);
            // 
            // flpListTable
            // 
            this.flpListTable.AutoScroll = true;
            this.flpListTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListTable.Location = new System.Drawing.Point(3, 29);
            this.flpListTable.Name = "flpListTable";
            this.flpListTable.Size = new System.Drawing.Size(530, 775);
            this.flpListTable.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.txtTotalPrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lkedPickTable);
            this.groupBox2.Controls.Add(this.btnBillardTable);
            this.groupBox2.Controls.Add(this.btnChangeTable);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAddFood);
            this.groupBox2.Controls.Add(this.pbxBox);
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbNumberTb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.spAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lkedPickType);
            this.groupBox2.Controls.Add(this.lkedPickCategory);
            this.groupBox2.Controls.Add(this.lkedPickFood);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(554, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 806);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gọi món";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.BackColor = System.Drawing.Color.Silver;
            this.btnCheck.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCheck.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCheck.BorderRadius = 5;
            this.btnCheck.BorderSize = 0;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.Location = new System.Drawing.Point(468, 747);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(148, 40);
            this.btnCheck.TabIndex = 28;
            this.btnCheck.Text = "Thanh toán";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.TextColor = System.Drawing.Color.White;
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txtTotalPrice.Location = new System.Drawing.Point(113, 758);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(59, 21);
            this.txtTotalPrice.TabIndex = 27;
            this.txtTotalPrice.Text = "0 VNĐ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 758);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tổng tiền:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lsvBill);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 389);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các món đã gọi";
            // 
            // lsvBill
            // 
            this.lsvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 24);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(582, 355);
            this.lsvBill.TabIndex = 43;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 204;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 191;
            // 
            // lkedPickTable
            // 
            this.lkedPickTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkedPickTable.Location = new System.Drawing.Point(312, 320);
            this.lkedPickTable.Name = "lkedPickTable";
            this.lkedPickTable.Properties.AllowMouseWheel = false;
            this.lkedPickTable.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.lkedPickTable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkedPickTable.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lkedPickTable.Properties.Appearance.Options.UseBackColor = true;
            this.lkedPickTable.Properties.Appearance.Options.UseFont = true;
            this.lkedPickTable.Properties.Appearance.Options.UseForeColor = true;
            this.lkedPickTable.Properties.AutoHeight = false;
            this.lkedPickTable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkedPickTable.Properties.NullText = "-- Chọn bàn --";
            this.lkedPickTable.Size = new System.Drawing.Size(286, 33);
            this.lkedPickTable.TabIndex = 24;
            // 
            // btnBillardTable
            // 
            this.btnBillardTable.BackColor = System.Drawing.Color.Silver;
            this.btnBillardTable.BackgroundColor = System.Drawing.Color.Silver;
            this.btnBillardTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBillardTable.BorderRadius = 5;
            this.btnBillardTable.BorderSize = 0;
            this.btnBillardTable.FlatAppearance.BorderSize = 0;
            this.btnBillardTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillardTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillardTable.ForeColor = System.Drawing.Color.White;
            this.btnBillardTable.Image = ((System.Drawing.Image)(resources.GetObject("btnBillardTable.Image")));
            this.btnBillardTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillardTable.Location = new System.Drawing.Point(484, 274);
            this.btnBillardTable.Name = "btnBillardTable";
            this.btnBillardTable.Size = new System.Drawing.Size(114, 40);
            this.btnBillardTable.TabIndex = 23;
            this.btnBillardTable.Text = "Gộp bàn";
            this.btnBillardTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBillardTable.TextColor = System.Drawing.Color.White;
            this.btnBillardTable.UseVisualStyleBackColor = false;
            this.btnBillardTable.Click += new System.EventHandler(this.btnBillardTable_Click);
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.BackColor = System.Drawing.Color.Silver;
            this.btnChangeTable.BackgroundColor = System.Drawing.Color.Silver;
            this.btnChangeTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangeTable.BorderRadius = 5;
            this.btnChangeTable.BorderSize = 0;
            this.btnChangeTable.FlatAppearance.BorderSize = 0;
            this.btnChangeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTable.ForeColor = System.Drawing.Color.White;
            this.btnChangeTable.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeTable.Image")));
            this.btnChangeTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeTable.Location = new System.Drawing.Point(312, 274);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(142, 40);
            this.btnChangeTable.TabIndex = 22;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeTable.TextColor = System.Drawing.Color.White;
            this.btnChangeTable.UseVisualStyleBackColor = false;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Silver;
            this.btnEdit.BackgroundColor = System.Drawing.Color.Silver;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(165, 274);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 40);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Sửa đổi";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Silver;
            this.btnAddFood.BackgroundColor = System.Drawing.Color.Silver;
            this.btnAddFood.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddFood.BorderRadius = 5;
            this.btnAddFood.BorderSize = 0;
            this.btnAddFood.FlatAppearance.BorderSize = 0;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.Image")));
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(30, 274);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(119, 40);
            this.btnAddFood.TabIndex = 20;
            this.btnAddFood.Text = "Gọi món";
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFood.TextColor = System.Drawing.Color.White;
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // pbxBox
            // 
            this.pbxBox.Image = ((System.Drawing.Image)(resources.GetObject("pbxBox.Image")));
            this.pbxBox.Location = new System.Drawing.Point(384, 48);
            this.pbxBox.Name = "pbxBox";
            this.pbxBox.Size = new System.Drawing.Size(184, 172);
            this.pbxBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBox.TabIndex = 19;
            this.pbxBox.TabStop = false;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(259, 230);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(73, 21);
            this.lbStatus.TabIndex = 17;
            this.lbStatus.Text = "Sẵn sàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(155, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Trang thái:";
            // 
            // lbNumberTb
            // 
            this.lbNumberTb.AutoSize = true;
            this.lbNumberTb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberTb.ForeColor = System.Drawing.Color.Red;
            this.lbNumberTb.Location = new System.Drawing.Point(113, 230);
            this.lbNumberTb.Name = "lbNumberTb";
            this.lbNumberTb.Size = new System.Drawing.Size(19, 21);
            this.lbNumberTb.TabIndex = 15;
            this.lbNumberTb.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số bàn:";
            // 
            // spAmount
            // 
            this.spAmount.BackColor = System.Drawing.Color.Silver;
            this.spAmount.ForeColor = System.Drawing.Color.White;
            this.spAmount.Location = new System.Drawing.Point(135, 173);
            this.spAmount.Name = "spAmount";
            this.spAmount.Size = new System.Drawing.Size(120, 33);
            this.spAmount.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chọn món:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn thể loại:";
            // 
            // lkedPickType
            // 
            this.lkedPickType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkedPickType.Location = new System.Drawing.Point(135, 96);
            this.lkedPickType.Name = "lkedPickType";
            this.lkedPickType.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.lkedPickType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkedPickType.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lkedPickType.Properties.Appearance.Options.UseBackColor = true;
            this.lkedPickType.Properties.Appearance.Options.UseFont = true;
            this.lkedPickType.Properties.Appearance.Options.UseForeColor = true;
            this.lkedPickType.Properties.AutoHeight = false;
            this.lkedPickType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkedPickType.Properties.NullText = "-- Chọn loại --";
            this.lkedPickType.Size = new System.Drawing.Size(189, 32);
            this.lkedPickType.TabIndex = 5;
            this.lkedPickType.EditValueChanged += new System.EventHandler(this.lkedPickType_EditValueChanged);
            // 
            // lkedPickCategory
            // 
            this.lkedPickCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkedPickCategory.Location = new System.Drawing.Point(135, 57);
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
            this.lkedPickCategory.TabIndex = 4;
            this.lkedPickCategory.EditValueChanged += new System.EventHandler(this.lkedPickCategory_EditValueChanged);
            // 
            // lkedPickFood
            // 
            this.lkedPickFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkedPickFood.Location = new System.Drawing.Point(135, 135);
            this.lkedPickFood.Name = "lkedPickFood";
            this.lkedPickFood.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.lkedPickFood.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkedPickFood.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lkedPickFood.Properties.Appearance.Options.UseBackColor = true;
            this.lkedPickFood.Properties.Appearance.Options.UseFont = true;
            this.lkedPickFood.Properties.Appearance.Options.UseForeColor = true;
            this.lkedPickFood.Properties.AutoHeight = false;
            this.lkedPickFood.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkedPickFood.Properties.NullText = "-- Chọn món --";
            this.lkedPickFood.Size = new System.Drawing.Size(189, 32);
            this.lkedPickFood.TabIndex = 6;
            this.lkedPickFood.EditValueChanged += new System.EventHandler(this.lkedPickFood_EditValueChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "check-1-icon.png");
            this.imageList.Images.SetKeyName(1, "Check-2-icon.png");
            this.imageList.Images.SetKeyName(2, "add-icon.png");
            // 
            // fSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 820);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grBanAn);
            this.Name = "fSales";
            this.Text = "Gọi món";
            this.grBanAn.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickFood.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBanAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LookUpEdit lkedPickType;
        private DevExpress.XtraEditors.LookUpEdit lkedPickCategory;
        private DevExpress.XtraEditors.LookUpEdit lkedPickFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spAmount;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNumberTb;
        private System.Windows.Forms.Label label5;
        private CustomComponent.ButtonBoTron btnEdit;
        private CustomComponent.ButtonBoTron btnAddFood;
        private System.Windows.Forms.PictureBox pbxBox;
        private CustomComponent.ButtonBoTron btnBillardTable;
        private CustomComponent.ButtonBoTron btnChangeTable;
        private DevExpress.XtraEditors.LookUpEdit lkedPickTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomComponent.ButtonBoTron btnCheck;
        private System.Windows.Forms.Label txtTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.FlowLayoutPanel flpListTable;
        private System.Windows.Forms.ImageList imageList;
    }
}