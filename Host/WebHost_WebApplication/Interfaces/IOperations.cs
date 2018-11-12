using System;
using System.Collections.Generic;
using System.Text;

namespace MarkOGDev.Microsoft_Samples.WebHost_Sample.WebApplication.Interfaces
{

    /*
     Lifetime and registration options for DI.
     https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.1#service-lifetimes

        Each interface will be registered with DI in a different way.
        E.g.    AddScoped()
                AddTransient()
                AddSingleton()

             */

    public interface IOperation
    {
        Guid OperationId { get; }
    }

    public interface IOperationTransient : IOperation
    {
    }

    public interface IOperationScoped : IOperation
    {
    }

    public interface IOperationSingleton : IOperation
    {
    }

    public interface IOperationSingletonInstance : IOperation
    {
    }
}
