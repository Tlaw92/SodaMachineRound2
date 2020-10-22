using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine2
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer Nevin = new Customer();
            
            SodaMachine TheSodaMachineInTheHall = new SodaMachine();

          
            List<Coin> TheCoinsInNevinsHand = Nevin.GatherCoins();

            //TheSodaMachineInTheHall.AcceptPayment(TheCoinsInNevinsHand);

            UserInterface.WelcomeOptions();
            UserInterface.ChooseSoda();
            //UserInterface user1 = new UserInterface();
            //user1.WelcomeOptions();
        }
    }
}
