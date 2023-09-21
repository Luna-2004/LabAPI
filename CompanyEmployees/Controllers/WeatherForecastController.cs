using CompanyEmployees;
using Contracts;
using LoggerService;
using Microsoft.AspNetCore.Mvc;

namespace APIRestLab01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
  };

        //private readonly ILogger<WeatherForecastController> _logger;
        private ILoggerManager _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}
        public WeatherForecastController(ILoggerManager logger)
        {
            this._logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogInfo("hello is info message from our  values controller.");
            _logger.LogDebug("hello is info message from our  values controller.");
            _logger.LogWarn("hello is info message from our  values controller.");
            _logger.LogError("hello is info message from our  values controller.");

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}