using Microsoft.Extensions.Hosting;

namespace BackgroundJobConsole;

internal class BackgroundJob : IHostedService, IDisposable
{

    public Task StartAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
