using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_WebApi.Models
{
    public class EmployeeSQLrepository : IEmployeeRepository
    {
        private readonly AppDBcontext context;

        public EmployeeSQLrepository(AppDBcontext _context)
        {
            this.context = _context;
        }

        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Update(Employee employeeChange)
        {
            var employee = context.Employees.Attach(employeeChange);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return employeeChange;
               
        }

        public Employee Delete(int Id)
        {
            Employee employee = context.Employees.Find(Id);
            if(employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }

            return employee;
        }

        public Employee GetEmployee(int Id)
        {
            return context.Employees.Find(Id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees;
        }

    }
}
