using System.Text.Json;
using System.Threading.Tasks;
using CityTemperature.models;

namespace CityTemperature.api
{
 public class CityGeoCodeApi: iGeoCodeApi
 {
 private HttpClient api = new HttpClient();   
 private string urlApi = "https://geocoding-api.open-meteo.com/v1/search?name=";

 public async Task<CityCoordinates> getCityCoordinatesAsync(string cityName)
 {
    var response = await this.api.GetAsync(this.urlApi + cityName);
    response.EnsureSuccessStatusCode();
    string content = await response.Content.ReadAsStringAsync();
    CityGeoCode geoCode = JsonSerializer.Deserialize<CityGeoCode>(content, new JsonSerializerOptions {
      PropertyNameCaseInsensitive = true
    });
    return geoCode.Results[0];
 }
 }   
}