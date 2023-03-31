using System;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input The Array Number: ");

            var input = int.Parse(Console.ReadLine());
            var array = new int[input];

            for (var element = 0; element < input; element++)
            {
                Console.Write($"Element - {element}: ");
                array[element] = int.Parse(Console.ReadLine());
            }
        }
    }
}
