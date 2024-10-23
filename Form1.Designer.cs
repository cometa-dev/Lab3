namespace ShopApplication
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierAddressTextBox = new System.Windows.Forms.TextBox();
            this.supplierPhoneTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.updateSupplierButton = new System.Windows.Forms.Button();
            this.deleteSupplierButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Управление магазином";

            // groupBox1 - Поставщики
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Size = new System.Drawing.Size(470, 576);
            this.groupBox1.Text = "Поставщики";

            // groupBox2 - Товары
            this.groupBox2.Location = new System.Drawing.Point(488, 12);
            this.groupBox2.Size = new System.Drawing.Size(470, 576);
            this.groupBox2.Text = "Товары";

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Size = new System.Drawing.Size(458, 300);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            // dataGridView2
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Size = new System.Drawing.Size(458, 300);
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);

            // Labels для поставщиков
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 330);
            this.label1.Text = "Назва:";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 370);
            this.label2.Text = "Адреса:";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 410);
            this.label3.Text = "Телефон:";

            // Labels для товаров
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 330);
            this.label4.Text = "Назва:";

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 370);
            this.label5.Text = "Ціна:";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 410);
            this.label6.Text = "Кілкість:";

            // TextBoxes для поставщиков
            this.supplierNameTextBox.Location = new System.Drawing.Point(100, 327);
            this.supplierNameTextBox.Size = new System.Drawing.Size(364, 20);

            this.supplierAddressTextBox.Location = new System.Drawing.Point(100, 367);
            this.supplierAddressTextBox.Size = new System.Drawing.Size(364, 20);

            this.supplierPhoneTextBox.Location = new System.Drawing.Point(100, 407);
            this.supplierPhoneTextBox.Size = new System.Drawing.Size(364, 20);

            // TextBoxes для товаров
            this.productNameTextBox.Location = new System.Drawing.Point(100, 327);
            this.productNameTextBox.Size = new System.Drawing.Size(364, 20);

            this.productPriceTextBox.Location = new System.Drawing.Point(100, 367);
            this.productPriceTextBox.Size = new System.Drawing.Size(364, 20);

            this.productQuantityTextBox.Location = new System.Drawing.Point(100, 407);
            this.productQuantityTextBox.Size = new System.Drawing.Size(364, 20);

            // Buttons для поставщиков
            this.addSupplierButton.Location = new System.Drawing.Point(6, 447);
            this.addSupplierButton.Size = new System.Drawing.Size(146, 23);
            this.addSupplierButton.Text = "Додати";
            this.addSupplierButton.Click += new System.EventHandler(this.addSupplierButton_Click);

            this.updateSupplierButton.Location = new System.Drawing.Point(158, 447);
            this.updateSupplierButton.Size = new System.Drawing.Size(146, 23);
            this.updateSupplierButton.Text = "Оновити";
            this.updateSupplierButton.Click += new System.EventHandler(this.updateSupplierButton_Click);

            this.deleteSupplierButton.Location = new System.Drawing.Point(310, 447);
            this.deleteSupplierButton.Size = new System.Drawing.Size(146, 23);
            this.deleteSupplierButton.Text = "Видалити";
            this.deleteSupplierButton.Click += new System.EventHandler(this.deleteSupplierButton_Click);

            // Buttons для товаров
            this.addProductButton.Location = new System.Drawing.Point(6, 447);
            this.addProductButton.Size = new System.Drawing.Size(146, 23);
            this.addProductButton.Text = "Додати";
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);

            this.updateProductButton.Location = new System.Drawing.Point(158, 447);
            this.updateProductButton.Size = new System.Drawing.Size(146, 23);
            this.updateProductButton.Text = "Оновити";
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);

            this.deleteProductButton.Location = new System.Drawing.Point(310, 447);
            this.deleteProductButton.Size = new System.Drawing.Size(146, 23);
            this.deleteProductButton.Text = "Видалити";
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);

            // Добавление контролов в groupBox1
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.supplierNameTextBox);
            this.groupBox1.Controls.Add(this.supplierAddressTextBox);
            this.groupBox1.Controls.Add(this.supplierPhoneTextBox);
            this.groupBox1.Controls.Add(this.addSupplierButton);
            this.groupBox1.Controls.Add(this.updateSupplierButton);
            this.groupBox1.Controls.Add(this.deleteSupplierButton);

            // Добавление контролов в groupBox2
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.productNameTextBox);
            this.groupBox2.Controls.Add(this.productPriceTextBox);
            this.groupBox2.Controls.Add(this.productQuantityTextBox);
            this.groupBox2.Controls.Add(this.addProductButton);
            this.groupBox2.Controls.Add(this.updateProductButton);
            this.groupBox2.Controls.Add(this.deleteProductButton);

            // Добавление groupBox на форму
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.TextBox supplierAddressTextBox;
        private System.Windows.Forms.TextBox supplierPhoneTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.Button addSupplierButton;
        private System.Windows.Forms.Button updateSupplierButton;
        private System.Windows.Forms.Button deleteSupplierButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}