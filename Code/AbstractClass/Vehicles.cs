using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Vehicles
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public double Speed { get; set; }   
        public int ModelNumber { get; set; }

        public abstract void ApplyDiscount();
    }
}
