using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animals
{
    class Swan : Bird
    {
        private bool hasShedGreyFeathers;

        public bool HasShedGreyFeathers
        {
            get { return hasShedGreyFeathers; }
            set { hasShedGreyFeathers = value; }
        }

    }
}
