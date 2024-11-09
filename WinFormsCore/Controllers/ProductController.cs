using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsCore.Models.Entities;

namespace WinFormsCore.Controllers
{
    internal class ProductController
    {
        ShopContext _context;
        private IQueryable<Product> query;
        public IQueryable<Product> Querry { get => query; set => query = value; }
        private readonly SupplierController _supplierController;

        public ProductController(ShopContext context)
        {
            _context = context;
            query = _context.Products;
            _supplierController = new SupplierController(context);
        }

        public void DisplayToGirdView(DataGridView gridView)
        {
            var products = query.Select(p => new
                                 {
                                     STT = p.Id,
                                     Name = p.ProductName,
                                     SupplierName = p.Supplier.CompanyName,
                                     UnitPrice = p.UnitPrice,
                                     IsDiscontinued = p.IsDiscontinued
                                 })
                                 .ToList();

            // Bind to the DataGridView
            gridView.DataSource = products;
        }
    }
}
