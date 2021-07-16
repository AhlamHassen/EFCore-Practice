using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore_WebApi.Models;

namespace EFCore_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            this.employeeRepository = _employeeRepository;
        }

        [HttpPost]
        public ActionResult<Employee> Create([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmp = this.employeeRepository.Add(employee);
                return newEmp;
            }

            return BadRequest();
        }


        
    }
}
