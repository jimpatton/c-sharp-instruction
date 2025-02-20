using ConsoleLibrary;

namespace DiceRoller2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Dice Roller 2\n");
            string choice = "y";
            while (choice == "y")
            {

                Random rand = new Random();
                int die1 = RollDie(rand);
                int die2 = RollDie(rand);
                int total = die1 + die2;
                MyConsole.PrintLine($"\nDie 1:\t {die1}");
                MyConsole.PrintLine($"Die 2:\t {die2}");
                MyConsole.PrintLine($"Total:\t {total}");
                if (total == 2)
                {
                    MyConsole.PrintLine("Snake eyes!");
                }
                else if (total == 7)
                {
                    MyConsole.PrintLine("Craps!");
                }
                else if (total == 12)
                {
                    MyConsole.PrintLine("Box cars!");
                }
             




                choice = MyConsole.PromptString("\nContinue? (y/n)").ToLower();
            }

            MyConsole.PrintLine("\nBye");
        }

        public static int RollDie(Random rand)
        {
            return rand.Next(1, 7);
        }
    }
}
