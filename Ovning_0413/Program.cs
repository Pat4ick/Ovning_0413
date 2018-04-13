using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_0413
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Setting value of the private field 
             */

            var person = new Person();
            person.Age = 49;
            Console.WriteLine("Yes, I can access the private fields indireclty by using the public properties\n" +
                $"I have set the age to \"49\" as an example and here i read the value back again - {person.Age}\n");


        }
    }
}
