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
            this.nhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDataSet = new GUI.Data.CoffeeDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.screenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.account1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.account1TableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.Account1TableAdapter();
            this.tableAdapterManager = new GUI.Data.CoffeeDataSetTableAdapters.TableAdapterManager();
            this.accountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTypeTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.AccountTypeTableAdapter();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.NhomNguoiDungTableAdapter();
            this.nhomNguoiDungBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.screenTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.ScreenTableAdapter();
            this.getPhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPhanQuyenTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.getPhanQuyenTableAdapter();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPhanQuyenDataGridView = new System.Windows.Forms.DataGridView();
            this.phanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanQuyenTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.PhanQuyenTableAdapter();
            this.phanQuyenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPhanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPhanQuyenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.nhomNguoiDungDataGridView.Location = new System.Drawing.Point(12, 75);
            this.nhomNguoiDungDataGridView.Name = "nhomNguoiDungDataGridView";
            this.nhomNguoiDungDataGridView.Size = new System.Drawing.Size(345, 100);
            this.nhomNguoiDungDataGridView.TabIndex = 0;
            this.nhomNguoiDungDataGridView.SelectionChanged += new System.EventHandler(this.nhomNguoiDungDataGridView_SelectionChanged);
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
            this.label2.Location = new System.Drawing.Point(51, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách nhóm người dùng";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách chức năng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh sách nhóm màn hình chứ năng";
            // 
            // screenDataGridView
            // 
            this.screenDataGridView.AutoGenerateColumns = false;
            this.screenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.screenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.screenDataGridView.DataSource = this.screenBindingSource;
            this.screenDataGridView.Location = new System.Drawing.Point(12, 215);
            this.screenDataGridView.Name = "screenDataGridView";
            this.screenDataGridView.Size = new System.Drawing.Size(345, 252);
            this.screenDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.FillWeight = 200F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // screenBindingSource
            // 
            this.screenBindingSource.DataMember = "Screen";
            this.screenBindingSource.DataSource = this.coffeeDataSet;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(819, 437);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(83, 30);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            // nhomNguoiDungBindingSource1
            // 
            this.nhomNguoiDungBindingSource1.DataMember = "NhomNguoiDung";
            this.nhomNguoiDungBindingSource1.DataSource = this.coffeeDataSet;
            // 
            // screenTableAdapter
            // 
            this.screenTableAdapter.ClearBeforeFill = true;
            // 
            // getPhanQuyenBindingSource
            // 
            this.getPhanQuyenBindingSource.DataMember = "getPhanQuyen";
            this.getPhanQuyenBindingSource.DataSource = this.coffeeDataSet;
            // 
            // getPhanQuyenTableAdapter
            // 
            this.getPhanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "CoQuyen";
            this.dataGridViewCheckBoxColumn2.HeaderText = "CoQuyen";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // getPhanQuyenDataGridView
            // 
            this.getPhanQuyenDataGridView.AutoGenerateColumns = false;
            this.getPhanQuyenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getPhanQuyenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn2});
            this.getPhanQuyenDataGridView.DataSource = this.getPhanQuyenBindingSource;
            this.getPhanQuyenDataGridView.Location = new System.Drawing.Point(965, 215);
            this.getPhanQuyenDataGridView.Name = "getPhanQuyenDataGridView";
            this.getPhanQuyenDataGridView.Size = new System.Drawing.Size(347, 220);
            this.getPhanQuyenDataGridView.TabIndex = 9;
            // 
            // phanQuyenBindingSource
            // 
            this.phanQuyenBindingSource.DataMember = "PhanQuyen";
            this.phanQuyenBindingSource.DataSource = this.coffeeDataSet;
            // 
            // phanQuyenTableAdapter
            // 
            this.phanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // phanQuyenDataGridView
            // 
            this.phanQuyenDataGridView.AutoGenerateColumns = false;
            this.phanQuyenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanQuyenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.phanQuyenDataGridView.DataSource = this.phanQuyenBindingSource;
            this.phanQuyenDataGridView.Location = new System.Drawing.Point(420, 215);
            this.phanQuyenDataGridView.Name = "phanQuyenDataGridView";
            this.phanQuyenDataGridView.Size = new System.Drawing.Size(347, 252);
            this.phanQuyenDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdCreen";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdCreen";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // fDecentralization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 618);
            this.Controls.Add(this.phanQuyenDataGridView);
            this.Controls.Add(this.getPhanQuyenDataGridView);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.screenDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nhomNguoiDungDataGridView);
            this.Name = "fDecentralization";
            this.Text = "fDecentralization";
            this.Load += new System.EventHandler(this.fDecentralization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPhanQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPhanQuyenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDataGridView)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource nhomNguoiDungBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource screenBindingSource;
        private Data.CoffeeDataSetTableAdapters.ScreenTableAdapter screenTableAdapter;
        private System.Windows.Forms.DataGridView screenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.BindingSource getPhanQuyenBindingSource;
        private Data.CoffeeDataSetTableAdapters.getPhanQuyenTableAdapter getPhanQuyenTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView getPhanQuyenDataGridView;
        private System.Windows.Forms.BindingSource phanQuyenBindingSource;
        private Data.CoffeeDataSetTableAdapters.PhanQuyenTableAdapter phanQuyenTableAdapter;
        private System.Windows.Forms.DataGridView phanQuyenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}