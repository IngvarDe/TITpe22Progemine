namespace Switch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int item = 5;

            switch (item)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 4:
                    Console.WriteLine("case 4");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                default:
                    Console.WriteLine("No match found");
                    break;
            }
        }
    }
}