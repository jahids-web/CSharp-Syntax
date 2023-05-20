using System;

namespace If_Else_Statement
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = 5;
            if (x == 10)
            {
                Console.WriteLine("x value equals to 10");
            }
            else if (x > 10)
            {
                Console.WriteLine("x value greater than 10");
            }
            else
            {
                Console.WriteLine("x value less than 10");
            }
            Console.WriteLine("Press Enter Key to Exit..");
          
        }
    }
}
