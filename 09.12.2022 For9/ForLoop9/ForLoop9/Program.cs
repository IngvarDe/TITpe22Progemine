using System;

namespace ForLoop9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;

            Console.WriteLine("Display the sum on odd number:\n");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta number");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("The odd numbers are:");

            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2*i-1);
                sum += 2 * i - 1;
            }
            Console.Write("The sum on odd natural number upto {0} terms: {1} \n", n, sum);
        }
    }
}
