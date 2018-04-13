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

            /*
             *  2. Updating the age with the helper class 'PersonHandler'
             */


            var p = new PersonHandler();
            p.SetAge(person, 50);

            Console.WriteLine($"The age is now changed to {person.Age}\n");

            /*
             *  3. Testing with additional method calls to 'PersonHandler'
             */

            Person pers1 = p.CreatePerson(12, "Zach", "Smith", 156, 32);
            Person pers2 = p.CreatePerson(14, "Bin", "Gson", 150, 31);
            Person pers3 = p.CreatePerson(8, "Rob", "Flat", 140, 22);

            p.SetAge(pers1, 13);
            p.SetWeight(pers2, 50);

            Console.WriteLine($"{pers1.FName} is now {pers1.Age} years old");
            Console.WriteLine($"{pers2.FName} has added some weight: {pers2.Weight} kgs now\n");

        }
    }
}
