using System;

namespace IfElseWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 1;
            int b = 2;

            if (a == 1)
            {
                Console.WriteLine("a on 1");
            }
            else if (a == b)
            {
                Console.WriteLine("a on võrdne b-ga");
            }
            else if (a != b)
            {
                Console.WriteLine("a ei ole v]rdne b-ga");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
