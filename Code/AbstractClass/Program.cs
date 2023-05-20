using System;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Bike = new Bike();
            Bike.Name = "Test";
            Bike.ModelNumber = 1;
            Bike.Speed = 12.0;
            Bike.Price = 100;
            Bike.ApplyDiscount();
            Console.WriteLine($"Total Price {Bike.Price}");

            Console.WriteLine("\n");

            var Car = new Car();
            Car.Name = "Test";
            Car.ModelNumber = 1;
            Car.Speed = 12.0;
            Car.Price = 800;
            Car.ApplyDiscount();
            Console.WriteLine($"Total Price {Car.Price}");

            Console.WriteLine("\n"); 

            var Caycle = new Caycle();
            Caycle.Name = "Test";
            Caycle.ModelNumber = 1;
            Caycle.Speed = 12.0;
            Caycle.Price = 400;
            Caycle.ApplyDiscount();
            Console.WriteLine($"Total Price {Caycle.Price}");

        }
    }
}
