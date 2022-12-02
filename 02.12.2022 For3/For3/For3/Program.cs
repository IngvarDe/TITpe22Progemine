using System;

namespace For3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Ülesanne 3
            Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
            kill-koll kill-koll killadi-koll kill-koll kill-koll killadi-koll kill-koll kill-koll kill-koll
            kill-koll*/
            string arv = Console.ReadLine();
            int arvS = int.Parse(arv);

            for (int i = 1; i <= arvS; i++)
            {
                Console.WriteLine("See on rida nr {0}", i);
                string b = "kill-koll";
                string a = "killadi-koll";

                for (int g = 1; g < 2; g++)
                {
                    Console.WriteLine(b);
                }
                for (int k = 0; k < 1; k++)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
