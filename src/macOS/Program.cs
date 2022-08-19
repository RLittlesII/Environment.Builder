// See https://aka.ms/new-console-template for more information

using Cupboard;
using Microsoft.Extensions.DependencyInjection;
using Spectre.IO;

Console.WriteLine("Hello, World!");

return CupboardHost
    .CreateBuilder()
    .AddCatalog<MobileDevelopmentCatalog>()
    .ConfigureServices(services =>
        services
            .AddSingleton<IEnvironment, Spectre.IO.Environment>()
            .AddSingleton<IPlatform, Platform>())
    .Build()
    .Run(args);