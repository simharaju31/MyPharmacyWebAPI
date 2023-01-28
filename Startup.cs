using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MyPharmacyWebAPI.Common;
using MyPharmacyWebAPI.IServices;
using MyPharmacyWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private readonly string _policyName = "CorsPolicy";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(opt =>
        {
            opt.AddPolicy(name: _policyName, builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });


            services.AddControllers();

            services.AddSingleton<IConfiguration>(Configuration);
            Global.ConnectionString = Configuration.GetConnectionString("MyPharmaDb");

            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IPharmaTypeService, PharmaTypeService>();
            services.AddScoped<IPharmacySearchService, PharmacySearchService>();
            services.AddScoped<ISavePharmacyService, SavePharmacyService>();
            services.AddScoped<ISavedPharmaciesService, SavedPharmaciesService>();
            services.AddScoped<IRemoveSavedPharmaciesService, RemoveSavedPharmaciesService>();


            services.AddMvc();
            services.AddSwaggerGen(c=> new OpenApiInfo
            {
                Version="v1",
                Title= "My API",
                Description = "ASP.NET Core Web API Sample Example"
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MYAPI");
                c.RoutePrefix = string.Empty;

            }
            );

            app.UseRouting();

            app.UseCors(_policyName);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
