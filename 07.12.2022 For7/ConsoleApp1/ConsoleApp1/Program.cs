using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 0;

            for (;;)
            {
                if (i < 10)
                {
                    Console.WriteLine("i väärtus on: {0}", i);
                    i++;
                }
                else 
                {
                    break;
                }
                // teha sellest vooskeem draw.io keskkonnas
            }
        }
    }
}
