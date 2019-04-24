# .NET Core Console sample with EF Core and MySQL (Pomelo) db context
A sample of how to setup a .NET Core Console app with Entity Framework (Pomelo MySQL) db context

This is a sample of a console app project set up for using a MySQL database

EF Lib. used: `Pomelo.EntityFrameworkCore.MySql`

> Repo can be found: [github/PomeloFoundation](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)<br>
> Latest NuGet package: [nuget/Pomelo.EntityFrameworkCore.MySql](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql) 

**Notes**:
- Pomelo nuget package should be added into the DAL project, and referrenced from within the Console-app project, 
unless the solution contains only one project.
- The db connection is set up within the `OnConfiguring` dbcontext override, and it should define the MigrationAssembly (DAL project)
- Besides the `Pomelo.EntityFrameworkCore.MySql` package, and the `Microsoft.NETCore.App` SDK, 
there's no need for using additional EF packages as 
  - `Microsoft.EntityFrameworkCore`, 
  - `Microsoft.EntityframeworkCore.Design` or 
  - `Microsoft.EntityFrameworkCore.Tools`<br><br>
If however issues are encountered while eg. adding migrations or updating the database, prompting that any 
`Microsoft.EntityFrameworkCore` packages are required, using either a cli (dotnet command) or PM - 
that means the dbcontext or Pomelo nuget package are not set up correctly in most cases. The `Pomelo.EntityFrameworkCore.MySql` nuget package contains all dependencies within itself. However still in some cases, depending on the versions of the Pomelo EF package and .NET Core SDK, it might be required to add `Microsoft.EntityFrameworkCore.Design`.
- You can use add migration, update database etc. (`dotnet` or `PM`) commands the same way as with any EF db provider eg. SQL Server.
There mostly are no differences in how the object mapping is performed by default EF or Pomelo EF, 
but Pomelo's documentation should still be checked out.
- The simplest way to start using the db context right away, in the Console app project, is by creating an instance with the `new` keyword.
