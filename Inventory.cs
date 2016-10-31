using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Inventory
    {
        private const double LEMONCUP = .2;  //CONSTANT VARIABLES
        private const double CUBECUP = 3;
        private const double SUGARCUP = .2;
        private double lemonsCount;
        private double cupsOfSugarCount;
        private double iceCubesCount;
        private double cupsCount;

        public Inventory()
        {
            lemonsCount = 0;
            cupsOfSugarCount = 0;
            iceCubesCount = 0;
            cupsCount = 0;   
        }
        
        public double GetLemons()
        {
            return lemonsCount;
        }

        public double GetSugar()
        {
            return cupsOfSugarCount;
        }

        public double getCubes()
        {
            return iceCubesCount;

        }

        public double getCups()
        {
            return cupsCount;
        }
        public void BuyLemons(int NumLemons)
        {
            lemonsCount =  lemonsCount+ NumLemons;
        }

        public void BuyCubes(int NumCubes)
        {
            iceCubesCount = iceCubesCount + NumCubes;
        }

        public void BuySugar(int NumSugar)
        {
            cupsOfSugarCount = cupsOfSugarCount + NumSugar;
        }

        public void BuyCups(int NumCups)
        {
            cupsCount = cupsCount + NumCups;
        }

        public void SellCup()
        {
            cupsCount--;
            cupsOfSugarCount = cupsOfSugarCount - SUGARCUP;
            lemonsCount = lemonsCount - LEMONCUP;
            iceCubesCount = iceCubesCount - CUBECUP;
            
        }
    }
}
