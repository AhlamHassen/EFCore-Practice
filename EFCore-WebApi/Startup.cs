using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore_WebApi.Models;
using Microsoft.EntityFrameworkCore;


namespace EFCore_WebApi
{
    public class Startup
    {
        //to read the connection string from the appsettings.json
        private IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDBcontext>(options => options.
            UseSqlServer(_config.GetConnectionString("EmployeeDBconnection")));

            //adds the implementation of the interface to IEmployeeRepository in other words provide an instance of
            //EmployeeSQLrepository whenever an instance of IEmployeeRepository is asked

            //we used AddScoped instead of AddTransient to make the instance of ESQLrepo availabe throughout the scope
            //of a given http request, when new http req new instance will be created and made availabe in same way
            services.AddScoped<IEmployeeRepository, EmployeeSQLrepository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
