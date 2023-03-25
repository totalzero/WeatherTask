using CityTemperature.models;
using CityTemperature.api;

namespace CityTemperature
{
    public class CityTemperatureApp
    {
        protected string cityName;
        protected CurrentWeather weather;
 protected iGeoCodeApi _geoCodeApi;
protected iWeatherApi _weatherApi;

public CityTemperatureApp(iGeoCodeApi geoCodeApi, iWeatherApi weatherApi) 
{
this._geoCodeApi = geoCodeApi;
this._weatherApi = weatherApi;
}

public virtual async Task displayPromptAsync() {
Console.WriteLine("Witaj w weather tasku dzieki ktoremu mozesz sprawdzic sobie pogode dla wybranego miasta.");
Console.WriteLine("podaj nazwe miasta.");
this.cityName = Console.ReadLine();
await this.setValuesAsync();
}

protected virtual async  Task setValuesAsync()
{
CityCoordinates coordinates = await this._geoCodeApi.getCityCoordinatesAsync(this.cityName);
this.weather = await this._weatherApi.getCityWeatherAsync(coordinates);
this.displayResult();
}

protected virtual void displayResult()
{
    Console.WriteLine($"Pogoda w mieście {this.cityName}");
    Console.WriteLine($"Temperatura: {this.weather.Temperature} st. C. ");
    Console.WriteLine($"Prędkość Wiatru: {this.weather.Windspeed} km/h");
    Console.WriteLine($"Kierunek Wiatru: {this.weather.Winddirection}");
}

    }
}