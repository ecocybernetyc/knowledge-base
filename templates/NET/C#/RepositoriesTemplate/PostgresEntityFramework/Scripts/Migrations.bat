dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate --project ../PostgresEntityFramework.csproj --startup-project ../../RepositoriesTemplate/RepositoriesTemplate.csproj
dotnet ef database update --project ../PostgresEntityFramework.csproj --startup-project ../../RepositoriesTemplate/RepositoriesTemplate.csproj