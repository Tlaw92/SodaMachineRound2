using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine2
{

    //This class instantiates Coin objects and has methods to add and remove coins to/from list
      //
    static class CashRegister
    {
        // don't need variables

        //don't need a Constructor

        //coin mint methods
        public static Quarter CreateQuarter()
        {
            Quarter quarter = new Quarter();
            Console.WriteLine("A quarter was made");
            return quarter;
        }

        public static Dime Dime()
        {
            Dime dime = new Dime();
            return dime;
        }

        public static Nickle Nickle()
        {
            Nickle nickle = new Nickle();
            return nickle;
        }

        public static Penny Penny()
        {
            Penny penny = new Penny();
            return penny;
        }


        //assemble methods
        //add quarter
        public static void AddCoinToList(int numberOfSpecificCoins,List<Quarter> quartersList)
        {
            for (int i = 0; i < numberOfSpecificCoins; i++)
            {
                quartersList.Add(CreateQuarter());
                Console.WriteLine("The quarter was added to the Quarter list");
            }
        }
        //add dime
        public static void AddCoinToList(int numberOfSpecificCoins, List<Dime> dimesList)
        {
            for (int i = 0; i < numberOfSpecificCoins; i++)
            {
                dimesList.Add(Dime());
            }
        }

        //add nickle
        public static void AddCoinToList(int numberOfSpecificCoins, List<Nickle> nickleList)
        {
            for (int i = 0; i < numberOfSpecificCoins; i++)
            {
                nickleList.Add(Nickle());
            }
        }

        public static void AddCoinToList(int numberOfSpecificCoins, List<Penny> pennyList)
        {
            for (int i = 0; i < numberOfSpecificCoins; i++)
            {
                pennyList.Add(Penny());
            }
        }




        //Remove methods
        public static void RemoveCoinFromList(int numberOfSpecificCoins, List<Quarter> quarterList)
        {
            for (int i = 0; i < numberOfSpecificCoins; i++)
            {
                quarterList.RemoveAt(0);
            }
        }

        public static void RemoveCoinFromList(int numberOfSpecificCoins, List<Dime> dimeList)
        {
            for (int i = 0; i < numberOfSpecificCoins; i++)
            {
                dimeList.RemoveAt(0);
            }

        }

        public static void RemoveCoinFromList(int numberOfSpecificCoins, List<Nickle> nickleList)
        {
            for (int i = 0; i < numberOfSpecificCoins; i++)
            {
                nickleList.RemoveAt(0);
            }
        }

        public static void RemoveCoinFromList(int numberOfSpecificCoins, List<Penny> pennyList)
        {
            for (int i = 0; i < numberOfSpecificCoins; i++)
            {
                pennyList.RemoveAt(0);
            }
        }
    }
}
