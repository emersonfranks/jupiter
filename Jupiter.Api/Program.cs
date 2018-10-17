using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Jupiter.Api
{
    /// <summary>
    ///     Used to run the app.
    /// </summary>
    public sealed class Program
    {
        /// <summary>
        ///     Provides the entry point for the app.
        /// </summary>
        /// <param name="args">The args.</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        ///     Creates a IWebHostBuilder.
        /// </summary>
        /// <param name="args">The args.</param>
        /// <returns>An instance of an IWebHostBuilder.</returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
