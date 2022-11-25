using System;

namespace HindeKontroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta hinde number: ");
            // muudab string andmetyybi int andmetüübiks
            int num = Convert.ToInt32(Console.ReadLine());

            //
            if (num < 0 || num > 100)
            {
                Console.WriteLine("Vale number");
            }
            //
            else if (num >= 0 && num < 50)
            {
                Console.WriteLine("Failer oled ja luuser");
            }
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine("D hinde saad");
            }
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C hinde saad");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B hinde saad");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A hinde saad");
            }
            else if (num >= 90 && num < 100)
            {
                Console.WriteLine("C hinde saad");
            }
            else
            {
                Console.WriteLine("Tubli, istu, kaks");
            }
        }
    }
}
