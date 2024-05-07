using Microsoft.Extensions.Time.Testing;
using Snapbean.DevDay2024.BackgroundServices.Services;
using Xunit;

namespace Snapbean.DevDay2024.BackgroundServices.Tests;


public class OrdinaryHostedServiceATests
{
    [Fact]
    public void StartAsync_ShouldStartSuccessfully()
    {
        var fakeTime = new FakeTimeProvider();
        //fakeTime.SetUtcNow(new DateTimeOffset(1955, 11, 5, 0, 00, 00, TimeSpan.Zero));
        // Cannot go back in time. Current time is 01.01.2000 00:00:00 +00:00. (Parameter 'value')

        fakeTime.SetUtcNow(new DateTimeOffset(2000, 01, 01, 0, 00, 00, TimeSpan.Zero));
        var sut = new OrdinaryHostedServiceA(fakeTime);
        
        _ = sut.StartAsync(new CancellationToken());
    }
}