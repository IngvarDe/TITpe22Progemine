using System;

namespace CoinsAroundEarth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mündid ümber maakera");
            double oneEuroCoinDiameter = 46.5; //mm
            double earthRadius = 6371000000;
            double aroundEarth = 2 * Math.PI * earthRadius;

            Console.WriteLine(aroundEarth / oneEuroCoinDiameter);
        }
    }
}
