namespace Snapbean.DevDay2024.ShortCircuitRouting.Middlewares;

public class UsefulMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        await next(context);
    }
}