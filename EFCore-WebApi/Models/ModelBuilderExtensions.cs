using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EFCore_WebApi.Models
{
    //the class has to be static for an extension method
    public static class ModelBuilderExtensions
    {
        //because it is an extension for the modelbuilder on the appdbcontext class
        public static void Seed(this ModelBuilder modelBuilder)
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

        public static void entityBuild(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(k => new
            {
                k.customer_id
            });

        }
    }
}
