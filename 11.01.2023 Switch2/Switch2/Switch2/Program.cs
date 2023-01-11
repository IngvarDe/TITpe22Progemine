namespace Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string topic;
            string category;

            topic = "Jump statements";

            switch (topic)
            {
                case "Intro to C#":
                case "Variables":
                case "Data Types":

                    category = "Basic";
                    break;

                case "Loops":
                case "If statment":
                case "Jump statements":

                    category = "Control Flow";
                    break;

                case "Class & Object":
                case "Inheritance":
                case "Constructors":

                    category = "OOPS Concept";
                    break;

                default:
                    category = "UNKNOWN";
                    break;
            }
            Console.Write("Category is " + category);
        }
    }
}