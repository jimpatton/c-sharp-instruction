using System.Xml.Serialization;
using ConsoleLibrary;

namespace _7_3GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Guess the Number Game!");
            MyConsole.PrintLine("+++++++++++++++++++++++++++++++++++++\n");
            //While loop
            string choice = "y";
            while (choice == "y")
            {
                //prompt for numerical grade: 1 to 100








                choice = MyConsole.PromptString("\nContinue? (y/n): ");
            }











        }
        public static int ValidateNumber(string prompt, int min, int max)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= min && result <= max)
                    {

                        isValid = true;
                    }
                    else
                    {
                        MyConsole.PrintLine("Error must be within range");
                    }

                }
                else
                {
                    MyConsole.PrintLine("Error must be an integer");
                }
            }
            return result;
        }

    }
}
