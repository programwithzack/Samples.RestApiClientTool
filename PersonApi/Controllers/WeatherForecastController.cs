using Microsoft.AspNetCore.Mvc;

namespace PersonApi.Controllers
{
    [ApiController]
    [Route("WeatherForecast")]
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
        /// Retrieve all weather forecast informations
        /// </summary>
        /// <returns>list of <see cref="WeatherForecast"/>.</returns>
        [HttpGet]
        [Route("")]
        public IEnumerable<WeatherForecast> List()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
        }

        [HttpGet]
        [Route("{id}")]
        public WeatherForecast Get(int id)
        {
            return new WeatherForecast
            {
                Date = DateTime.Now.AddDays(id),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
        }

        /// <summary>
        /// Add new weather forecast information
        /// </summary>
        /// <param name="model"><see cref="WeatherForecast"/></param>
        /// <response code="200">Product created</response>
        /// <response code="400">Product has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your product right now</response>
        [HttpPost(Name = "")]
        public void Add(WeatherForecast model)
        {

        }

        [HttpPut(Name = "{id}")]
        public void Update(int id)
        {

        }

        [HttpDelete(Name = "{id}")]
        public void Delete(int id)
        {

        }

    }
}