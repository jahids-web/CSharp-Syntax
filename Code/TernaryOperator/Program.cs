using System;

namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string Ages(int age) => age > 20 ? "You Can Join" : "You Can't Join";
            //Console.Write(Ages(79));

            int Result(string exm) => exm == "First" ? 100 : 0;
            Console.WriteLine(Result("First"));
        }
    }
}
