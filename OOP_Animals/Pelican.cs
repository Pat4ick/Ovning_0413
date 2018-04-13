using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animals
{
    class Pelican : Bird
    {

        // Beak Capacity in liters
        private double beakCapacity;

        public double BeakCapacity
        {
            get { return beakCapacity; }
            set { beakCapacity = value; }
        }

    }
}
