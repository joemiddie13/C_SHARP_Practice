using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            Console.WriteLine(car.go);

            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car: Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle: Vehicle
    {
        public int wheels = 2;
    }
    class Boat: Vehicle
    {
        public int wheels = 0;
    }
}