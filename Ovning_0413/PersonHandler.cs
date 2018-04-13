using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_0413
{
    /// <summary>
    /// PersonHandler - For abstracting the 'Person' class
    /// </summary>
    public  class PersonHandler
    {
        public  Person person;

        public void SetAge(Person pers, int age)
        {
            person = pers;
            person.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;

            return person;
        }

    }

    
}
