using WeatherApp.Services;
using Xunit;

namespace WeatherApp.Tests
{
    public class WeatherServiceTests
    {
        [Fact]
        public void GetWeather_ReturnsWeatherForCity()
        {
            // Arrange
            var service = new WeatherService();
            string city = "London";

            // Act
            var result = service.GetWeather(city);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("London", result.City);
        }
        [Fact]
        public void GetWeather_ThrowsException_WhenCityIsNull()
        {
            // Arrange
            var service = new WeatherService();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.GetWeather(null));
        }
        [Fact]
        public void GetWeather_ThrowsException_WhenCityIsEmpty()
        {
            // Arrange
            var service = new WeatherService();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.GetWeather(""));
        }
    }
}