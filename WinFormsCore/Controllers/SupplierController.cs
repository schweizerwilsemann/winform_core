using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsCore.Models.Entities;

namespace WinFormsCore.Controllers
{
    internal class SupplierController
    {
        ShopContext _context;
        private IQueryable<Supplier> query;
        public IQueryable<Supplier> Querry { get => query; set => query = value; }

        public SupplierController(ShopContext context)
        {
            _context = context;
            query = _context.Suppliers;
        }
    }
}
