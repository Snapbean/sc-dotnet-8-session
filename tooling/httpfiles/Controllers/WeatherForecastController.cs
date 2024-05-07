using Microsoft.AspNetCore.Mvc;

namespace HttpFiles.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        private static readonly IEnumerable<WeatherForecast> ForeCasts =
        [
            new() { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), Location = "Zürich", TemperatureC = Random.Shared.Next(10, 20), Summary = Summaries[Random.Shared.Next(Summaries.Length)] },
            new() { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), Location = "Zürich", TemperatureC = Random.Shared.Next(10, 20), Summary = Summaries[Random.Shared.Next(Summaries.Length)] },
            new() { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), Location = "Zürich", TemperatureC = Random.Shared.Next(10, 20), Summary = Summaries[Random.Shared.Next(Summaries.Length)] },
            new() { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), Location = "Luzern", TemperatureC = Random.Shared.Next(10, 20), Summary = Summaries[Random.Shared.Next(Summaries.Length)] },
            new() { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), Location = "Luzern", TemperatureC = Random.Shared.Next(10, 20), Summary = Summaries[Random.Shared.Next(Summaries.Length)] },
            new() { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), Location = "Luzern", TemperatureC = Random.Shared.Next(10, 20), Summary = Summaries[Random.Shared.Next(Summaries.Length)] }
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return ForeCasts.ToArray();
        }

        [HttpGet("{location}", Name = "GetWeatherForecastForLocation")]
        public IEnumerable<WeatherForecast> GetForLocation(string location)
        {
            return ForeCasts.Where(x => x.Location == location).ToArray();
        }

        [HttpPost]
        public ActionResult Add(WeatherForecast forecast)
        {
            return Created();
        }

        [HttpGet("secret")]
        public ActionResult GetSecretForecast()
        {
            if (Request.Headers.ContainsKey("X-API-KEY") && Request.Headers["X-API-KEY"] == "SuperSecret")
            {
                return Ok(ForeCasts.First());
            }

            return StatusCode(403);
        }
    }
}
