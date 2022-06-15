using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Retrieves all weather forecast information
        /// </summary>
        /// <returns>list of <see cref="WeatherForecast" /></returns>
        [HttpGet(""), SwaggerOperation(OperationId = "GetWeatherForecasts")]
        public IEnumerable<WeatherForecast> List()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
        }

        [HttpGet("{id}"), SwaggerOperation(OperationId = "GetWeatherForecast")]
        public WeatherForecast GetById(int id)
        {
            return new WeatherForecast
            {
                Date = DateTime.Now.AddDays(id),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
        }

        [HttpGet("datetime/{dt}"), SwaggerOperation(OperationId = "GetWeatherForecastByDate")]
        public WeatherForecast GetByDate(DateTime dt)
        {
            return new WeatherForecast
            {
                Date = dt,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
        }

        [HttpPost(""), SwaggerOperation(OperationId = "AddWeatherForecast")]
        public void Add(WeatherForecast model)
        {

        }

        [HttpPut("{id}"), SwaggerOperation(OperationId = "UpdateWeatherForecast")]
        public void Update(int id, WeatherForecast model)
        {

        }

        [HttpDelete("{id}"), SwaggerOperation(OperationId = "DeleteWeatherForecast")]
        public void Delete(int id)
        {

        }

    }
}