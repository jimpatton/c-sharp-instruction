using ConsoleLibrary;

namespace MakeChocolate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Make Chocolate!\n");

            int smallBarsUsed = MakeChocolate(4, 1, 9);
            MyConsole.PrintLine("Small bars used = " + smallBarsUsed);

            smallBarsUsed = MakeChocolate(4, 1, 10);
            MyConsole.PrintLine("Small bars used = " + smallBarsUsed);

            smallBarsUsed = MakeChocolate(4, 1, 7);
            MyConsole.PrintLine("Small bars used = " + smallBarsUsed);

            
            MyConsole.PrintLine("\nBye");
        }
        public static int MakeChocolate(int small, int big, int goal)
        {
            int smallBars = goal - (big * 5);
            if (smallBars <= small) { }
            //MyConsole.PrintLine("The number of small bars needed for goal is: " + smallBars);
            else
            {
                smallBars = -1;
            }
            return smallBars;

        }


    }
}
