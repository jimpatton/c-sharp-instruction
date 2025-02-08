using System.Xml.Serialization;

namespace ChangeCalc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PrintLine("Change calculator");
            string choice = "y";
            while (choice == "y") 
            {
                // promt number of cents
                Print("\n Enter number of cents (0 - 99): ");
                int cents = Int32.Parse(Console.ReadLine());
                //biz logic
                // quarters : int = cents/25
                int quarters = cents / 25;
                cents = cents % 25;
                int dimes = cents / 10;
                cents = cents % 10;
                int nickels = cents / 5;
                cents = cents % 5;
                int pennies = cents;

                PrintLine("\nQuarters:\t" + quarters);
                PrintLine("Dimes:\t\t" +  dimes);
                PrintLine("Nickels:\t" + nickels);
                PrintLine("Pennies:\t" +  pennies);

                 
                 //dimes: int = cents /10
                 //cents = cents % 10
                 //nickels: int = cents / 5
                 //pennies: int = cents % 5


                Print("\nContinue? (y/n): ");
                choice = Console.ReadLine();

            }


            PrintLine("\nBye");
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
