using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShopApplication.Models;
using ShopApplication.Data;

namespace ShopApplication.Services
{
    public class ProductService
    {
        private readonly ShopContext _context;

        public ProductService(ShopContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.Include(p => p.Supplier).ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public void AddProduct(string name, decimal price, int quantity, int supplierId)
        {
            var supplier = _context.Suppliers.Find(supplierId);
            if (supplier == null) return;

            var product = new Product
            {
                Name = name,
                Price = price,
                Quantity = quantity,
                Supplier = supplier
            };

            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(int id, string name, decimal price, int quantity)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                product.Name = name;
                product.Price = price;
                product.Quantity = quantity;
                _context.SaveChanges();
            }
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}