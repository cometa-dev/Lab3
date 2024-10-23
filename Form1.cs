using System;
using System.Linq;
using System.Windows.Forms;
using ShopApplication.Models;
using ShopApplication.Services;
using ShopApplication.Data;

namespace ShopApplication
{
    public partial class Form1 : Form
    {
        private readonly ShopContext _db;
        private readonly SupplierService _supplierService;
        private readonly ProductService _productService;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Управління магазином";
            
            _db = new ShopContext();
            _db.Database.EnsureCreated();
            
            _supplierService = new SupplierService(_db);
            _productService = new ProductService(_db);

            if (!_db.Suppliers.Any())
            {
                LoadDemoData();
            }
            
            LoadData();
        }

        private void LoadDemoData()
        {
            var supplier1 = new Supplier
            {
                Name = "ТОВ АТБ-Маркет",
                Address = "вул. Шевченка, 15, Київ",
                Phone = "+380 44 123-45-67"
            };

            var supplier2 = new Supplier
            {
                Name = "ФОП Петренко",
                Address = "вул. Лесі Українки, 25, Львів",
                Phone = "+380 32 765-43-21"
            };

            var supplier3 = new Supplier
            {
                Name = "Гуртовня 'Фора'",
                Address = "просп. Перемоги, 112, Харків",
                Phone = "+380 57 555-55-55"
            };

            var supplier4 = new Supplier
            {
                Name = "ТОВ Сільпо",
                Address = "вул. Соборна, 45, Дніпро",
                Phone = "+380 56 222-33-44"
            };

            _supplierService.AddSupplier(supplier1.Name, supplier1.Address, supplier1.Phone);
            _supplierService.AddSupplier(supplier2.Name, supplier2.Address, supplier2.Phone);
            _supplierService.AddSupplier(supplier3.Name, supplier3.Address, supplier3.Phone);
            _supplierService.AddSupplier(supplier4.Name, supplier4.Address, supplier4.Phone);

            var suppliers = _supplierService.GetAllSuppliers();
            
            _productService.AddProduct("Молоко 'Простоквашино' 2.5%", 39.90m, 100, suppliers[0].Id);
            _productService.AddProduct("Хліб 'Київський' білий", 25.50m, 150, suppliers[0].Id);
            _productService.AddProduct("Сир 'Пирятин' 50%", 219.90m, 50, suppliers[1].Id);
            _productService.AddProduct("Масло 'Ферма' 82.5%", 89.90m, 80, suppliers[1].Id);
            _productService.AddProduct("Гречка 'Хуторок'", 69.90m, 200, suppliers[2].Id);
            _productService.AddProduct("Рис 'Розумний вибір'", 59.90m, 250, suppliers[2].Id);
            _productService.AddProduct("Макарони 'Чумак'", 44.90m, 300, suppliers[2].Id);
            _productService.AddProduct("Цукор 'Солодко'", 35.90m, 400, suppliers[3].Id);
            _productService.AddProduct("Олія 'Олейна'", 89.90m, 150, suppliers[3].Id);
            _productService.AddProduct("Борошно 'Хуторок' в/г", 45.90m, 200, suppliers[3].Id);

            MessageBox.Show("Демонстраційні дані успішно завантажено!", "Інформація",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadData()
        {
            var suppliers = _supplierService.GetAllSuppliers();
            dataGridView1.DataSource = suppliers.Select(s => new {
                s.Id,
                Назва = s.Name,
                Адреса = s.Address,
                Телефон = s.Phone
            }).ToList();

            var products = _productService.GetAllProducts();
            dataGridView2.DataSource = products.Select(p => new {
                p.Id,
                Назва = p.Name,
                Ціна = p.Price,
                Кількість = p.Quantity,
                Постачальник = p.Supplier?.Name
            }).ToList();
        }

        private void addSupplierButton_Click(object sender, EventArgs e)
        {
            _supplierService.AddSupplier(
                supplierNameTextBox.Text,
                supplierAddressTextBox.Text,
                supplierPhoneTextBox.Text
            );
            LoadData();
            ClearSupplierFields();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть постачальника!", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int supplierId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                
                _productService.AddProduct(
                    productNameTextBox.Text,
                    decimal.Parse(productPriceTextBox.Text),
                    int.Parse(productQuantityTextBox.Text),
                    supplierId
                );
                
                LoadData();
                ClearProductFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Перевірте правильність введення ціни та кількості!",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSupplierButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Видалити вибраного постачальника?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                _supplierService.DeleteSupplier(id);
                LoadData();
                ClearSupplierFields();
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Видалити вибраний товар?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (int)dataGridView2.SelectedRows[0].Cells["Id"].Value;
                _productService.DeleteProduct(id);
                LoadData();
                ClearProductFields();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                supplierNameTextBox.Text = row.Cells["Назва"].Value.ToString();
                supplierAddressTextBox.Text = row.Cells["Адреса"].Value.ToString();
                supplierPhoneTextBox.Text = row.Cells["Телефон"].Value.ToString();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.SelectedRows[0];
                productNameTextBox.Text = row.Cells["Назва"].Value.ToString();
                productPriceTextBox.Text = row.Cells["Ціна"].Value.ToString();
                productQuantityTextBox.Text = row.Cells["Кількість"].Value.ToString();
            }
        }

        private void updateSupplierButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            _supplierService.UpdateSupplier(
                id,
                supplierNameTextBox.Text,
                supplierAddressTextBox.Text,
                supplierPhoneTextBox.Text
            );
            LoadData();
            ClearSupplierFields();
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0) return;

            try
            {
                int id = (int)dataGridView2.SelectedRows[0].Cells["Id"].Value;
                _productService.UpdateProduct(
                    id,
                    productNameTextBox.Text,
                    decimal.Parse(productPriceTextBox.Text),
                    int.Parse(productQuantityTextBox.Text)
                );
                LoadData();
                ClearProductFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Перевірте правильність введення ціни та кількості!",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearSupplierFields()
        {
            supplierNameTextBox.Clear();
            supplierAddressTextBox.Clear();
            supplierPhoneTextBox.Clear();
        }

        private void ClearProductFields()
        {
            productNameTextBox.Clear();
            productPriceTextBox.Clear();
            productQuantityTextBox.Clear();
        }
    }
}