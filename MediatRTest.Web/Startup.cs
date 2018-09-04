using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRTest.Infrastructure;
using MediatRTest.Logic;
using MediatRTest.SharedKernel;
using MediatRTest.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MediatRTest.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMediatR(typeof(AppointmentScheduledHandler).Assembly);      // Handlers are in other assemblies, this is the way to add these assemblies.
            services.AddScoped<DomainEventsDispatcher, DomainEventsDispatcher>();
            services.AddTransient<AppointmentContext, AppointmentContext>();
            services.AddTransient<AppointmentRepository, AppointmentRepository>();
            services.AddTransient<IEventHandler<AppointmentScheduled>, AppointmentScheduledHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "",
                    template: "{controller}/{action}",
                    defaults: new { controller = "Home", action = "Index" }
                );
            });
        }
    }
}
