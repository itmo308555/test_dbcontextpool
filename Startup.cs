using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfContextPooling.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using GenFu;




namespace dbcontextpool_v1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var server = Configuration ["ADMIN"] ?? "localhost";
            var port = Configuration["DbPort"] ?? "1433";
            var user = Configuration["DbUser"] ?? "sa";
            var password = Configuration["DbPassword"] ?? "abc12345";
            var database = Configuration["Database"] ?? "EmployeeContext";
            //Data Source=ADMIN;Initial Catalog=EmployeeContext;Integrated Security=True
           // var connetionString = "Data Source=ADMIN;Initial Catalog=EmployeeContext;Integrated Security=True";




           // var connetionString = "Data Source=ServerName; Initial Catalog = DatabaseName; User ID = sa; Password = 12345, Trusted_Connection=True;";*/



               services.AddDbContextPool<EmployeeContext>(options =>
               {
                    options.UseSqlServer($"Server={server},{port}; Initial Catalog = {database}; User ID = {user}; Password = {password}; Trusted_Connection=True;");
                  // options.UseSqlServer(connection);
               });

           /* services.AddDbContextPool<EmployeeContext>(options =>
            {
                options.UseSqlServer(connetionString);
            });*/
         

            /*
             
            services.AddDbContext<EmployeeContext>(options =>
            {
                options.UseSqlServer(connection);
            });
             
             */



            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, EmployeeContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });


            //Initialize and seed the database if it is empty
            dbContext.Database.EnsureCreated();
            if (!dbContext.Employees.Any())
            {
                A.Configure<Employee>()
                    .Fill(e => e.Id, 0)
                    .Fill(e => e.IsDeleted)
                    .WithRandom(new[] { true, true, true, false }) //Gives us a distribution of approx 25% deleted employees
                    .Fill(e => e.CompanyId).WithRandom(new[] { 1, 2, 3 }) //3 different companies
                    .Fill(e => e.Title).AsPersonTitle()
                    .Fill(e => e.LastName).WithRandom(new[] { "P41072", "trinh", "quoc", "bao", "test", "dbcontextPool" });



                var randomEmployees = A.ListOf<Employee>(500);

                dbContext.Employees.AddRange(randomEmployees);
                dbContext.SaveChanges();
            }
        }
    }
}
