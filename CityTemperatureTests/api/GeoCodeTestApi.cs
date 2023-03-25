using System.Threading.Tasks;
using CityTemperature.api;
using CityTemperature.models;

namespace CityTemperature.tests.api
{
public class GeoCodeTestApi: iGeoCodeApi
{
    public async Task<CityCoordinates> getCityCoordinatesAsync(string cityName)
    {
CityCoordinates coordinates = new CityCoordinates();
coordinates.Name = cityName;
coordinates.Id = 1;
coordinates.Latitude = 50.123;
coordinates.Longitude = 12.321;
return coordinates;
    }
}    
}