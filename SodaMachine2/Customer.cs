﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine2
{
    class Customer
    {
        //Variables (Has a)
        public Wallet wallet;
        public Backpack backpack;


        //Constructor (Initial Values)
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
        }

        //Member Methods

        public List<Coin> GatherCoins()
        {
            List<Coin> payment = new List<Coin>();
            while (true)
            {
                Console.WriteLine("Which coin would you like to insert?");
                Console.WriteLine("Press 1 for Quarter \nPress 2 for Dime \n Press 3 for Nickle" +
                    "Press 4 for Penny \n And press 5 after finished");
                string coinChoice = Console.ReadLine();

                switch (coinChoice)
                {
                    case "1":
                        FindCoin("Quarter", payment);
                        break;
                    case "2":
                        FindCoin("Dime", payment);
                        break;
                    case "3":
                        FindCoin("Nickle", payment);
                        break;
                    case "4":
                        FindCoin("Penny", payment);
                        break;
                    case "5":
                        return payment;
                    default:
                        break;
                }
                
            }
        }
        public void FindCoin(string coinName, List<Coin> payment)
        {
            for (int i = 0; i < wallet.coins.Count; i++)
            {
                if (wallet.coins[i].Name == coinName)
                {
                    payment.Add(wallet.coins[i]);
                    wallet.coins.RemoveAt(i);
                    break;
                }
            }
        }
        public void ChooseSoda()
        {
            //ChooseSoda()
        }

        public void ChooseCans()
        {

        }


        //public void InsertCoin()
        //{
        //    if (true)//amount of change in wallet is equal to cost of soda
        //    {
        //        // add Soda to List in backpack
        //    }
        //    else if (true) //amount of change in wallet is less than cost 
        //    {
        //        // put change back into wallet and run ChooseSoda method again
        //    }
        //    else if (true) //amount of change in wallet is more than cost
        //    {
        //        // add soda to backpack and calculate change returned to wallet
        //    }
        //}
    }
}
