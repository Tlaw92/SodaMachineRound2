using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;w
using System.Threading.Tasks;

namespace SodaMachine2
{
    class Wallet
    {
        //Variables (Has a)
        public List<Coin> coins;
        public Card card;
        public List<Quarter> quartersList;
        public List<Dime> dimeList;
        public List<Nickle> nickleList;
        public List<Penny> pennyList;


        //Constructor (Initial Values)
        public Wallet() //Wallet should start out with $5 in change
        {
            coins = new List<Coin>();
            quartersList = new List<Quarter>();
            AddCoins(4, quartersList);
            
        }

        //Member Methods
        public void AddCoins(int numberOfCoins, List<Quarter> listOfQuarters) 
        {
            CashRegister.AddCoinToList(numberOfCoins, listOfQuarters);
        }

        public void AddCoins(int numberOfCoins, List<Dime> coins) //one parameter is int 2nd is 
        {
            //
        }
        public void AddCoins(int numberOfCoins, List<Nickle> coins) //one parameter is int 2nd is 
        {
            //
        }
        public void AddCoins(int numberOfCoins, List<Penny> coins) //one parameter is int 2nd is 
        {
            //
        }
    }
}
