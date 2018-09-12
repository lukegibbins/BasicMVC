using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChillAndGrill.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ChillAndGrill
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddSingleton<IRestaurantData, InMemoryRestaurant>(); //Service is registered here to allow a controller to access this data rather than each controller extending a service.
            services.AddMvc(); //Allows MVC services to be used
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
                              IHostingEnvironment env,
                              IGreeter greeter,
                              ILogger<Startup> logger)
        {
            //Exception page for developers. This shows relevant information such as what line the system failed on.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Allows static files in wwwroot to be used and routed to. E.g //http://localhost:5000/index.html
            app.UseStaticFiles();

            //Middleware added to use Mvc. This allows routing to occur using controller name and action name to produce a view
            app.UseMvc(ConfigureRoutes);

            //Setting an route /endpoint using a Path for the endpoint of 'wp'
              app.UseWelcomePage(new WelcomePageOptions
            {
                Path = "/wp"
            });

            //Default routing. (This will run if no endpoint is found)
            app.Run(async (context) =>
            {
                logger.LogInformation("*****Default page reached*****");
                var greeting = greeter.GetMessageOfTheDay();
                await context.Response.WriteAsync($" {greeting}: {env.EnvironmentName}"); //String interpolation
            });
        }

        //Routing configuration setup
        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
