using System.Reflection;

namespace Snapbean.DevDay2024.BackgroundServices.Services;

public class UsefulHostedLifecycleService(TimeProvider timeProvider): IHostedLifecycleService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        var logMessage = MethodBase.GetCurrentMethod()?.DeclaringType?.Name + "." + MethodBase.GetCurrentMethod()?.Name;
        Console.WriteLine($"### Method info: {logMessage} - {timeProvider.GetLocalNow()}");

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        var logMessage = MethodBase.GetCurrentMethod()?.DeclaringType?.Name + "." + MethodBase.GetCurrentMethod()?.Name;
        Console.WriteLine($"### Method info: {logMessage} - {timeProvider.GetLocalNow()}");

        return Task.CompletedTask;
    }

    public Task StartedAsync(CancellationToken cancellationToken)
    {
        var logMessage = MethodBase.GetCurrentMethod()?.DeclaringType?.Name + "." + MethodBase.GetCurrentMethod()?.Name;
        Console.WriteLine($"### Method info: {logMessage} - {timeProvider.GetLocalNow()}");

        return Task.CompletedTask;
    }

    public Task StartingAsync(CancellationToken cancellationToken)
    {
        var logMessage = MethodBase.GetCurrentMethod()?.DeclaringType?.Name + "." + MethodBase.GetCurrentMethod()?.Name;
        Console.WriteLine($"### Method info: {logMessage} - {timeProvider.GetLocalNow()}");

        return Task.CompletedTask;
    }

    public Task StoppedAsync(CancellationToken cancellationToken)
    {
        var logMessage = MethodBase.GetCurrentMethod()?.DeclaringType?.Name + "." + MethodBase.GetCurrentMethod()?.Name;
        Console.WriteLine($"### Method info: {logMessage} - {timeProvider.GetLocalNow()}");

        return Task.CompletedTask;
    }

    public Task StoppingAsync(CancellationToken cancellationToken)
    {
        var logMessage = MethodBase.GetCurrentMethod()?.DeclaringType?.Name + "." + MethodBase.GetCurrentMethod()?.Name;
        Console.WriteLine($"### Method info: {logMessage} - {timeProvider.GetLocalNow()}");

        return Task.CompletedTask;
    }
}