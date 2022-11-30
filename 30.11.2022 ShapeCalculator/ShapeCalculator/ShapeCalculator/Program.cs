using System;

namespace ShapeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ruudu sees on ring. Ringi raadius on 3.
            //Leia ja väljasta ekraanile ruudu/ringi pindala ja ümbermõõt

            Console.WriteLine("Ruut ja ring");

            int roundRadius = 3;
            int squareSide = 6;

            Console.WriteLine("Ruudu pindala " + squareSide * squareSide);
            Console.WriteLine("Ruudu ümbermõõt " + 4 * squareSide);

            Console.WriteLine("Ringi pindala " + Math.PI * (roundRadius * roundRadius));
            Console.WriteLine("Ringi ümbermõõt " + 2 * Math.PI * roundRadius);
        }
    }
}
