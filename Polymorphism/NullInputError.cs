using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "Object not initialized - cannot provide a NULL answer";
        }
    }
}
