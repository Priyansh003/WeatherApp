using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        public WeatherResponse GetWeather(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("City cannot be empty");
            }

            return new WeatherResponse
            {
                City = city,
                Temperature = 25,
                Condition = "Sunny"
            };
        }
    }
}