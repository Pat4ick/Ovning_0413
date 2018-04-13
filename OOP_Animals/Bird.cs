using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animals
{
    class Bird : Animal
    {

        // Frequency set in flaps per minute
        private int flappingFrequency;
        public int FlappingFrequency
        {
            get { return flappingFrequency; }
            set { flappingFrequency = value; }
        }

        public static explicit operator Bird(string v)
        {
            throw new NotImplementedException();
        }

        public override string Stats()
        {
            return Name + " " + Weight + " " + Age + " " + FlappingFrequency;
        }
    }
}
