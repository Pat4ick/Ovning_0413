using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class SlowResponseError : UserError
    {
        public override string UEMessage()
        {
            return "You must answer promptyly";
        }
    }
}
