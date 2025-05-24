using System.Diagnostics;
using TemperatureSpace;

namespace weatherreport.Tests
{
    static class RainyWeatherTester
    {
        public static void TestRainy()
        {
            var rainyConditions = SensorStubFactory.Instance.SensorStubWeatherList.FindAll(
                tuple => tuple.Item2.Contains("Rain"));

            // IWeatherSensor sensor = new SensorStub();
            
            foreach (var rainyCondition in rainyConditions)
            {
                IWeatherSensor sensor = rainyCondition.Item1;
                string report = WeatherReport.Report(sensor);
                Console.WriteLine(report);

                Debug.Assert(report.Contains(rainyCondition.Item2));
            }
        }
    }
}
