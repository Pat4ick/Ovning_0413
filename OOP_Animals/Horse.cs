using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animals
{
    class Horse : Animal
    {
        private bool isPrancing;

        public bool IsPrancing
        {
            get { return isPrancing; }
            set { isPrancing = value; }
        }

    }
}
