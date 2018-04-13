using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animals
{
    /// <summary>
    /// Bas class Animal - general properties/methods common to all creatures
    /// </summary>
    public class Animal
    {
        // Simple constructor
        public Animal()
        {

        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public virtual string Stats()
        {
            return Name + " " + Weight + " " + Age;
        }
         
    }
}
