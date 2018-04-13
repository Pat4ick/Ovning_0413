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
        private  Person _person;

        public void SetAge(Person pers, int age)
        {
            _person = pers;
            _person.Age = age;
        }
    }
}
