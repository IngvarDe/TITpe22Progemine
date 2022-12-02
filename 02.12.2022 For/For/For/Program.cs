using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //(int i-le antakse v''rtus; i muutujat kontrollitakse, kas on v'iksem, kui kolm;
            // i++ annab v''rtuse juurde [he v]rra)
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("For loop");
            }
        }
    }
}
