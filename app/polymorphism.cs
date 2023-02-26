using System;

namespace MyFirstSamuraiProgram
{
    class Program
    {
        static void Main(string[] args) {

            // polymorphism = Greek word that means to "have many forms"
            //                Objects can be identified by more than one type
            //                Ex. A Dog is also: Canine, Animal, Organism

            Sword sword = new Sword();
            Bow bow = new Bow();
            Horse horse = new Horse();

            Samurai[] samurai = {sword, bow, horse};

            foreach (Samurai samurai in samurais)
            {
                samurai.Go();
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