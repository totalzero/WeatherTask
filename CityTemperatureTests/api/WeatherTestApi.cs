using System.Threading.Tasks;
using CityTemperature.api;
using CityTemperature.models;

namespace CityTemperature.tests.api
{
 public class WeatherTestApi: iWeatherApi 
 {
public async Task<CurrentWeather> getCityWeatherAsync(CityCoordinates city)
{
CurrentWeather weather = new CurrentWeather();
weather.Temperature = 10.4;
weather.Windspeed = 24.0;
weather.Winddirection = 204;
return weather;
}
 }  
}