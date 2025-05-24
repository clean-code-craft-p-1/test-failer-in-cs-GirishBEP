using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureSpace;

namespace weatherreport.Tests
{
    class HighPrecipitationTester
    {
        public static void TestHighPrecipitation()
        {
            var highPrecipitationConditions = SensorStubFactory.Instance.SensorStubWeatherList.FindAll(
               tuple => tuple.Item1.IsHighPrecipitation());

            // IWeatherSensor sensor = new SensorStub();

            foreach (var highPrecipitationCondition in highPrecipitationConditions)
            {
                IWeatherSensor sensor = highPrecipitationCondition.Item1;
                string report = WeatherReport.Report(sensor);
                Console.WriteLine(report);
                Debug.Assert(report.Contains(highPrecipitationCondition.Item2));
            }
        }
    }
}
