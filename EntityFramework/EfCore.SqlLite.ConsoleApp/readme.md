# Entity Framework Core, Code First,  .NET Core Console App  with Generic Host and SqlLite 

SqlLite is a flat file, no server, SQL DB.

One use for SqlLite  is to sync data from remote SQL server and allow an app to run on the client without network connectivity.

## Steps

1) Install Entity Framework Core via NuGet.
2) Create Database Model as classes
3) Create DB using migrations
4) Use the DBcontext to access SqlLite DB.



## SqlLite Limitations

[SqlLite EF migrations limitations](https://docs.microsoft.com/en-us/ef/core/providers/sqlite/limitations)

Consider dropping the database and creating a new one rather than using migrations when the model changes.






#### Reference

[.NET Generic Host](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host)

[Tutorial: appsettings.json in .NET Core Console App](https://blog.bitscry.com/2017/05/30/appsettings-json-in-net-core-console-app/)

[Tutorial: Adding logging to a .NET Core console application](https://blog.bitscry.com/2017/05/31/logging-in-net-core-console-applications/)

[Tutorial: Getting Started with EF Core on .NET Core Console App with a New database](https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite)
