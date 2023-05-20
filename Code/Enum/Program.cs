using System;

namespace Enum
{
    class Program
    {
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }


        static void Main(string[] args)
        {
            Season weather = Season.Spring;
            Console.WriteLine($"Integral value of = {weather}");

            Season weather2 = Season.Summer;
            Console.WriteLine($"Integral value of = {weather2}");

            Season weather3 = Season.Autumn;
            Console.WriteLine($"Integral value of = {weather3}");

            Season weather4 = Season.Winter;
            Console.WriteLine($"Integral value of = {weather4}");
        }
    }
}
