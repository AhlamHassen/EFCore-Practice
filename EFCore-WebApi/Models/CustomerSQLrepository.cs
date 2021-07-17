using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore_WebApi.Models
{
    public class CustomerSQLrepository: ICustomer
    {
        private readonly AppDBcontext context;

        public CustomerSQLrepository(AppDBcontext _context)
        {
            this.context = _context;
        }

        public async Task<ActionResult<IEnumerable<Customer>>> GetAllCustomers()
        {
            return await context.Customers.ToListAsync();
        }

        public ActionResult<Customer> GetCustomer(int id)
        {
            return context.Customers.Find(id);
        }
    }
}
