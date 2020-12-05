using System.Collections.Generic;
using System.Threading.Tasks;
using Template.Data;

namespace Template.Business.Service
{
  public interface IProcessWeatherService
  {
    Task<List<WeatherForecast>> ReplaceTemperatureAsync();
  }
}
