using Template.Business.Service;

namespace Template.Test
{
  public class TestBase
  {
    protected readonly Mocks Mocks;

    public TestBase()
    {
      Mocks = new Mocks();
    }

    public ProcessWeatherService GetWeatherRepository()
    {
      return new ProcessWeatherService(Mocks.WeatherRepositoryMock.Object);
    }
  }
}
