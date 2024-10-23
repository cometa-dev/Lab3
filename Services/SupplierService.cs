using System;
using System.Linq;
using System.Collections.Generic;
using ShopApplication.Models;
using ShopApplication.Data;

namespace ShopApplication.Services
{
    public class SupplierService
    {
        private readonly ShopContext _context;

        public SupplierService(ShopContext context)
        {
            _context = context;
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetSupplierById(int id)
        {
            return _context.Suppliers.Find(id);
        }

        public void AddSupplier(string name, string address, string phone)
        {
            var supplier = new Supplier
            {
                Name = name,
                Address = address,
                Phone = phone
            };

            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void UpdateSupplier(int id, string name, string address, string phone)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier != null)
            {
                supplier.Name = name;
                supplier.Address = address;
                supplier.Phone = phone;
                _context.SaveChanges();
            }
        }

        public void DeleteSupplier(int id)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
        }
    }
}