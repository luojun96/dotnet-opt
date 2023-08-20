using System.Collections.Generic;

namespace observer
{


    class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        
        private ISubject weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.display();
        }

        public void display()
        {
            System.Console.WriteLine($"Current conditions: {temperature} F degress and {humidity}% humidity ");
        }
    }
}