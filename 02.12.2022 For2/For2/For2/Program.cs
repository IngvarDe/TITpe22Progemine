using System;

namespace For2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta tärnide arv ->");
            int number = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Prindi {0} tärn(e)i", number);

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
