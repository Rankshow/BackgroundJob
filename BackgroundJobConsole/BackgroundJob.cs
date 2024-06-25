using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace BackgroundJobConsole;

internal class BackgroundJob : IHostedService, IDisposable
{
    readonly ILogger<BackgroundJob> _logger;
    private Timer _timer;
    public BackgroundJob(ILogger<BackgroundJob> logger)
    {
        _logger = logger;
    }
    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Starting background service.....");
        _timer = new(ShoutMessage, null, TimeSpan.Zero, TimeSpan.FromSeconds(8));
        return Task.CompletedTask;  
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Stopping the background service");
        _timer.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }
    public void Dispose()
    {
        _logger.LogInformation("Disposing timer object...");
        _timer.Dispose();
        //GC.SuppressFinalize(this); //This is use to prevent memory
    }

    private async void ShoutMessage(object? state)
    {
        Console.WriteLine("Happy birthday Gabriel, may lines fall in your path....");
    }
}
