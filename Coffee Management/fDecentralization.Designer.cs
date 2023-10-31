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
            this.account1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDataSet = new GUI.Data.CoffeeDataSet();
            this.account1TableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.Account1TableAdapter();
            this.tableAdapterManager = new GUI.Data.CoffeeDataSetTableAdapters.TableAdapterManager();
            this.accountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTypeTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.AccountTypeTableAdapter();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.NhomNguoiDungTableAdapter();
            this.nhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.phanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanQuyenTableAdapter = new GUI.Data.CoffeeDataSetTableAdapters.PhanQuyenTableAdapter();
            this.phanQuyenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.account1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // account1BindingSource
            // 
            this.account1BindingSource.DataMember = "Account1";
            this.account1BindingSource.DataSource = this.coffeeDataSet;
            // 
            // coffeeDataSet
            // 
            this.coffeeDataSet.DataSetName = "CoffeeDataSet";
            this.coffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // nhomNguoiDungBindingSource
            // 
            this.nhomNguoiDungBindingSource.DataMember = "NhomNguoiDung";
            this.nhomNguoiDungBindingSource.DataSource = this.coffeeDataSet;
            // 
            // nhomNguoiDungTableAdapter
            // 
            this.nhomNguoiDungTableAdapter.ClearBeforeFill = true;
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
            this.nhomNguoiDungDataGridView.Location = new System.Drawing.Point(12, 74);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 52);
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
            this.phanQuyenDataGridView.Location = new System.Drawing.Point(12, 200);
            this.phanQuyenDataGridView.Name = "phanQuyenDataGridView";
            this.phanQuyenDataGridView.Size = new System.Drawing.Size(344, 220);
            this.phanQuyenDataGridView.TabIndex = 2;
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
            this.ClientSize = new System.Drawing.Size(1146, 446);
            this.Controls.Add(this.phanQuyenDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nhomNguoiDungDataGridView);
            this.Name = "fDecentralization";
            this.Text = "fDecentralization";
            this.Load += new System.EventHandler(this.fDecentralization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.account1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource phanQuyenBindingSource;
        private Data.CoffeeDataSetTableAdapters.PhanQuyenTableAdapter phanQuyenTableAdapter;
        private System.Windows.Forms.DataGridView phanQuyenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}