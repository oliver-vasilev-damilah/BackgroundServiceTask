using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        /// Register services here
    })
    .ConfigureLogging((context, logging) =>
    {
        logging.ClearProviders(); // Remove default providers
        logging.AddConsole(); // Add Console logging provider
    });

var host = builder.Build();
await host.RunAsync();
