using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start:

            Console.Title = "Kuju valimine ja arvutamine"; //aknale nime panemine
            Console.WriteLine("Vali, mis kujundit soovid arvutada ja kujutada ning kirjuta konsoolile");

            Console.WriteLine("\n1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolnurk");

            string shape = Console.ReadLine();

            switch (shape)
            {
                case "ruut":
                    Quadrilateral();
                    break;

                case "teemant":
                    Diamond();
                    break;

                case "ristkülik":
                    Rectangle();
                    break;

                case "kolmnurk":
                    Triangle();
                    break;

                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud.");
                    break;
            }
            Console.ReadKey();
            //goto Start;



        }

        private static void Quadrilateral()
        {
            Console.WriteLine("\nSisesta ruudu ühe külje mõõtühik sentimeetrites: ");
            double quadrilateral = double.Parse(Console.ReadLine());


            for (int row = 1; row <= quadrilateral; row++)
            {
                for (int column = 1; column <= quadrilateral; column++)
                {
                    string mark;
                    if (row == column || row + column <= row + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        private static void Diamond()
        {
            double i, j, diamond, count;

            Console.WriteLine("\nSisesta teemanti raadiuse mõõtühik sentimeetrites");
            diamond = double.Parse(Console.ReadLine());



            for (i = 0; i <= diamond; i++)
            {
                for (j = 1; j <= diamond - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (i = diamond - 1; i >= 1; i--)
            {
                for (j = 1; j <= diamond - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        private static void Rectangle()
        {
            Console.WriteLine("\nSisesta ristk[liku kahe k[lje m[[t]hik sentimeetrites");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());


            for (int row = 1; row <= a; row++)
            {
                for (int column = 1; column <= b; column++)
                {
                    string mark;
                    if (row == column || row + column <= +1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        private static void Triangle()
        {
            Console.WriteLine("\nSisesta v]rdk[lgse kolmnurga k[lje pikkus sentimeetrites");

            double length = double.Parse(Console.ReadLine());

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length * 2 - 1; column++)
                {
                    string mark = "";

                    if (row == length)
                    {
                        mark = "*";
                    }
                    else if(row + column >= length + 1 && column - length + 1 <= row)
                    {
                        mark= "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}
