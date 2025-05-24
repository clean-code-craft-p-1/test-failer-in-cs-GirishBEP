
namespace TemperatureSpace
{
    /// <summary>
    /// This is a stub for a weather sensor. For the sake of testing 
    /// we create a stub that generates weather data and allows us to
    /// test the other parts of this application in isolation
    /// without needing the actual Sensor during development
    /// </summary>
    internal class SensorStub : IWeatherSensor
    {
        private readonly int _humidity;
        private readonly int _precipitation;
        private readonly double _temperatureInC;
        private readonly int _windSpeedKMPH;

        public SensorStub(int humidity, int precipitation, double temperatureInC, int windSpeedKMPH)
        {
            _humidity = humidity;
            _precipitation = precipitation;
            _temperatureInC = temperatureInC;
            _windSpeedKMPH = windSpeedKMPH;
        }
        public SensorStub()
        {
            // Default values for testing
            _humidity = 72; // Example humidity
            _precipitation = 70; // Example precipitation
            _temperatureInC = 26.0; // Example temperature in Celsius
            _windSpeedKMPH = 52; // Example wind speed in km/h
        }
        int IWeatherSensor.Humidity()
        {
            return _humidity;
        }

        public bool IsHighHumidity()
        {
            return _humidity > 70;
        }

        int IWeatherSensor.Precipitation()
        {
            return _precipitation;
        }
        public bool IsHighPrecipitation()
        {
            return _precipitation > 50;
        }
        public bool IsLowPrecipitation()
        {
            return _precipitation < 20;
        }
        double IWeatherSensor.TemperatureInC()
        {
            return _temperatureInC;
        }

        public bool IsHighTemperature()
        {
            return _temperatureInC > 25.0;
        }



        int IWeatherSensor.WindSpeedKMPH()
        {
            return _windSpeedKMPH;
        }

        public bool IsHighWindSpeed()
        {
            return _windSpeedKMPH > 50;
        }


    }
}