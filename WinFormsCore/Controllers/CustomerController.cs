using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsCore.Models.Entities;

namespace WinFormsCore.Controllers
{
    internal class CustomerController
    {
        private readonly ShopContext _context;
        private BindingList<Customer> customerBindingList;
        public BindingList<Customer> CustomerBindingList { get => customerBindingList; set => customerBindingList = value; }
        public CustomerController(ShopContext context)
        {
            _context = context;
            customerBindingList = new BindingList<Customer>(_context.Customers.ToList());
        }
        public void AddCustomer(Customer c)
        {
            _context.Customers.Add(c);
        }
        public void RemoveCustomer(Customer c)
        {
            _context.Customers.Remove(c);
        }
        public void SaveChange()
        {
            _context.SaveChanges();
            customerBindingList = new BindingList<Customer>(_context.Customers.ToList());
        }
        public void SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }
        public void UpdateCustomer(Customer c)
        {
            _context.Customers.Update(c);
        }
        public void UpdateCustomerBinDingList(List<Customer> newList)
        {
            customerBindingList = new BindingList<Customer>(newList);
        }
        public void DisplayCustomerToGridView(DataGridView gridView, int pageNumber, int pageSize)
        {
            var customersPaged = customerBindingList
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

            // Bind to the DataGridView
            gridView.DataSource = customersPaged.Select(c => new
            {
                STT = c.Id,
                Ho = c.LastName,
                Ten = c.FirstName,
                TinhTP = c.City,
                QuocGia = c.Country,
                DienThoai = c.Phone
            }).ToList();
        }
        public void SortCustomersById(bool ascending)
        {
            if (ascending)
            {
                customerBindingList = new BindingList<Customer>(customerBindingList.OrderBy(c => c.Id).ToList());
            }
            else
            {
                customerBindingList = new BindingList<Customer>(customerBindingList.OrderByDescending(c => c.Id).ToList());
            }
        }
        public void SortCustomersByName(bool ascending)
        {
            if (ascending)
            {
                customerBindingList = new BindingList<Customer>(customerBindingList.OrderBy(c => c.FirstName).ToList());
            }
            else
            {
                customerBindingList = new BindingList<Customer>(customerBindingList.OrderByDescending(c => c.FirstName).ToList());
            }
        }
    }
}
