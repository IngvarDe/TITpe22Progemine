using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kasutaja kontroll");
            Console.WriteLine("Denis Leoke ");
            Console.WriteLine("Siseta nimi: ");
            string name = Console.ReadLine();

            Console.WriteLine("Siseta pikkus: ");
            //küsib suurust mida pead sisestama
            string distance = Console.ReadLine();
            int distanceParse = Int16.Parse(distance);

            Console.WriteLine("tere " + name + ", oled " + distance + "aastane");

            Console.ReadKey();
            if (distanceParse < 40)
            {
                Console.WriteLine("oled veel k]hus ");
            }
            //else if (distanceParse >= 0 && distanceParse <= 40)
            //{
            //    Console.WriteLine("Loodan ma teen kõik õigesti");
            //    distanceParse = 0;
            //}
            else if (distanceParse >= 41 && distanceParse <= 90)
            {
                Console.WriteLine("täna on kõik hästi");
            }
            else if (distanceParse >= 91 && distanceParse <= 130)
            {
                Console.WriteLine("Loodan ,et ma saan hästi hakkama");
            }
            else if (distanceParse >= 131 && distanceParse <= 200)
            {
                Console.WriteLine("kõik läheb hästi");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}