using EFCore_WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomer customerRepo;

        public CustomerController(ICustomer _icustomer)
        {
            this.customerRepo = _icustomer;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetAllCustomers()
        {
            return await customerRepo.GetAllCustomers();
        }

        [HttpGet("GetCustomer/{Customer_ID}")]
        public ActionResult<Customer> GetCustomer(int Customer_ID)
        {
            return customerRepo.GetCustomer(Customer_ID);
        }
    }
}
