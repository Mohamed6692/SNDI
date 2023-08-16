﻿using FastReport.Data;
using FastReport.Utils;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ActeAdministratif
{
    public class Startup
    {

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            RegisteredObjects.AddConnection(typeof(MsSqlDataConnection));
            services.AddControllersWithViews()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                });
            services.AddMvc();

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
                //app.UseExceptionHandler("/Errors/NoFound");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            // nouveau
            //app.UseFastReport();
            // fin 
            app.UseRouting();

            //app.UseMiddleware<UserMiddleware>();
            //app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }

        private string GetConnectionSting()
        {
            string connexion = this.Configuration.GetConnectionString("Developpement");
            if (this.Environment.IsDevelopment())
            {
                connexion = this.Configuration.GetConnectionString("DevConnectionString");
            }

            if (this.Environment.IsStaging() || this.Environment.IsProduction())
            {
                connexion = this.Configuration.GetConnectionString("ProdConnectionString");
            }

            return connexion;
        }

    }
}
