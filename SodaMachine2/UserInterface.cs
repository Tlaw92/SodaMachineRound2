using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine2
{
    public static class UserInterface
    {
        //variables
        

        //constructor
       

        //methods

        public static void WelcomeOptions()
        {
            Console.WriteLine("Welcome to the Soda Machine!\n" +
                "We have 3 bomb flavors to choose from.\n\n" +
                "**********************************\n" +
                "****                          ****\n" +
                "****   Root Beer - 60 cents   ****\n" +
                "****      Cola - 35 cents     ****\n" +
                "****  Orange Soda - 6 cents   ****\n" +
                "****                          ****\n" +
                "**********************************\n");
        }

        public static void ChooseSoda()
        {
            Console.WriteLine("Please pick which Soda you would like to choose:\n\n" +
                "For Root Beer type A1 \n" +
                "For Cola type B1\n" +
                "For Orange Soda type C1");
            string customerChoice = Console.ReadLine();
            switch (customerChoice)
            {
                case "A1":
                    Console.WriteLine("You chose Root Beer \nPlease enter 60 cents");
                    //Customer.GatherCoins();
                    break;
                case "B1":
                    Console.WriteLine("You chose Cola \nPlease enter 35 cents");
                    //Customer.GatherCoins();
                    break;
                case "C1":
                    Console.WriteLine("You chose Orange Soda \nPlease enter 6 cents");
                    //Customer.GatherCoins();
                    break;

                default:
                    Console.WriteLine("Invalid Entry Please type again");
                    break;
            }
            
        }   



        //Coinlist
    }
}
