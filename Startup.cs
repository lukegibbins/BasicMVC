using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChillAndGrill.Data;
using ChillAndGrill.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ChillAndGrill
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        // The below configuration is what is configured at startup 
        public void ConfigureServices(IServiceCollection services)
        {
            //Configures authentication services/scheme using 'Cookies' with AzureAD
            services.AddAuthentication(options =>
                {
                    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
                }
            ).AddOpenIdConnect(options =>
            {
                _configuration.Bind("AzureAd", options);
            }).AddCookie();



            services.AddSingleton<IGreeter, Greeter>();
            services.AddDbContext<ChillAndGrillDBContext>
                (options => options.UseSqlServer(_configuration.GetConnectionString("ChillAndGrillDBConnection"))); //DB setup...

            services.AddScoped<IRestaurantData, SQLRestaurantData>(); //Service is registered here to allow a controller to access this data rather than each controller extending a service.
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

            //States the site must redirect to HTTPS endpoint using SSL
            app.UseRewriter(new RewriteOptions().AddRedirectToHttpsPermanent());

            //Allows static files in wwwroot to be used and routed to. E.g //http://localhost:5000/index.html
            app.UseStaticFiles();

            //Finds out the users identify using Azures OpenID connect
            app.UseAuthentication();

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
