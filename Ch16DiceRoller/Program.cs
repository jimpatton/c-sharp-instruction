using ConsoleLibrary;

namespace Ch16DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Dice Roller");
            //initialize choice w/ prompt: roll the dice (y/n)
            string choice = MyConsole.PromptString("Roll the dice? (y/n) ").ToLower();
            while (choice == "y")
            {
                //roll die1, die2
                Dice dice = new Dice();
                dice.Roll();
                MyConsole.PrintLine(dice.GetRollResults());
                choice = MyConsole.PromptString("Roll again? (y/n)");
            }
            //display total and msg
            //prompt continue?



            MyConsole.PrintLine("\nBye");
        }
    }
}
