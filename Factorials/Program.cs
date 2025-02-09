using System.Runtime.CompilerServices;

namespace Factorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Factorials");
            string choice = "y";
            while (choice == "y")
            {
                //enter an integer: long
                long nbr = GetLong("\nEnter an intgeger that's greater then 0 and less then 10: ",1,10);
                long factorial = 1;
                for (int i = 1; i<= nbr; i++)
                {
                    factorial *= i;
                }
                    PrintLine("The factorial of " + nbr + " is " + factorial);
                





                Print("\nContinue (y/n)");
                choice = Console.ReadLine().ToLower();
            }

            PrintLine("\nBye");

        }
        private static long GetLong(string prompt, long min, long max)
        {
            long result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                if (!long.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Error - invalid number. Try again.");
                    continue;
                }
                if (result < min || result > max)
                {
                    Console.WriteLine("Error - input must be within range " + min + " - " + max + " Try again");
                }
                else
                {
                    isValid = true;
                }
            }
            return result;
        }

        static void Print(string msg)
        {
            Console.Write(msg);
        }
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
