using System.IO;
using System.Threading.Tasks;
using MarkOGDev.Microsoft_Samples.GenericHost_Sample.ConsoleApp.Interfaces;
using MarkOGDev.Microsoft_Samples.GenericHost_Sample.ConsoleApp.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MarkOGDev.Microsoft_Samples.GenericHost_ConsoleApp.Interfaces;


namespace MarkOGDev.Microsoft_Samples.GenericHost_Sample.ConsoleApp
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                //#### Host Configuration ####
                .ConfigureHostConfiguration(configHost =>
                {
                    configHost.SetBasePath(Directory.GetCurrentDirectory());
                    configHost.AddJsonFile("config/hostsettings.json", optional: false);             //For AddJsonFile() add NuGet Microsoft.Extensions.Configuration.Json
                })
                //#### Application Configuration ####
                .ConfigureAppConfiguration((hostContext, configApp) =>
                {
                    configApp.AddJsonFile("config/appsettings.json", optional: true);
                    configApp.AddJsonFile($"config/appsettings.{hostContext.HostingEnvironment.EnvironmentName}.json", optional: true);     //Adds the configuration from appsettings.Development.json or appsettingsProduction.json

                })
                  //#### Services Configuration ####
                  .ConfigureServices((hostContext, services) =>
                  {
                      services.AddHostedService<LifetimeEventsHostedService>();

                      services.AddScoped<IMyDependency, MyDependency>();     

                      services.AddSingleton<ISimpleMessageService, SimpleMessageService>();

                  })
                //#### Logging Configuration ####
                .ConfigureLogging((hostContext, configLogging) =>
                {
                    configLogging.AddConfiguration(hostContext.Configuration.GetSection("Logging"));  //Load logging configuration. It has been loaded from one of the appsettings.json file 

                    configLogging.AddConsole();     //Adds log messages to the Console                                                //For AddConsole() add NuGet Microsoft.Extensions.Logging.Console
                    configLogging.AddDebug();       //Adds log messages to the VS debug window                                        //For AddDebug() add NuGet Microsoft.Extensions.Logging.Debug
                    //There are other logging providers to add/store log messages elsewhere. e.g. Azure Application Insights 

                })
                .UseConsoleLifetime()
                .Build();

            string msgStr = "Starting";

            //Get the logger 
            var logger = host.Services.GetRequiredService<ILogger<Program>>();
            logger.LogInformation($"Test: LogInformation. Hello Sir. {msgStr} Program Now. Enjoy.");
            logger.LogWarning("Test: Log Warning");
            logger.LogCritical("Test: Log Critical");
            logger.LogError("Test: Log Error");
            logger.LogDebug("Test: Log Debug");
            logger.LogTrace("Test: Log Trace");

            //Get the example service
            var MessageService = host.Services.GetRequiredService<ISimpleMessageService>();
            logger.LogInformation(MessageService.GetHelloMessage());
            logger.LogInformation(MessageService.GetHelloMessage("Mr Mark"));
            logger.LogInformation(MessageService.GetHelloMessage(501));

            //Example
            var myDep = host.Services.GetRequiredService<IMyDependency>();
            await myDep.WriteMessage("MyDep Write Message");
                                   
            await host.RunAsync();
        }

    }
}