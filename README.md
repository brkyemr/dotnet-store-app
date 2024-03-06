# dotnet-store-app




dotnet new web -o StoreApp/StoreApp.Web
cd StoreApp
dotnet new classlib -0 StoreApp.Data
dotnet new sln -o StoreApp


dotnet sln StoreApp add StoreApp.Data
dotnet sln StoreApp add StoreApp.Web


