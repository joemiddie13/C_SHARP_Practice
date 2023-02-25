using System;

namespace MyFirstSamuraiProgram
{
    class Program
    {
        static void Main(string[] args) {

            // polymorphism = Greek word that means to "have many forms"
            //                Objects can be identified by more than one type
            //                Ex. A Dog is also: Canine, Animal, Organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Samurai[] samurai = {car, bicycle, boat};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
           
            Console.ReadKey();
        }
    }
    class Samurai
    {
        public virtual void Go()
        {

        }
    }
    class Sword: Samurai
    {
        public override void Go()
        {
            Console.WriteLine("The Ghost of Tsushima draws his sword!");
        }
    }
    class Bow : Samurai
    {
        public override void Go()
        {
            Console.WriteLine("The Ghost of Tsushima stretches his bow!");
        }
    }
    class Horse : Samurai
    {
        public override void Go()
        {
            Console.WriteLine("The Ghost of Tsushima mounts his horse!");
        }
    }
}