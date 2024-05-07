using Snapbean.DevDay2024.KeyedServices.Interfaces;

namespace Snapbean.DevDay2024.KeyedServices.Services;

//public class UsefulService([FromKeyedServices("B")] IDummyService dummyService) : IUsefulService
public class UsefulService(IDummyService dummyService) : IUsefulService
{
    public void DoSomethingUseful()
    {
        dummyService.DummyMethod();
    }
}