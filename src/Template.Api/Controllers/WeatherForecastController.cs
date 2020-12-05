using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Template.Data;
using Template.Data.Repository;

namespace Template.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private static readonly string[] Summaries = new[]
    {
      "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherRepository _weatherRepository;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherRepository weatherRepository)
    {
      _logger = logger;
      _weatherRepository = weatherRepository;
    }

    [HttpGet]
    public async Task<List<WeatherForecast>> Get()
    {
      return await _weatherRepository.GetWeatherAsync();
    }
  }
}
