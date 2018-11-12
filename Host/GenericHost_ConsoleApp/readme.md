# Generic Host, Logging

[Back to Host in ASP.NET Core](../readme.md)

This sample quickly shows you how to set up an app with Dependency Injection, Logging, Services, Configuration files etc. 

Generic Host (ASP.NET Core 2.1 or later) – Suitable for hosting non-web apps (for example, apps that run background tasks). In a future release, the Generic Host will be suitable for hosting any kind of app, including web apps. The Generic Host will eventually replace the Web Host.
 

## Logging 


You can send [Log Level](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/#log-level) messages to the event log. 

E.g. Information level message, Debug level message, Error level message. Try to use the correct Level for each message in your application.

All levels of log are handled by all the registered log providers.

You can configure a provider to only display some levels of log message rather than all the messages.

Therefore you can display some log information in one location and other log information in other location OR display all log information in one/all location(s). 

Configure Providers via host. 


 

### Reference


[Host in ASP.NET Core](https://github.com/aspnet/Docs/blob/master/aspnetcore/fundamentals/host/index.md)

[ASP.NET Core **Generic Host**](https://github.com/aspnet/Docs/blob/master/aspnetcore/fundamentals/host/generic-host.md)

[Logging](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/)

[Dependency Injection](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)

[IApplicationLifetime](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.hosting.iapplicationlifetime)



