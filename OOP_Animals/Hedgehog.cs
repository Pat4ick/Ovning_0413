using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animals
{
    class Hedgehog : Animal
    {
        private int numberOfSpikes;

        public int NumberOfSpikes
        {
            get { return numberOfSpikes; }
            set { numberOfSpikes = value; }
        }

    }
}
