using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You hvar tried to use a text input in a numerical field only field. This fired an error!";
        }
    }
}
