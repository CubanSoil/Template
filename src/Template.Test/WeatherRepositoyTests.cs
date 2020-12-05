using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using Template.Api;
using Template.Data;

namespace Template.Test
{
  public class WeatherRepositoyTests:TestBase
  {
    [Test]
    public async Task ProcessWeatherService_GivenAnyResults_ShouldFilterTemperature()
    {
      //Arrange
      var weathersForecasts = new List<WeatherForecast>
      {
        new WeatherForecast
        {
          TemperatureC = 55,
          Date = DateTime.Now
        },
        new WeatherForecast
        {
          TemperatureC = 12,
          Date = DateTime.Now
        },
        new WeatherForecast
        {
          TemperatureC = 777,
          Date = DateTime.Now
        }
      };
      
      Mocks.WeatherRepositoryMock.Setup(s => s.GetWeatherAsync()).ReturnsAsync(weathersForecasts);
      var systemUnderTest = GetWeatherRepository();

      //Act
      var results = await systemUnderTest.ReplaceTemperatureAsync();
      //Assert

      results.Should().HaveCount(1);
      results.Select(x => x.TemperatureC).Should().Equal(777);
    }
  }
}
