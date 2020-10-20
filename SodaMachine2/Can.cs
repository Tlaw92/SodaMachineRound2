using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine2
{
    abstract class Can
    {
        //Variables (Has a)
        public string name;
        protected double cost;

        public double Cost
        {
            get
            {
                return cost;
            }
        }
        

        //Constructor (Initial Values)
        public Can()
        {

        }

        //Member Methods
    }
}
