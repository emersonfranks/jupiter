using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Swashbuckle.AspNetCore.Swagger;

namespace DeveloperTools.Api
{
    /// <summary>
    ///     Encapsulates the app start up process.
    /// </summary>
    public class Startup
    {
        /// <summary>
        ///     Starts the app.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        ///  This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">The services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "Developer Tools",
                    Version = "v1",
                    Description = "Just some tools that I seem to always need.",
                    Contact = new Contact
                    {
                        Email = "franks.emerson@gmail.com",
                        Name = "Emerson Franks",
                        Url = "https://www.linkedin.com/in/emersonfranks/"
                    }
                });
            });
        }

        /// <summary>
        ///     This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">The app.</param>
        /// <param name="environment">The environment</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(so => so.SwaggerEndpoint("/swagger/v1/swagger.json", "Developer Tools v1"));

            app.UseMvc();
        }
    }
}
