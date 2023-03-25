using System.Threading.Tasks;
using CityTemperature.api;

namespace CityTemperature.tests
{
    public class CityTemperatureAppForTest: CityTemperatureApp
    {

public CityTemperatureAppForTest(iGeoCodeApi geocodeApi, iWeatherApi weatherApi): base(geocodeApi, weatherApi)
{
    
}

        public override async Task displayPromptAsync()
        {
            this.cityName = "opole";
            await this.setValuesAsync();
        }
    }
}