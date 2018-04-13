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
        
        private Person person;

        public void SetAge(Person pers, int age)
        {
            person = pers;
            person.Age = age;
        }

        public void SetHeigth(Person pers, double height)
        {
            person = pers;
            person.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            person = pers;
            person.Weight = weight;
        }



        // Creates a person with all attibutes set
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            person = new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };

            return person;
        }



    }

    
}
