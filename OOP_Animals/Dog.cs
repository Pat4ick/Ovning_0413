using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animals
{
    class Dog : Animal
    {
        private double tailLength;

        public double TailLength
        {
            get { return tailLength; }
            set { tailLength = value; }
        }

        public string DogString()
        {
            return "Created in Dog";
        }
    }
}
