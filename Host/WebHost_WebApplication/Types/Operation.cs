using System;
using System.Collections.Generic;
using System.Text;
using MarkOGDev.Microsoft_Samples.WebHost_Sample.WebApplication.Interfaces;

namespace MarkOGDev.Microsoft_Samples.WebHost_Sample.WebApplication.Types
{

    //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.1#service-lifetimes

    /// <summary>
    /// <para>Implements the Operation interfaces. The Operation constructor generates a GUID if one isn't supplied:</para>
    /// </summary>
    public class Operation : IOperationTransient,
       IOperationScoped,
       IOperationSingleton,
       IOperationSingletonInstance
    {
        public Operation() : this(Guid.NewGuid())
        {
        }

        public Operation(Guid id)
        {
            OperationId = id;
        }

        public Guid OperationId { get; private set; }
    }



}
