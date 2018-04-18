using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class WrongChoiseError : UserError
    {
        public override string UEMessage()
        {
            return "Please select a valid answer";
        }
    }
}
