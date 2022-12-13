using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n1, n;
            double dec = 0, i = 0, d;

            Console.WriteLine("Sisesta binaararv");

            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;

            while(n != 0)
            {
                d = n % 10;
                dec = dec + d * Math.Pow(2, i);
                n = n / 10;
                i++;
            }

            Console.WriteLine("\n Binaarnumber: {0} \n võrdub kümnendarvuna: {1}\n\n", n1, dec);
        }
    }
}
