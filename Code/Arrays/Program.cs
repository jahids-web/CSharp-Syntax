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

            for (var element = 0; element < input; element++)
            {
                for(var sort =  element + 1; sort < input; sort++)
                {
                    if (array[sort] <= array[element])
                    {
                        var ascending = array[sort];
                        array[sort] = array[element];
                        array[element] = ascending;
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Element of array in sorted ascnding order: ");
            for(var element = 0; element <  input; element++)
            {
                Console.Write($"{array[element]}");

            }

            Console.WriteLine("\n\n");
        }
    }
}

