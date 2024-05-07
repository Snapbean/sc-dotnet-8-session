using System.Reflection;
using Snapbean.DevDay2024.KeyedServices.Interfaces;

namespace Snapbean.DevDay2024.KeyedServices.Services;

public class DummyServiceB: IDummyService
{
    public void DummyMethod()
    {
        var logMessage = MethodBase.GetCurrentMethod()?.DeclaringType?.Name + "." + MethodBase.GetCurrentMethod()?.Name;
        Console.WriteLine("### Used the following class and method: {0}", logMessage);
    }
}