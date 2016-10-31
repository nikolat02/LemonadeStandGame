using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Weather
    {
        private int temperature;
        private string weather;
        private static Random random;
        List<string> weatherTypes;
        //0 = Sunny
        //1 = Partly cloudy
        //2 = Overcast
        //3 = Rainy

        public Weather()
        {
            weatherTypes = new List<string> { "Sunny", "Partly Cloudy", "Overcast", "Rainy" };
            if(random == null)
                random = new Random();
            DecideTemperature();
            DecideWeather();
        }
        private void DecideWeather()
        {
            weather = weatherTypes[random.Next(0, 3)];
        }
        private void DecideTemperature()
        {
            temperature = random.Next(32, 95);
        }

        public int getTemp()
        {
            return temperature;
        }

        public string getWeatherType()
        {
            return weather;
        }

        public void ShowWeather()
        {
            Console.WriteLine(weather + temperature);  //May need to comment out if weather doesn't display
        }

        

    }
}
