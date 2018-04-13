using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Animals
{
    class Program
    {
        /*
          
            8. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, 
            i  vilken klass bör vi lägga det?   
         
            Birdklassen

            9. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då? 
            
            Animalklassen


         */


        static void Main(string[] args)
        {
            var worm = new Worm
            {
                Color = Worm.C.brown
            };

            var hedgehog = new Hedgehog
            {
                NumberOfSpikes = 5400
            };

            var dog = new Dog
            {
                TailLength = 15.3
            };

            var horse = new Horse
            {
                IsPrancing = true
            };

            var bird = new Bird
            {
                FlappingFrequency = 60
            };

            var pelican = new Pelican
            {
                BeakCapacity = 2.5
            };

            var flamingo = new Flamingo
            {
                IsPink = true
            };

            var swan = new Swan
            {
                HasShedGreyFeathers = false
            };

        }
    }
}
