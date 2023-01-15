# EmployeeManagement-CQRSPattern

This is Employee Management Project which is going to maintain the emaployee data. We are using Repository Pattern in this application with CQRS Implementation. Basically CQRS (Command and Query Responsibility Segregation) is used to seperate the Read(Query) and Write(Command) operations which makes Seperation of Concern for application. This Application uses Clean Architecture which is also known as Onion Architecture.

Four Layers Using in this Application Domain, Application, Infrastructure and UI Layer

In Clean Architecture the source code will flow from outer to inward direction that means the dependency will flow from outer layer to inner layer, which simply means if we want to change our UI, Infrastructure layers in future than it will have no effects on COre Layers (which are Application and Domain Layer).

.Net Core 3.1,
Web API,
SQL Server (not neccessary),
Postman (For Testing API), or you can use any other tool.

Just Download/Clone the application and you need to do few changes in the application such as :-
1 - Go to appsettings.json file and change the Server name according to your system;
2 - Open the Package Manager Console and run the command "Update-Database", this will automatically generate the database with demo data in sql server;
3 - Just run the application, but you will not getting the interface because this application does not have front-end as this is API Application;
4 - Open the Postman or any other API Tool and enter the localserver link and execute the api

This application is for education purpose so this application only contains 
CREATING DATA using API,
GETTING ALL DATA,
GETTING DATA USING SOME FILTERS.

Packages that required for this application are :-
MediatR,
MediatR.Extensions.Microsoft.DependencyInjection,
AutoMapper,
AutoMapper.Extensions.Microsoft.DependencyInjection,
Microsoft.EntityFrameworkCore(v 3.1),
Microsoft.EntityFrameworkCore.Relational(v 3.1),
Microsoft.EntityFrameworkCore.Design(v 3.1),
Microsoft.EntityFrameworkCore.SqlServer(v 3.1),
Microsoft.EntityFrameworkCore.Tools(v 3.1).

