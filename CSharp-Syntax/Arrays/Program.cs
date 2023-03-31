namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input The Array Number: ");

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