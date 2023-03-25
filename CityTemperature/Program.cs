using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using CityTemperature.models;
using CityTemperature.api;
using System.Globalization;

namespace CityTemperature
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var app = new CityTemperatureApp(new CityGeoCodeApi(), new CityWeatherApi());
            await app.displayPromptAsync();
}
    }
}
