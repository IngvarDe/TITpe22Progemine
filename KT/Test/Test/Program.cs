using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            float distance;
            int num = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            if (num >= 0 && num > 40)
            {
                Console.WriteLine("Teie maja on 0 ja 40 ruutmeetri vahel1");
            }
            else if (num >= 41 && num < 90)
            {
                Console.WriteLine("Teie maja on 41 ja 90 ruutmeetri vahel2");
            }
            else if (num >= 91 && num < 130)
            {
                Console.WriteLine("Teie maja on 91 ja 130 ruutmeetri vahel3");
            }
            else if (num >= 131 && num < 176)
            {
                Console.WriteLine("Teie maja on 131 ja 176 ruutmeetri vahel4");
            }

        }
    }
}
