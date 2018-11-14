using System;
using System.Linq;
using System.Threading.Tasks;
using MarkOGDev.Microsoft_Samples.EfCoreSqlLite.ConsoleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MarkOGDev.Microsoft_Samples.EfCoreSqlLite.ConsoleApp
{
    class Program
    {

        public static async Task Main(string[] args)
        {
            var host = new HostBuilder()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddScoped<DirectoriesContext, DirectoriesContext>();
               })
               .Build();

            //Call services from main
            //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.1#call-services-from-main

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var db = services.GetRequiredService<DirectoriesContext>();

                    // Use the context here
                    var DirCount = db.Directories.AsNoTracking().Count();
                    Console.WriteLine($"There are {DirCount} Directory records in the database");
                    Console.WriteLine();
                    Console.WriteLine();

                    var DirNames = await db.Directories.AsNoTracking().Select(s => s.Name).ToListAsync();
                    int count = 0;
                    Console.WriteLine($"The Directories names are:");
                    foreach (var name in DirNames)
                    {
                        Console.WriteLine($"Directory Name: {name}");
                        count++;
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    var DirectoriesAndItems = await db.Directories.AsNoTracking().Select(s => s).Include(i => i.Items).ToListAsync();
                    Console.WriteLine($"Directory Items are:");
                    Console.WriteLine();

                    foreach (var dir in DirectoriesAndItems)
                    {
                        Console.WriteLine($"Directory {dir.Name}:");
                        count++;

                        foreach (var item in dir.Items)
                        {
                            Console.WriteLine($"Item ID {item.ItemId} : {item.Title} ");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }



        }
    }
}

