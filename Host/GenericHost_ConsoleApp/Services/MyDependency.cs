using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MarkOGDev.Microsoft_Samples.GenericHost_Sample.ConsoleApp.Interfaces;
using Microsoft.Extensions.Logging;

namespace MarkOGDev.Microsoft_Samples.GenericHost_Sample.ConsoleApp.Services
{
    /// <summary>
    /// Scoped - Scoped lifetime services are created once per request. 
    /// </summary>
    public class MyDependency : IMyDependency
    {
        private readonly ILogger<MyDependency> _logger;

        public MyDependency(ILogger<MyDependency> logger)
        {
            _logger = logger;
        }

        public Task WriteMessage(string message)
        {
            _logger.LogInformation(
                "MyDependency.WriteMessage called. Message: {MESSAGE}",
                message);

            return Task.FromResult(0);
        }
    }
}
