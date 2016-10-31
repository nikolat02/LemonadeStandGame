using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game
    {
        private const double LEMONCUP = .2; //CONSTANT VARIABLES
        private const double CUBECUP = 3;
        private const double SUGARCUP = .2;
        private double currCash;
        private List<Day> days;
        private const int DAYSINWEEK = 7;
        private Inventory inventory;


        public Game()
        {
            inventory = new Inventory();
            currCash = 20;
            days = new List <Day>();

           for (int i =0; i < DAYSINWEEK; i++)
            {
                days.Add(new Day());
            }
            
        }
    
        public void start()
        {
            Console.WriteLine("Welcome to the Lemonade Stand Game!");

            Console.WriteLine("The premise of the game is simple.  You will have your own Lemonade Stand and you will begin each situation by deciding on the current amount of cash, inventory, prices, and weather.");

            Console.WriteLine("You will start with $20...Use it wisely!");

                        
            int numSales;
            string inputChar;
            foreach (Day currDay in days)
            {
                inputChar = "";
                while (inputChar != "D")
                {
                    Console.WriteLine("Enter a character to buy inventory.");
                    Console.WriteLine("Current Inventory is " + Math.Round(inventory.GetLemons(),2) + " Lemons, "
                        + inventory.getCups() + " Cups, " + Math.Round(inventory.GetSugar(),2) + " Cups of Sugar, " + Math.Round(inventory.getCubes(),2) + " ice cubes.");
                    //Math.Round displays as currency
                    Console.WriteLine("Current Money Available: $" + currCash);
                    Console.WriteLine("L - Buy 20 Lemons $5.00");
                    Console.WriteLine("C - Buy 100 Cups $1.00");
                    Console.WriteLine("S - Buy 10 Cups of Sugar $2.00");
                    Console.WriteLine("I - Buy 500 Ice Cubes $2.00");
                    Console.WriteLine("D - Done Buying");
                    inputChar = Console.ReadLine();
                    if (inputChar == "L" && currCash > 5)
                    {
                        inventory.BuyLemons(20);
                        currCash = currCash - 5;
                    }
                    else if (inputChar == "C" && currCash > 1)
                    {
                        inventory.BuyCups(100);
                        currCash = currCash - 1;
                    }
                    if (inputChar == "S" && currCash > 2)
                    {
                        inventory.BuySugar(10);
                        currCash = currCash - 2;
                    }
                    else if (inputChar == "I" && currCash > 2)
                    {
                        inventory.BuyCubes(500);
                        currCash = currCash - 2;
                    }
                }
                numSales = 0;
                int attemptedSales = 0;
                attemptedSales = currDay.getSales();
                for (int i = 0; i < attemptedSales; i++)
                {
                    if(inventory.GetSugar() > SUGARCUP && inventory.getCubes() > CUBECUP &&
                        inventory.GetLemons() > LEMONCUP && inventory.getCups() > 1)
                    {
                        numSales++;
                        inventory.SellCup();
                        currCash = currCash + .25;
                    }
                    else
                    {
                        Console.WriteLine("Not enough ingredients!");
                        break;
                    }
                }

                Console.WriteLine("Sales for day:  " + numSales);

            }
            Console.ReadKey();
            
        }

        
        }
    }



