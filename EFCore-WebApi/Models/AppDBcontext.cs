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
            modelBuilder.Seed();
            modelBuilder.entityBuild();
        }


    }
}
