using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Day
    {
        private int customersToday;
        private List<Customer> customers;
        private Weather weather;

        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            GetCustomers();
        }

        private void GetCustomers()
        {
            int customersToday = 100;

            string weatherType = weather.getWeatherType();

            int temp = weather.getTemp();

            switch (weatherType)
            {
                case "Sunny":
                    customersToday = 100;
                    break;
                case "Partly Cloudy":
                    customersToday = 75;
                    break;
                case "Overcast":
                    customersToday = 60;
                    break;
                case "Rainy":
                    customersToday = 50;
                    break;
            }

            if (temp >= 32 && temp <= 49)
            {
                customersToday = Convert.ToInt32(customersToday * .5);
            }
            else if (temp >= 50 && temp <= 69)
            {
                customersToday = Convert.ToInt32(customersToday * .85);
            }
            else if (temp >= 70 && temp <= 95)
            {
                customersToday = Convert.ToInt32(customersToday * 1.0);
            }

            for (int i = 0; i < customersToday; i++)
            {
                customers.Add(new Customer(weather));
            }
        }

        public int getSales()
        {
            int numSales = 0;

            for (int i = 0; i < customers.Count; i++)
            {

                if (customers[i].IsSale())
                {
                    numSales = numSales + 1;
                }
            }

            return numSales;
        }

    }

}

    //Implement a "random" function for number of customers that day



