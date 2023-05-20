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


        }
    }
}
