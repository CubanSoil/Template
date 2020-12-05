using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Template.Data.Data;

namespace Template.Data.Repository
{
  public class WeatherRepository : IWeatherRepository
  {
    private readonly TemplateContext _templateContext;

    public WeatherRepository(TemplateContext templateContext)
    {
      _templateContext = templateContext;
    }
    public async Task<List<WeatherForecast>> GetWeatherAsync()
    {
      return await _templateContext.WeatherForecasts.ToListAsync();
    }
  }
}
