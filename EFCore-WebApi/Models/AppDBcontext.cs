using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebApi.Models
{
    public class AppDBcontext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public AppDBcontext(DbContextOptions<AppDBcontext> options): base(options)
        {

        }

        //to populate the employees table -- seeding data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                   new Employee
                   {
                       Id = 1,
                       Name = "Ahlam",
                       Email = "ahlam@gmail.com"
                   },

                   new Employee
                   {
                       Id = 2,
                       Name = "alu",
                       Email = "alu@gmai.com"
                   }

                );
        }


    }
}
