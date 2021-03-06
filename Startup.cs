using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CRM3.Data;
using CRM3.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using React.AspNet;
using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;

namespace CRM3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CRM3LoginContext>(options =>
                options.UseMySql("ConnectionString;", // replace with your Connection String
                    mySqlOptions =>
                    {
                        mySqlOptions.ServerVersion(new Version(5, 7, 28), ServerType.MySql); // replace with your Server Version and Type
                    }
            ));
            services.AddIdentity<IdentityUser, IdentityRole>(config => {
                config.Password.RequiredLength = 4;
                config.Password.RequireDigit = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
            })
                .AddEntityFrameworkStores<CRM3LoginContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(config => {
                config.Cookie.Name = "Identity.Cookie";
                config.LoginPath = "/Account/Login";
            });
            
            services.AddControllersWithViews();
            services.AddDbContext<DashboardContext>(options =>
                options.UseMySql("ConnectionString;", // replace with your Connection String
                    mySqlOptions =>
                    {
                        mySqlOptions.ServerVersion(new Version(5, 7, 28), ServerType.MySql); // replace with your Server Version and Type
                    }
            ));

            services.AddDbContext<CompanyContext>(options =>
                options.UseMySql("ConnectionString;", // replace with your Connection String
                    mySqlOptions =>
                    {
                        mySqlOptions.ServerVersion(new Version(5, 7, 28), ServerType.MySql); // replace with your Server Version and Type
                    }
            ));
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

            // app.UseReact( config =>
            // {
            //     config
            //         .AddScript("~/scripts/app.js");
            // });
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
