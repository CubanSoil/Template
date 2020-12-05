using System.Collections.Generic;
using System.Threading.Tasks;

namespace Template.Data.Repository
{
  public interface IWeatherRepository
  {
    Task<List<WeatherForecast>> GetWeatherAsync();
  }
}
