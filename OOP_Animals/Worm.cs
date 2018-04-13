using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animals
{
    public class Worm : Animal
    {
        public enum C
        {
            brown,
            white,
            yellow
        };

        private C color;

        public C Color
        {
            get { return color; }
            set { color = value; }
        }






    }
}
