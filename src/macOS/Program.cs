// See https://aka.ms/new-console-template for more information

using Cupboard;

Console.WriteLine("Hello, World!");

return CupboardHost
    .CreateBuilder()
    .AddCatalog<MobileDevelopmentCatalog>()
    .Build()
    .Run(args);