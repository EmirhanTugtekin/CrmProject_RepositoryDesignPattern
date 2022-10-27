using Business_Layer;
using Business_Layer.Abstract;
using Business_Layer.Concrete;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccess_Layer;
using DataAccess_Layer.Abstract;
using DataAccess_Layer.Concrete.EntityFramework;
using DataAccess_Layer.EntityFramework;
using Entity_Layer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI_Layer.Models;

namespace UI_Layer
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
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IEmployeeDal, EfEmployeeDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal,EfCategoryDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EfMessageDal>();

            services.AddDbContext<Context>();

            //services.AddIdentity<AppUser, AppRole>(x=>
            //{
            //    x.Password.RequireUppercase = false;
            //    x.Password.RequireNonAlphanumeric= false;
            //    x.Password.RequiredLength = 1;
            //}).AddEntityFrameworkStores<Context>();

            services.AddIdentity<AppUser, AppRole>(opts => {
                opts.User.RequireUniqueEmail = true;
                opts.User.AllowedUserNameCharacters = "abcçdefghiýjklmnoöpqrsþtuüvwxyzABCDEFGHIÝJKLMNOÖPQRSTUÜVWXYZ0123456789-._@+";
                opts.Password.RequiredLength = 3;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireDigit = false;
            }
                ).AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Employee}/{action=Index}/{id?}");
            });
        }
    }
}
