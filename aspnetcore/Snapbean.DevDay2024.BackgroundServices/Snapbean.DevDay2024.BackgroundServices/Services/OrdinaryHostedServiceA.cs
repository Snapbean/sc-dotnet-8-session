namespace Snapbean.DevDay2024.BackgroundServices.Services;

public class OrdinaryHostedServiceA(TimeProvider timeProvider): IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine($"### Method info: {nameof(OrdinaryHostedServiceA)}{nameof(StartAsync)} entered - {timeProvider.GetLocalNow()}");
        
        //Do some work
        await Task.Delay(3000, cancellationToken);
    }

    public  Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine($"### Method info: {nameof(OrdinaryHostedServiceA)}{nameof(StopAsync)} entered - {timeProvider.GetLocalNow()}");

        return Task.CompletedTask;
    }
}