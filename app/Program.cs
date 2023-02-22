class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Ford", "Mustang", 2022, "red");

        car1.Drive();

        Console.ReadKey();
    }
}
class Car
{
    String make;
    String model;
    int year;
    String color;

    public Car(String make, String model, int year, String color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }
    public void Drive()
    {
        Console.WriteLine("You drive the " + make + " " + model);
    }
}