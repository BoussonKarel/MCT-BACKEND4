using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc.Versioning;
using MCT_BACKEND4.Configuration;
using MCT_BACKEND4.Data;
using MCT_BACKEND4.Repositories;
using MCT_BACKEND4.Services;

namespace RegistrationAPI
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
            // Caching
            services.AddResponseCaching();
            services.AddMemoryCache();
            
            // Configuratie zoals connectiestrings, email settings
            services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
 
            // Context
            services.AddDbContext<RegistrationContext>();
        
            services.AddControllers();

            // Context
            services.AddTransient<IRegistrationContext,RegistrationContext>();
            // Repositories
            services.AddTransient<IVaccinTypeRepository,VaccinTypeRepository>();
            services.AddTransient<IVaccinationLocationRepository,VaccinationLocationRepository>();
            services.AddTransient<IVaccinationRegistrationRepository,VaccinationRegistrationRepository>();
            // Services
            services.AddTransient<IRegistrationService,RegistrationService>();
            services.AddTransient<IMailService, MailService>();
 
 
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RegistrationAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RegistrationAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // Caching
            app.UseResponseCaching();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
