using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var errors = new List<UserError>()
            {
                new TextInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TextInputError(),
                new NullInputError(),
                new SlowResponseError(),
                new WrongChoiseError(),

            };

            foreach(UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }



        }
    }
}
