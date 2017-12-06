namespace Sales_Manager
{
    partial class Form1
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
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Item_textBox = new System.Windows.Forms.TextBox();
            this.Cost_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Quantity_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.report_A_button = new System.Windows.Forms.Button();
            this.report_B_button = new System.Windows.Forms.Button();
            this.report_C_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Test_button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date_label = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Folder_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sales_manager_DBDataSet = new Sales_Manager.Sales_manager_DBDataSet();
            this.salesmanagerDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Sales_Manager.Sales_manager_DBDataSetTableAdapters.ClientTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Sales_Manager.Sales_manager_DBDataSetTableAdapters.OrdersTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_FK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_manager_DBDataSet1 = new Sales_Manager.Sales_manager_DBDataSet();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_manager_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanagerDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_manager_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(12, 33);
            this.Name_textBox.Multiline = true;
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(246, 19);
            this.Name_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order item";
            // 
            // Item_textBox
            // 
            this.Item_textBox.Location = new System.Drawing.Point(295, 33);
            this.Item_textBox.Name = "Item_textBox";
            this.Item_textBox.Size = new System.Drawing.Size(179, 20);
            this.Item_textBox.TabIndex = 3;
            // 
            // Cost_textBox
            // 
            this.Cost_textBox.Location = new System.Drawing.Point(480, 33);
            this.Cost_textBox.Name = "Cost_textBox";
            this.Cost_textBox.Size = new System.Drawing.Size(59, 20);
            this.Cost_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost of item";
            // 
            // Quantity_textBox
            // 
            this.Quantity_textBox.Location = new System.Drawing.Point(561, 33);
            this.Quantity_textBox.Name = "Quantity_textBox";
            this.Quantity_textBox.Size = new System.Drawing.Size(70, 20);
            this.Quantity_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order quantity";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(12, 124);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(619, 34);
            this.Add_button.TabIndex = 8;
            this.Add_button.Text = "Add order";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.orderItemDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.ordersBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(12, 164);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(619, 166);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // report_A_button
            // 
            this.report_A_button.Enabled = false;
            this.report_A_button.Location = new System.Drawing.Point(343, 336);
            this.report_A_button.Name = "report_A_button";
            this.report_A_button.Size = new System.Drawing.Size(90, 23);
            this.report_A_button.TabIndex = 10;
            this.report_A_button.Text = "Save Report A";
            this.report_A_button.UseVisualStyleBackColor = true;
            this.report_A_button.Click += new System.EventHandler(this.report_A_button_Click);
            // 
            // report_B_button
            // 
            this.report_B_button.Enabled = false;
            this.report_B_button.Location = new System.Drawing.Point(450, 337);
            this.report_B_button.Name = "report_B_button";
            this.report_B_button.Size = new System.Drawing.Size(89, 23);
            this.report_B_button.TabIndex = 11;
            this.report_B_button.Text = "Save Report B";
            this.report_B_button.UseVisualStyleBackColor = true;
            this.report_B_button.Click += new System.EventHandler(this.report_B_button_Click);
            // 
            // report_C_button
            // 
            this.report_C_button.Enabled = false;
            this.report_C_button.Location = new System.Drawing.Point(545, 336);
            this.report_C_button.Name = "report_C_button";
            this.report_C_button.Size = new System.Drawing.Size(86, 23);
            this.report_C_button.TabIndex = 12;
            this.report_C_button.Text = "Save Report C";
            this.report_C_button.UseVisualStyleBackColor = true;
            this.report_C_button.Click += new System.EventHandler(this.report_C_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Choose folder for reports and where\r\nTEST data is located";
            // 
            // Test_button
            // 
            this.Test_button.Enabled = false;
            this.Test_button.Location = new System.Drawing.Point(343, 366);
            this.Test_button.Name = "Test_button";
            this.Test_button.Size = new System.Drawing.Size(288, 23);
            this.Test_button.TabIndex = 14;
            this.Test_button.Text = "Load TEST data";
            this.Test_button.UseVisualStyleBackColor = true;
            this.Test_button.Click += new System.EventHandler(this.Test_button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(385, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(12, 65);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(57, 13);
            this.Date_label.TabIndex = 17;
            this.Date_label.Text = "Order date";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Folder_button
            // 
            this.Folder_button.Location = new System.Drawing.Point(12, 366);
            this.Folder_button.Name = "Folder_button";
            this.Folder_button.Size = new System.Drawing.Size(246, 23);
            this.Folder_button.TabIndex = 18;
            this.Folder_button.Text = "Folder";
            this.Folder_button.UseVisualStyleBackColor = true;
            this.Folder_button.Click += new System.EventHandler(this.Folder_button_Click);
            // 
            // sales_manager_DBDataSet
            // 
            this.sales_manager_DBDataSet.DataSetName = "Sales_manager_DBDataSet";
            this.sales_manager_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesmanagerDBDataSetBindingSource
            // 
            this.salesmanagerDBDataSetBindingSource.DataSource = this.sales_manager_DBDataSet;
            this.salesmanagerDBDataSetBindingSource.Position = 0;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.salesmanagerDBDataSetBindingSource;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.salesmanagerDBDataSetBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // Client_FK
            // 
            this.Client_FK.DataPropertyName = "Client_FK";
            this.Client_FK.HeaderText = "Client_FK";
            this.Client_FK.Name = "Client_FK";
            // 
            // OrderItem
            // 
            this.OrderItem.DataPropertyName = "OrderItem";
            this.OrderItem.HeaderText = "OrderItem";
            this.OrderItem.Name = "OrderItem";
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // sales_manager_DBDataSet1
            // 
            this.sales_manager_DBDataSet1.DataSetName = "Sales_manager_DBDataSet";
            this.sales_manager_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.sales_manager_DBDataSet1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 50;
            // 
            // orderItemDataGridViewTextBoxColumn
            // 
            this.orderItemDataGridViewTextBoxColumn.DataPropertyName = "OrderItem";
            this.orderItemDataGridViewTextBoxColumn.HeaderText = "OrderItem";
            this.orderItemDataGridViewTextBoxColumn.Name = "orderItemDataGridViewTextBoxColumn";
            this.orderItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 70;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 409);
            this.Controls.Add(this.Folder_button);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Test_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.report_C_button);
            this.Controls.Add(this.report_B_button);
            this.Controls.Add(this.report_A_button);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Quantity_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cost_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Item_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_textBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tool Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_manager_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanagerDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_manager_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Item_textBox;
        private System.Windows.Forms.TextBox Cost_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Quantity_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button report_A_button;
        private System.Windows.Forms.Button report_B_button;
        private System.Windows.Forms.Button report_C_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Test_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Folder_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource salesmanagerDBDataSetBindingSource;
        private Sales_manager_DBDataSet sales_manager_DBDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Sales_manager_DBDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Sales_manager_DBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_FK;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private Sales_manager_DBDataSet sales_manager_DBDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}

