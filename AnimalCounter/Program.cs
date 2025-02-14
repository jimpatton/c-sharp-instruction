using ConsoleLibrary;

namespace AnimalCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Animal Counter\n");
            Alligator a = new Alligator();
            MyConsole.PrintLine("Counting alligators....\n");
            count(a, 3);

            MyConsole.PrintLine("Counting sheep....\n");
            Sheep s = new Sheep();
            s.Name = "Blackie";
            count(s, 2);


            MyConsole.PrintLine("\nBye");
        }
        public static void count(Countable c, int maxcount)
        {
            for (int i = 0; i < maxcount; i++)
            {
                c.IncrementCount();
                MyConsole.PrintLine(c.GetCountString());
            }
        }
    }
}
