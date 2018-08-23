using System;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentCondition = new CurrentConditionDisplay(weatherData);
            SelfConditionDisplay selfCondition = new SelfConditionDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30);
            weatherData.setMeasurements(10, 89, 90);
        }
    }
}
