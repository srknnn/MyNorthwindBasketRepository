namespace NorthwindBasketApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnOrderCreate = new System.Windows.Forms.Button();
            this.groupBoxProductsAdd = new System.Windows.Forms.GroupBox();
            this.txtProductCount = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbShipper = new System.Windows.Forms.ComboBox();
            this.Shipper = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxProductsAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee:";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(75, 44);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomer.TabIndex = 2;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(74, 16);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployee.TabIndex = 3;
            // 
            // btnOrderCreate
            // 
            this.btnOrderCreate.Location = new System.Drawing.Point(16, 108);
            this.btnOrderCreate.Name = "btnOrderCreate";
            this.btnOrderCreate.Size = new System.Drawing.Size(179, 23);
            this.btnOrderCreate.TabIndex = 4;
            this.btnOrderCreate.Text = "Create Order";
            this.btnOrderCreate.UseVisualStyleBackColor = true;
            this.btnOrderCreate.Click += new System.EventHandler(this.btnOrderCreate_Click);
            // 
            // groupBoxProductsAdd
            // 
            this.groupBoxProductsAdd.Controls.Add(this.txtProductCount);
            this.groupBoxProductsAdd.Controls.Add(this.btnAddProduct);
            this.groupBoxProductsAdd.Controls.Add(this.label4);
            this.groupBoxProductsAdd.Controls.Add(this.cmbProducts);
            this.groupBoxProductsAdd.Controls.Add(this.label3);
            this.groupBoxProductsAdd.Location = new System.Drawing.Point(215, 16);
            this.groupBoxProductsAdd.Name = "groupBoxProductsAdd";
            this.groupBoxProductsAdd.Size = new System.Drawing.Size(377, 115);
            this.groupBoxProductsAdd.TabIndex = 5;
            this.groupBoxProductsAdd.TabStop = false;
            this.groupBoxProductsAdd.Text = "Add Product to Order";
            this.groupBoxProductsAdd.Visible = false;
            // 
            // txtProductCount
            // 
            this.txtProductCount.Location = new System.Drawing.Point(115, 68);
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.Size = new System.Drawing.Size(121, 20);
            this.txtProductCount.TabIndex = 5;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(243, 33);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(131, 55);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Count:";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(115, 41);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(121, 21);
            this.cmbProducts.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose Product:";
            // 
            // cmbShipper
            // 
            this.cmbShipper.FormattingEnabled = true;
            this.cmbShipper.Location = new System.Drawing.Point(75, 71);
            this.cmbShipper.Name = "cmbShipper";
            this.cmbShipper.Size = new System.Drawing.Size(121, 21);
            this.cmbShipper.TabIndex = 7;
            // 
            // Shipper
            // 
            this.Shipper.AutoSize = true;
            this.Shipper.Location = new System.Drawing.Point(15, 74);
            this.Shipper.Name = "Shipper";
            this.Shipper.Size = new System.Drawing.Size(46, 13);
            this.Shipper.TabIndex = 6;
            this.Shipper.Text = "Shipper:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(16, 138);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(576, 97);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Çalışan ";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kargocu";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Stokta Kalan";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sipariş Adedi";
            this.columnHeader6.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 253);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbShipper);
            this.Controls.Add(this.Shipper);
            this.Controls.Add(this.groupBoxProductsAdd);
            this.Controls.Add(this.btnOrderCreate);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxProductsAdd.ResumeLayout(false);
            this.groupBoxProductsAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Button btnOrderCreate;
        private System.Windows.Forms.GroupBox groupBoxProductsAdd;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductCount;
        private System.Windows.Forms.ComboBox cmbShipper;
        private System.Windows.Forms.Label Shipper;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

