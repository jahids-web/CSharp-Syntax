using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Car : Vehicles
    {
        public override void ApplyDiscount()
        {
            Console.WriteLine($"Discount Price {(Price - 5)}");
        }
    }
}
