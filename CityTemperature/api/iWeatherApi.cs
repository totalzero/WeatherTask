using CityTemperature.models;

namespace CityTemperature.api
{
    public interface iWeatherApi
    {
public Task<CurrentWeather> getCityWeatherAsync(CityCoordinates city);
    }
}