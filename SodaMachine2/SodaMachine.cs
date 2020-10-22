using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine2
{
    class SodaMachine
    {
        //Variables (Has a)
        public List<Coin> register;
        public List<Can> inventory;

        //Constructor (Initial Values)
        public SodaMachine()
        {
            register = new List<Coin>();
            AddCoins(20, "Quarter");
            AddCoins(10, "Dime");
            AddCoins(20, "Nickle");
            AddCoins(50, "Penny");

            inventory = new List<Can>();
            AddCans(20, "Cola");
            AddCans(10, "Root Beer");
            AddCans(5, "Orange Soda");

        }
        //Member Methods

        public void AddCoins(int number, string coinType)
        {
            if (coinType == "Quarter")
            {
                for (int i = 0; i < number; i++)
                {
                    register.Add(new Quarter());
                }
            }
            else if (coinType == "Dime")
            {
                for (int i = 0; i < number; i++)
                {
                    register.Add(new Dime());
                }
            }
            else if (coinType == "Nickle")
            {
                for (int i = 0; i < number; i++)
                {
                    register.Add(new Nickle());
                }
            }
            else if (coinType == "Penny")
            {
                for (int i = 0; i < number; i++)
                {
                    register.Add(new Penny());
                }
            }
        }

        public void AddCans(int number, string canType)
        {
            if (canType == "Cola")
            {
                for (int i = 0; i < number; i++)
                {
                    inventory.Add(new Cola());
                }
               
            }
            else if (canType == "Root Beer")
            {
                for (int i = 0; i < number; i++)
                {
                    inventory.Add(new RootBeer());
                }
            }
            else if (canType == "Orange Soda")
            {
                for (int i = 0; i < number; i++)
                {
                    inventory.Add(new OrangeSoda());
                }
            }
        }

        //acceptpayment method
        //takes list of coins and decides what to do next( disepense, not enough, too much)
        public void AcceptPayment()
        {

        }
    }
}
