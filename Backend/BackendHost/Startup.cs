using Business.Interfaces;
using Business.Repositories;
using Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendHost
{
    public class Startup
    {
        private IConfiguration _configuration { get; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AmContext>(options => {
                options.UseSqlServer(connectionString).EnableSensitiveDataLogging().UseLazyLoadingProxies();
                });
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IAssignmentRepository, AssignmentRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AmContext ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
