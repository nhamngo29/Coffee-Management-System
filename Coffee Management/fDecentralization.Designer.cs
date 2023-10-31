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
            System.Windows.Forms.Label nameLabel;
            this.nhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDataSet = new GUI.Data.CoffeeDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.phanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.account1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.account1TableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.Account1TableAdapter();
            this.tableAdapterManager = new GUI.Data.CoffeeDataSetTableAdapters.TableAdapterManager();
            this.accountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTypeTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.AccountTypeTableAdapter();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.NhomNguoiDungTableAdapter();
            this.phanQuyenTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.PhanQuyenTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.nhomNguoiDungBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.tb_PhanQuynBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_PhanQuynTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.tb_PhanQuynTableAdapter();
            this.fill_pqToolStrip = new System.Windows.Forms.ToolStrip();
            this.tenToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tenToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fill_pqToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tb_PhanQuynDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PhanQuynBindingSource)).BeginInit();
            this.fill_pqToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PhanQuynDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(668, 98);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(123, 20);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Loại người dùng";
            // 
            // nhomNguoiDungDataGridView
            // 
            this.nhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.nhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.nhomNguoiDungDataGridView.DataSource = this.nhomNguoiDungBindingSource;
            this.nhomNguoiDungDataGridView.Location = new System.Drawing.Point(12, 159);
            this.nhomNguoiDungDataGridView.Name = "nhomNguoiDungDataGridView";
            this.nhomNguoiDungDataGridView.Size = new System.Drawing.Size(345, 100);
            this.nhomNguoiDungDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AccountTypeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "AccountTypeID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // nhomNguoiDungBindingSource
            // 
            this.nhomNguoiDungBindingSource.DataMember = "NhomNguoiDung";
            this.nhomNguoiDungBindingSource.DataSource = this.coffeeDataSet;
            // 
            // coffeeDataSet
            // 
            this.coffeeDataSet.DataSetName = "CoffeeDataSet";
            this.coffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách nhóm người dùng";
            // 
            // phanQuyenBindingSource
            // 
            this.phanQuyenBindingSource.DataMember = "PhanQuyen";
            this.phanQuyenBindingSource.DataSource = this.coffeeDataSet;
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
            // accountTypeBindingSource
            // 
            this.accountTypeBindingSource.DataMember = "AccountType";
            this.accountTypeBindingSource.DataSource = this.coffeeDataSet;
            // 
            // accountTypeTableAdapter
            // 
            this.accountTypeTableAdapter.ClearBeforeFill = true;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.coffeeDataSet;
            // 
            // nhomNguoiDungTableAdapter
            // 
            this.nhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // phanQuyenTableAdapter
            // 
            this.phanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách chức năng";
            // 
            // nhomNguoiDungBindingSource1
            // 
            this.nhomNguoiDungBindingSource1.DataMember = "NhomNguoiDung";
            this.nhomNguoiDungBindingSource1.DataSource = this.coffeeDataSet;
            // 
            // nhomNguoiDungComboBox
            // 
            this.nhomNguoiDungComboBox.DataSource = this.nhomNguoiDungBindingSource1;
            this.nhomNguoiDungComboBox.DisplayMember = "Name";
            this.nhomNguoiDungComboBox.FormattingEnabled = true;
            this.nhomNguoiDungComboBox.Location = new System.Drawing.Point(816, 100);
            this.nhomNguoiDungComboBox.Name = "nhomNguoiDungComboBox";
            this.nhomNguoiDungComboBox.Size = new System.Drawing.Size(248, 21);
            this.nhomNguoiDungComboBox.TabIndex = 7;
            this.nhomNguoiDungComboBox.ValueMember = "MaNhomNguoiDung";
            this.nhomNguoiDungComboBox.SelectedIndexChanged += new System.EventHandler(this.nhomNguoiDungComboBox_SelectedIndexChanged);
            // 
            // tb_PhanQuynBindingSource
            // 
            this.tb_PhanQuynBindingSource.DataMember = "tb_PhanQuyn";
            this.tb_PhanQuynBindingSource.DataSource = this.coffeeDataSet;
            // 
            // tb_PhanQuynTableAdapter
            // 
            this.tb_PhanQuynTableAdapter.ClearBeforeFill = true;
            // 
            // fill_pqToolStrip
            // 
            this.fill_pqToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tenToolStripLabel,
            this.tenToolStripTextBox,
            this.fill_pqToolStripButton});
            this.fill_pqToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fill_pqToolStrip.Name = "fill_pqToolStrip";
            this.fill_pqToolStrip.Size = new System.Drawing.Size(1200, 25);
            this.fill_pqToolStrip.TabIndex = 8;
            this.fill_pqToolStrip.Text = "fill_pqToolStrip";
            // 
            // tenToolStripLabel
            // 
            this.tenToolStripLabel.Name = "tenToolStripLabel";
            this.tenToolStripLabel.Size = new System.Drawing.Size(27, 22);
            this.tenToolStripLabel.Text = "ten:";
            // 
            // tenToolStripTextBox
            // 
            this.tenToolStripTextBox.Name = "tenToolStripTextBox";
            this.tenToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fill_pqToolStripButton
            // 
            this.fill_pqToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fill_pqToolStripButton.Name = "fill_pqToolStripButton";
            this.fill_pqToolStripButton.Size = new System.Drawing.Size(45, 19);
            this.fill_pqToolStripButton.Text = "Fill_pq";
            this.fill_pqToolStripButton.Click += new System.EventHandler(this.fill_pqToolStripButton_Click);
            // 
            // tb_PhanQuynDataGridView
            // 
            this.tb_PhanQuynDataGridView.AutoGenerateColumns = false;
            this.tb_PhanQuynDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_PhanQuynDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6});
            this.tb_PhanQuynDataGridView.DataSource = this.tb_PhanQuynBindingSource;
            this.tb_PhanQuynDataGridView.Location = new System.Drawing.Point(616, 159);
            this.tb_PhanQuynDataGridView.Name = "tb_PhanQuynDataGridView";
            this.tb_PhanQuynDataGridView.Size = new System.Drawing.Size(448, 220);
            this.tb_PhanQuynDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "TenManHinh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TenNhomNguoiDung";
            this.dataGridViewTextBoxColumn6.HeaderText = "TenNhomNguoiDung";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // fDecentralization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 606);
            this.Controls.Add(this.tb_PhanQuynDataGridView);
            this.Controls.Add(this.fill_pqToolStrip);
            this.Controls.Add(this.nhomNguoiDungComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nhomNguoiDungDataGridView);
            this.Name = "fDecentralization";
            this.Text = "fDecentralization";
            this.Load += new System.EventHandler(this.fDecentralization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PhanQuynBindingSource)).EndInit();
            this.fill_pqToolStrip.ResumeLayout(false);
            this.fill_pqToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PhanQuynDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.CoffeeDataSet coffeeDataSet;
        private System.Windows.Forms.BindingSource account1BindingSource;
        private Data.CoffeeDataSetTableAdapters.Account1TableAdapter account1TableAdapter;
        private Data.CoffeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource accountTypeBindingSource;
        private Data.CoffeeDataSetTableAdapters.AccountTypeTableAdapter accountTypeTableAdapter;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.BindingSource nhomNguoiDungBindingSource;
        private Data.CoffeeDataSetTableAdapters.NhomNguoiDungTableAdapter nhomNguoiDungTableAdapter;
        private System.Windows.Forms.DataGridView nhomNguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource phanQuyenBindingSource;
        private Data.CoffeeDataSetTableAdapters.PhanQuyenTableAdapter phanQuyenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource nhomNguoiDungBindingSource1;
        private System.Windows.Forms.ComboBox nhomNguoiDungComboBox;
        private System.Windows.Forms.BindingSource tb_PhanQuynBindingSource;
        private Data.CoffeeDataSetTableAdapters.tb_PhanQuynTableAdapter tb_PhanQuynTableAdapter;
        private System.Windows.Forms.ToolStrip fill_pqToolStrip;
        private System.Windows.Forms.ToolStripLabel tenToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tenToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fill_pqToolStripButton;
        private System.Windows.Forms.DataGridView tb_PhanQuynDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}