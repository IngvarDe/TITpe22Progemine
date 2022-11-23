using System;

namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nimi:");
            string name = Console.ReadLine();

            Console.WriteLine("Tere, " + name + " !");

            Console.WriteLine("Nimi on sisestatud ja nüüd hakkab kontroll");

            if (name != "")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.White;
                //seda teksti kuvatakse rohelisena
                Console.WriteLine("Tere, " + name + " !");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                //seda teksti kuvatakse punasena
                Console.WriteLine("Nime ei sisestatud.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
