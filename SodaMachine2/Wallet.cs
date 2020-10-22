using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine2
{
    class Wallet
    {
        //Variables (Has a)
        public List<Coin> coins;
        public Card card;

        //Constructor (Initial Values)
        public Wallet() 
        {
            coins = new List<Coin>();
            AddCoins(8, "Quarter");
            AddCoins(20, "Dime");
            AddCoins(10, "Nickle");
            AddCoins(50, "Penny");
        }

        //Member Methods

        public void AddCoins(int number, string coinType)
        {
            if(coinType == "Quarter")
            {
                for (int i = 0; i < number; i++)
                {
                    coins.Add(new Quarter());
                }
            }
            else if(coinType == "Dime")
            {
                for (int i = 0; i < number; i++)
                {
                    coins.Add(new Dime());
                }
            }
            else if (coinType == "Nickle")
            {
                for (int i = 0; i < number; i++)
                {
                    coins.Add(new Nickle());
                }
            }
            else if (coinType == "Penny")
            {
                for (int i = 0; i < number; i++)
                {
                    coins.Add(new Penny());
                }
            }
        }
    }
}
