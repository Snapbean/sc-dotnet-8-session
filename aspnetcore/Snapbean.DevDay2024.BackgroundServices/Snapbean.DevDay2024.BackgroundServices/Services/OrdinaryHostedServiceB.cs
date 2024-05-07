namespace Snapbean.DevDay2024.BackgroundServices.Services;

public class OrdinaryHostedServiceB(TimeProvider timeProvider) : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine($"### Method info: {nameof(OrdinaryHostedServiceB)}{nameof(StartAsync)} entered - {timeProvider.GetLocalNow()}");
        
        //Do some work
        await Task.Delay(3000, cancellationToken);
    }

    public  Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine($"### Method info: {nameof(OrdinaryHostedServiceB)}{nameof(StopAsync)} entered - {timeProvider.GetLocalNow()}");

        return Task.CompletedTask;
    }
}