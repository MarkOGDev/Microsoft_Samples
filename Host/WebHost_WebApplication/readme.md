# WebHost_Sample WebApplication with Dependency Injection of Services


[Back to Host in ASP.NET Core](../readme.md)


 WebHost sample with DI of Services configuration and lifetime demonstration.

 [Demo Razor Page](Pages/Index.cshtml.cs)

## Service Lifetimes

#### Transient

Transient lifetime services are created each time they're requested. This lifetime works best for lightweight, stateless services.

#### Scoped
Scoped lifetime services are created once per request.
 
#### Singleton

Singleton lifetime services are created the first time they're requested (or when ConfigureServices is run and an instance is specified with the service registration). Every subsequent request uses the same instance. If the app requires singleton behavior, allowing the service container to manage the service's lifetime is recommended. Don't implement the singleton design pattern and provide user code to manage the object's lifetime in the class. 
     

 ### Reference 

[Dependency injection in ASP.NET Core Service Lifetimes](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.1#service-lifetimes)




