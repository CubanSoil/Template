using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Data;
using Template.Data.Repository;

namespace Template.Business.Service
{
  public class ProcessWeatherService:IProcessWeatherService
  {
    private readonly IWeatherRepository _weatherRepository;

    public ProcessWeatherService(IWeatherRepository weatherRepository)
    {
      _weatherRepository = weatherRepository;
    }

    public async Task<List<WeatherForecast>> ReplaceTemperatureAsync()
    {
      var weathers = await _weatherRepository.GetWeatherAsync();

      return weathers.Any() ? weathers.Where(g => g.TemperatureC > 85).ToList() : weathers;
    }
  }
}
