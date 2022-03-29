using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Saite_1.Data;
using Saite_1.Data.interfaces;
using Saite_1.Data.mocks;
using Saite_1.Data.Repository;

namespace Saite_1
{
    public class Startup
    {
        private IConfigurationRoot _confsting;
        public Startup(IWebHostEnvironment hostEnv) 
        {
            _confsting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build(); 
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confsting.GetConnectionString("DefaultConnection")));
            /*services.AddTransient<IAllCars, MockCars>();
            services.AddTransient<ICarsCategory, MockCategory>();*/
            services.AddTransient<IAllCars, CarRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            
            app.UseRouting();
           
            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllerRoute(name: "default", "{controller=Home}/{action=Index}");
            });

            using (var scoupe = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scoupe.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
