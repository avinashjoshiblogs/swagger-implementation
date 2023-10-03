using Microsoft.AspNetCore;

namespace SwaggerImplementation.Api
{
    public class Program
    {   public static IConfiguration Configuration { get; set; }

        public static void Main(string[] args)
        {
            var configuration = GetConfiguration();

            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var builder = new ConfigurationBuilder()
                .SetBasePath(GetContentRootPath())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
            BuildWebHost(args).Run();
        }

        private static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddEnvironmentVariables();
            return builder.Build();
        }

        private static string GetContentRootPath()
        {

            var relativePathToHostProject =
            Directory.GetCurrentDirectory();

            return relativePathToHostProject;
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)             
                .UseStartup<Startup>()
                .UseConfiguration(Configuration)
                .Build();
    }
}