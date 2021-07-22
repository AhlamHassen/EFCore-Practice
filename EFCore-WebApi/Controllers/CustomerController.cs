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

        //This summary comments below are to show description and explain return types of endpoints in swagger.
        /// <summary>
        /// gets all customers from the customers table in our database
        /// </summary>
        /// <returns>It returns an array of customers</returns>
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
