using System.Numerics;
using System.Text.Json.Serialization;

namespace CityTemperature.models
{

    public partial class CityWeather
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [JsonPropertyName("current_weather")]
        public CurrentWeather CurrentWeather { get; set; }
    }

    public partial class CurrentWeather
    {
        public double Temperature { get; set; }
        public double Windspeed { get; set; }
        public double Winddirection { get; set; }
        public long Weathercode { get; set; }
        public string Time { get; set; }
    }
}
