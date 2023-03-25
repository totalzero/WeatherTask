namespace CityTemperature.models
{

    public partial class CityGeoCode
    {
        public CityCoordinates[] Results { get; set; }
        public double GenerationtimeMs { get; set; }
    }

    public partial class CityCoordinates
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        
    }
}