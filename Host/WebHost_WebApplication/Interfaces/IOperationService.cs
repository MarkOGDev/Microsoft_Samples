using MarkOGDev.Microsoft_Samples.WebHost_Sample.WebApplication.Interfaces;

namespace MarkOGDev.Microsoft_Samples.WebHost_Sample.WebApplication.Interfaces
{
    public interface IOperationService
    {
        IOperationScoped ScopedOperation { get; }
        IOperationSingletonInstance SingletonInstanceOperation { get; }
        IOperationSingleton SingletonOperation { get; }
        IOperationTransient TransientOperation { get; }
    }
}