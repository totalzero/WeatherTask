using System.Text;
using Xunit;
using CityTemperature.tests.api;
using System.IO;
using System;
using System.Threading.Tasks;

namespace CityTemperature.tests
{
 public class CityTemperatureAppTest
 {
    [Fact]
    public async Task checkingDisplayedValues()
    {
    StringBuilder content = new StringBuilder();
    StringWriter writer = new StringWriter(content);
    Console.SetOut(writer);
    GeoCodeTestApi geoCodeApi = new GeoCodeTestApi();
    WeatherTestApi weatherApi = new WeatherTestApi();
    CityTemperatureApp app = new CityTemperatureAppForTest(geoCodeApi, weatherApi);
    await app.displayPromptAsync();
    Assert.True(content.ToString().Contains("opole"));
    Assert.True(content.ToString().Contains("10,4"));
    }
 }   
}