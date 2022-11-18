using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // on muutuja y ja see on t'isarv
            float y;
            // F numbri l]pus n'itab, et tegemist on float andmet[[biga
            // kui F t'hte ei pane, siis tuleb veateade
            y = 20.5F;

            // Double puhul ei pea numbri l]ppu panema F-t'hte
            double x;
            x = 20.5;

            // inti puhul saab olla 32 bitine maksimaalne v''rtus
            int z;
            z = 222222222;

            //maksimaalne v''rtus saab olla 64 bitine
            long a;
            a = 2222222;

            //16 bitine andmet[[p
            short s;
            s = 1231;

            ushort u;
            u = 123;

            //t]ene v]i v''r
            bool b;
            b = false;

            //komakohaga arv ja M tuleb numbri l]ppu panna
            decimal c;
            c = 10.23M;

            //chari puhul tuleb numbri ette panna (char)
            char ch;
            ch = (char)22;

            // k]ik tahem'rgid, aga peab olema jutum'rkide sees
            string s1;
            s1 = "123123dfg346grh_(&$$#";
        }
    }
}
