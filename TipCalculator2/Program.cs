using ConsoleLibrary;

namespace TipCalculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Tip Calculator 2!\n");
            //While loop: Continue
            string choice = "y";
            while (choice == "y")
            {
                //prompt for cost of meal
                decimal meal = MyConsole.PromptDecimal("\nCost of meal: ");
                //calculate tip at 15%, 20% ,25%: doubles
                for (decimal d = .15m; d <= .25m; d += .05m) {
                    decimal tip = (meal * d);
                    decimal total = meal + tip;
                //display tip%, tip amount, total amount
                    MyConsole.PrintLine(d.ToString("p"));
                    MyConsole.PrintLine($"Tip amount: {tip.ToString("c")}");
                    MyConsole.PrintLine($"Total amount: {total.ToString("c")}");
                }






                choice = MyConsole.PromptString("\nContinue? (y/n)").ToLower();
            }

            MyConsole.PrintLine("\nBye");
        }
    }
}
