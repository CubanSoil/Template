using System;
using System.Collections.Generic;
using System.Linq;

namespace Template.Data.Data
{
  public class DbInitializer
  {
    public static void Initialize(TemplateContext context)
    {
      context.Database.EnsureCreated();

      if (context.WeatherForecasts.Any())
      {
        return;
      }

      var weathersForecasts = new List<WeatherForecast>
      {
        new WeatherForecast
        {
         TemperatureC = 23,
         Date = DateTime.Now
        },
        new WeatherForecast
        {
          TemperatureC = 56,
          Date = DateTime.Now
        },
        new WeatherForecast
        {
          TemperatureC = 80,
          Date = DateTime.Now
        }
      };

      foreach (var weatherForecast in weathersForecasts)
      {
        context.WeatherForecasts.Add(weatherForecast);
      }

      context.SaveChanges();
    }
  }
}
