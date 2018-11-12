using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace EfCore.SqlLite.ConsoleApp
{


    class Program
    {

        /// <summary>
        /// App Settings
        /// </summary>
        public static IConfiguration AppConfig { get; set; }


        public static void Main(string[] args)
        {

        }



        //public static async Task Main(string[] args)
        //{

        //    var host = new HostBuilder()
        //           .ConfigureHostConfiguration(configHost =>
        //           {
        //               configHost.SetBasePath(Directory.GetCurrentDirectory());
        //               configHost.AddJsonFile("hostsettings.json", optional: true);
        //               configHost.AddEnvironmentVariables(prefix: "PREFIX_");
        //               configHost.AddCommandLine(args);
        //           })
        //           .ConfigureAppConfiguration((hostContext, configApp) =>
        //           {
        //               configApp.AddJsonFile("appsettings.json", optional: true);
        //               configApp.AddJsonFile(
        //                   $"appsettings.{hostContext.HostingEnvironment.EnvironmentName}.json",
        //                   optional: true);
        //               configApp.AddEnvironmentVariables(prefix: "PREFIX_");
        //               configApp.AddCommandLine(args);
        //           })
        //           .ConfigureServices((hostContext, services) =>
        //           {
        //               services.AddHostedService<LifetimeEventsHostedService>();
        //               services.AddHostedService<TimedHostedService>();
        //           })
        //           .ConfigureLogging((hostContext, configLogging) =>
        //           {
        //               configLogging.AddConsole();
        //               configLogging.AddDebug();
        //           })
        //           .UseConsoleLifetime()
        //           .Build();

        //    await host.RunAsync();


        //}

        //public static async Task Main(string[] args)
        //{

        //    //var host = new HostBuilder().Build();

        //    //await host.RunAsync();


        //    //Load the App Configuration file
        //    AppConfig = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
        //                                             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        //                                             .Build();

        //    string AppName = AppConfig.GetSection("Application")["Name"];
        //    string StorageConnString = AppConfig.GetSection("Application")["SqlLiteDataSource"];



        //    //#### Dependency Injection ####
        //    var serviceProvider = new ServiceCollection()
        //        .AddLogging()
        //        //  .AddSingleton<IFooService, FooService>()
        //        //  .AddSingleton<IBarService, BarService>()
        //        .BuildServiceProvider();

        //    //#### Console logging setup ####
        //    serviceProvider.GetService<ILoggerFactory>().AddConsole(LogLevel.Debug);      //NOTE we could get logging settings from the appsettigns.json





        //    //var logger = host.Services.GetRequiredService<ILogger<Program>>();
        //    //logger.LogInformation("Seeded the database.");







        //    //var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger<Program>();

        //    //logger.LogDebug("Starting application");



        // //   logger.LogDebug("All done!");
        //    // logger.LogInformation("Starting application");
        //    // logger.LogInformation("App Storage Connection String: {0}", StorageConnString);



        //    //## Show important info to user
        //    // Console.ForegroundColor = ConsoleColor.Green;
        //    // Console.WriteLine("Application Name: {0}", AppName);
        //    // Console.WriteLine("App Storage Connection String: {0}", StorageConnString);
        //    // Console.WriteLine();

        //    Console.WriteLine("Hello World!");
        //}



    }
}
