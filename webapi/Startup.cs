using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using webapi.Core.CoreContract;
using webapi.CoreApplicationServices;

using webapi.Infrastructure.EF.Repositories;
using webapi.InfrastructureEF;

namespace webapi
{
    public class Startup
    {
        private string _StoreDbConnectionString;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IUserRepository, UserRepository>();


            //Retriving Password from UserSecretsId
            //I have this on my local machine
            string Password = Configuration["DatabasePass"];
            _StoreDbConnectionString = String.Concat( Configuration.GetConnectionString("StoreConnection") , Password , " ; ");
            //hiwa db
            services.AddDbContext<StoreContext>(opt =>  opt.UseLazyLoadingProxies().UseSqlServer(_StoreDbConnectionString)) ;
          //  services.AddDbContext<StoreContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
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
