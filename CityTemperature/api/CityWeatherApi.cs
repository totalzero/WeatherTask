using System.Globalization;
using System.Text.Json;
using CityTemperature.models;

namespace CityTemperature.api
{
    public class CityWeatherApi: iWeatherApi
    {
        protected HttpClient api = new HttpClient();
 private string urlApi = "https://api.open-meteo.com/v1/forecast?latitude=50.67&longitude=17.93&current_weather=true";       

 public async Task<CurrentWeather> getCityWeatherAsync(CityCoordinates city)
 {
string url = $"https://api.open-meteo.com/v1/forecast?latitude={Math.Round(city.Latitude, 2).ToString(CultureInfo.GetCultureInfo("en-US"))}&longitude={Math.Round(city.Longitude, 2).ToString(CultureInfo.GetCultureInfo("en-US"))}&current_weather=true";       
HttpResponseMessage response = await this.api.GetAsync(url);
response.EnsureSuccessStatusCode();
string content = await response.Content.ReadAsStringAsync();
CityWeather weather = JsonSerializer.Deserialize<CityWeather>(content, new JsonSerializerOptions {
    PropertyNameCaseInsensitive = true
});
return weather.CurrentWeather;
 }
    }
}