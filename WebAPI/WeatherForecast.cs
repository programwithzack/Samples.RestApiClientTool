namespace WebAPI
{
    public class WeatherForecast
    {

        /// <summary>
        /// forecast date
        /// </summary>
        /// <example>2022-06-16</example>
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}