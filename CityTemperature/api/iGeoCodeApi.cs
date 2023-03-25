using CityTemperature.models;

namespace CityTemperature.api
{
    public interface iGeoCodeApi
    {
        public Task<CityCoordinates> getCityCoordinatesAsync(string cityName);
    }
}