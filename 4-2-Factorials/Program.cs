using System.Xml.Serialization;

namespace _4_2_Factorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator");
            string choice = "y";
            while (choice == "y".ToLower())
            {
                Console.Write("\nEnter a integer that's greater than 0 and less than 10: ");
                int nbr = int.Parse(Console.ReadLine());
                int factorial = 1;
                for (int i = 1; i <= nbr; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"The factorial of {nbr} is {factorial}");
                Console.Write("\nContinue? (y/n) ");
                choice = Console.ReadLine();
            }

        }
    }
}
