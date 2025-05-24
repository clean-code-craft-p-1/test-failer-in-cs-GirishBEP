using TemperatureSpace;

namespace weatherreport
{
    class SensorStubFactory
    {
        private static SensorStubFactory _instance;
        private static readonly object _lock = new object();

        public List<Tuple<SensorStub, string>>? SensorStubWeatherList { get; private set; }

        /// <summary>
        /// Private constructor to prevent instantiation
        /// </summary>
        private SensorStubFactory()
        {
            SensorStubWeatherList = new List<Tuple<SensorStub, string>>()
                {
                    // humidity, precipitation, temperatureInC, windSpeedKMPH, weatherDescription
                    new Tuple<SensorStub, string>(new SensorStub(35, 0, 34, 10), "Sunny"),
                    new Tuple<SensorStub, string>(new SensorStub(70, 0, 25, 15), "Partly Cloudy"),
                    new Tuple<SensorStub, string>(new SensorStub(90, 0, 22, 5), "Cloudy"),
                    new Tuple<SensorStub, string>(new SensorStub(80, 55, 24, 30), "Rainy with Thunderstorm"),
                    new Tuple<SensorStub, string>(new SensorStub(95, 60, 26, 70), "Stormy with Heavy Rain"),
                    new Tuple<SensorStub, string>(new SensorStub(60, 0, 26, 45), "Windy"),
                    new Tuple<SensorStub, string>(new SensorStub(50, 0, 22, 10), "Mild Weather"),
                    new Tuple<SensorStub, string>(new SensorStub(90, 70, 18, 60), "Stormy with Heavy Rain"),
                    new Tuple<SensorStub, string>(new SensorStub(30, 0, 40, 5), "Hot and Dry / Sunny"),
                    new Tuple<SensorStub, string>(new SensorStub(85, 2, 28, 10), "Light Rain / Cloudy"),
                    new Tuple<SensorStub, string>(new SensorStub(40, 65, 31, 15), "Hot with Rain"),
                    new Tuple<SensorStub, string>(new SensorStub(55, 51, 12, 20), "Cold Rainy"),
                    new Tuple<SensorStub, string>(new SensorStub(20, 0, 10, 5), "Cold and Dry"),
                    new Tuple<SensorStub, string>(new SensorStub(35, 0, 15, 50), "Windy and Cool"),
                    new Tuple<SensorStub, string>(new SensorStub(75, 0, 5, 10), "Cloudy and Cold")
                };
        }

        /// <summary>
        /// Public method to get the singleton instance
        /// </summary>
        public static SensorStubFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SensorStubFactory();
                        }
                    }
                }
                return _instance;
            }
        }
    }
    }