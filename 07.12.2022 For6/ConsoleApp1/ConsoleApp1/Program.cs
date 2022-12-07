using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ushort i = 0;
            // hakkab itereerima nii kaua kuni ushort 
            // andmetüübist saadakse kätte maksimaalne arv e 63 tuhat
            // peale seda alustab uuesti
            // lõputu itereerimine tuleneb tingimuste puudumisest
            for (;;)
            {
                Console.Write("i väärtuas on: {0}", i);
                i++;
            }
        }
    }
}
