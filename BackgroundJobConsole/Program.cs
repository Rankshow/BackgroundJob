using BackgroundJobConsole;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
 
var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddHostedService<BackgroundJob>()
        .AddLogging(configure => configure.AddConsole());
    }).Build();

await host.RunAsync();  