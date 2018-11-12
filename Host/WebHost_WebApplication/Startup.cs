using System;
using MarkOGDev.Microsoft_Samples.WebHost_Sample.WebApplication.Interfaces;
using MarkOGDev.Microsoft_Samples.WebHost_Sample.WebApplication.Services;
using MarkOGDev.Microsoft_Samples.WebHost_Sample.WebApplication.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace MarkOGDev.Microsoft_Samples.WebHost_Sample.WebApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Includes support for Razor Pages and controllers.
            services.AddMvc();

            //Lifetime and registration options examples  
            services.AddTransient<IOperationService, OperationService>();

            services.AddTransient<IOperationTransient, Operation>();
            services.AddScoped<IOperationScoped, Operation>();
            services.AddSingleton<IOperationSingleton, Operation>();
            services.AddSingleton<IOperationSingletonInstance>(new Operation(Guid.NewGuid()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Enable Razor pages
            app.UseMvc();
             
        }
    }
}
