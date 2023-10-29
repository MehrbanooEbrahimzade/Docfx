using TestDocFX.Models;

namespace TestDocFX.Interfaces;

public interface IWeatherForecastProvider
{
    /// <summary>
    /// Returns weather forecast for the requested date range
    /// </summary>
    /// <param name="from">Starting date</param>
    /// <param name="to">Ending date</param>
    IEnumerable<WeatherForecast> GetForecasts(DateTime from, DateTime to);
}