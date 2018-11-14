# Entity Framework Core, Code First,  .NET Core Console App  with Generic Host and SqlLite 

[Back to Microsoft_Samples Home](../../readme.md)

SqlLite is a flat file, no server, SQL DB.

One example use for SqlLite is to as a local DB on the client that can sync data from remote SQL server and allow an app to run on the client without network connectivity.

## Steps

1) Install Entity Framework Core via NuGet.
2) Create Database Model as classes. 
3) Create DB using  [migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/index).

    For Example:    
    ```dotnet ef migrations add InitialCreate```

    ```dotnet ef database update```

4) Use the DBcontext to access SqlLite DB.
5) To run from Visual Studio [set the working directory](https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite#run-from-visual-studio)


## SqlLite Limitations

[SqlLite EF migrations limitations](https://docs.microsoft.com/en-us/ef/core/providers/sqlite/limitations)

Consider dropping the database and creating a new one rather than using migrations when the model changes.






#### Reference

[Getting Started with EF Core on .NET Core Console App with a New database](https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite)

[EF Migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/index)

[Creating and configuring a Model](https://docs.microsoft.com/en-us/ef/core/modeling/)

[SQLite & SQL Server Compact Toolbox](https://github.com/ErikEJ/SqlCeToolbox)

[.NET Generic Host](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host)

[appsettings.json in .NET Core Console App](https://blog.bitscry.com/2017/05/30/appsettings-json-in-net-core-console-app/)

[Adding logging to a .NET Core console application](https://blog.bitscry.com/2017/05/31/logging-in-net-core-console-applications/)

