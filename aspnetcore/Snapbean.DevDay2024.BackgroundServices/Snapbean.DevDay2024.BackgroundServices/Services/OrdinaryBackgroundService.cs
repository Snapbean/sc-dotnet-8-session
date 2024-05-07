namespace Snapbean.DevDay2024.BackgroundServices.Services;

public class OrdinaryBackgroundService(TimeProvider timeProvider): BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine($"### {nameof(OrdinaryBackgroundService)}{nameof(ExecuteAsync)} entered - {timeProvider.GetLocalNow()}");
        
        while (!stoppingToken.IsCancellationRequested)
        {
            Console.WriteLine($"### {nameof(OrdinaryBackgroundService)}{nameof(ExecuteAsync)} - polling for something- {timeProvider.GetLocalNow()}");
            await Task.Delay(3000, stoppingToken);
        }
    }
}