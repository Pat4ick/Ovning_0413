using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animals
{
    class Flamingo : Bird
    {
        private bool isPink;

        public bool IsPink
        {
            get { return isPink; }
            set { isPink = value; }
        }

    }
}
