using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PetShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = "Server=X1;Database=Pet4;Trusted_Connection=True;";
            services.AddControllersWithViews();
            services.AddDbContext<PetContext>(options => options.UseSqlServer(connectionString));

        }

        public void Configure(IApplicationBuilder app, PetContext ptc)
        {/*
            ptc.Database.EnsureDeleted();
            ptc.Database.EnsureCreated();*/

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Animals}/{action=Index}");
            });
            
    
        }
    }
}