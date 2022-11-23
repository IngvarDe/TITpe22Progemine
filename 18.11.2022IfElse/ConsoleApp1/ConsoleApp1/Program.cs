using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else-ga consooli aplikatsioon. " +
                "Kasutada.Net Core 3.1 raamistikku. Rakendus küsib, " +
                "et kui kaugel sa elad. Sina pead saama " +
                "sisestada kaugust km-s. Esimene if püüab koodi kinni " +
                "0 kuni 10 km, teine 11 km kuni 30 km, kolmas 31 " +
                "km kuni 50 km, neljas 51 km kuni 90 km ja viies 91 km " +
                "ja üle selle.Kui koodis vastab sinu sisestatud" +
                " kaugus if-i tingimusele, siis vastuse saad ise välja mõelda.");

            Console.WriteLine("Siseta kaugus km-s");
            string distance = Console.ReadLine();
            int distanceParsed = int.Parse(distance);

            if (distanceParsed <= 10)
            {
                Console.WriteLine("Elad 1-10 km kaugusel");
            }
            else if (distanceParsed >= 11 && distanceParsed <= 30)
            {
                Console.WriteLine("Elad 11-31 km kaugusel");
            }
            else if (distanceParsed >= 31 && distanceParsed <= 50)
            {
                Console.WriteLine("Elad 31-50 km kaugusel");
            }
            else if (distanceParsed >= 51 && distanceParsed <= 90)
            {
                Console.WriteLine("Elad 51-90 km kaugusel");
            }
            else
            {
                Console.WriteLine("Elad kaugemal kui 90 km");
            }
        }
    }
}