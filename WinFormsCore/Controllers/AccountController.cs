using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsCore.Models.Entities;

namespace WinFormsCore.Controllers
{
    internal class AccountController
    {
        
        ShopContext _context;
        private IQueryable<Account> query;
        public IQueryable<Account> Querry { get => query; set => query = value; }

        public AccountController(ShopContext context)
        {
            _context = context;

            query = _context.Accounts;
        }

    }
}
