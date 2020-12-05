using Moq;
using Template.Data.Repository;

namespace Template.Test
{
  public class Mocks
  {
    public Mocks()
    {
      WeatherRepositoryMock = new Mock<IWeatherRepository>();
    }

    public Mock<IWeatherRepository> WeatherRepositoryMock { get; set; }
  }
}
