using Microsoft.AspNetCore.Mvc;
using WeatherApp.Services;

namespace WeatherApp.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService = new WeatherService();

        [HttpGet]
        public IActionResult GetWeather(string city)
        {
            var result = _weatherService.GetWeather(city);
            return Ok(result);
        }
    }
}