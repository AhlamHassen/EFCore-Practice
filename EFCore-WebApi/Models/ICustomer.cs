using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebApi.Models
{
    public interface ICustomer
    {
        public Task<ActionResult<IEnumerable<Customer>>> GetAllCustomers();
        public ActionResult<Customer> GetCustomer(int id);
    }
}
