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

            var animals = new List<Animal>();
            var dogs = new List<Dog>();
        

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
                FlappingFrequency = 60,
                Age = 5
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

            animals.Add(swan);
            animals.Add(bird);
            animals.Add(horse);

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
                Console.WriteLine(animal.Age);
            }



            /*
                7. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?  
                
                Horse != Dog

                8. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans? 
                
                Animal

                11. F: Förklara vad det är som händer.

                

             */

            foreach (Animal animal in animals)
            {
                

                Console.WriteLine(animal.Stats());
            }
            /*
                11.F: Förklara vad det är som händer.

                Krashar då den måste castas från animal till rätt typ innan metoden anropas.
                Ska testa det...


            */




            // dogs.Add(horse); /




        }
    }
}
