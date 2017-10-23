using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaFactory.Infrastructure;
using System;
using System.Reflection;

namespace PizzaFactory.Web
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
            Assembly correAssembly = typeof(Core.Common.BaseCommand).Assembly;
            
            services.AddScoped<IRepository, InMemoryRepository>();
            services.AddSingleton<ICommandSender>(s => new InMemoryBus(h => Activator.CreateInstance(h), correAssembly));
            services.AddSingleton<IEventPublisher>(s => new InMemoryBus(h => Activator.CreateInstance(h), correAssembly));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
