using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{

    class Customer
    {
        private static Random myrandomint;
        private Weather customerweather;
        private double probability;

        public Customer(Weather weather)
        {
            customerweather = weather;
            BuyProbability();
        }

        private void BuyProbability()
        {
            probability = 0;
            string weatherType = customerweather.getWeatherType();

            int temp = customerweather.getTemp();

            switch (weatherType)
            {
                case "Sunny":
                    probability = .3;
                    break;
                case "Partly Cloudy":
                    probability = .15;
                    break;
                case "Overcast":
                    probability = .15;
                    break;
                case "Rainy":
                    probability = .05;
                    break;
            }

            if (temp >= 32 && temp <= 49)
            {
                probability = probability + .05;
            }
            else if (temp >= 50 && temp <= 69)
            {
                probability = probability + .15;
            }
            else if (temp >= 70 && temp <= 95)
            {
                probability = probability + .3;
            }
        }

        public bool IsSale()
        {
            if(myrandomint == null)
                myrandomint = new Random();
            double tempProb = probability * 100;
            //Console.WriteLine(probability);
            int randInt = myrandomint.Next(100);
                                                     // ORDER OF OPERATIONS!!
            if (randInt < (probability * 100))
            {
                return true;
            }
            else return false;
            
        }
    }
}