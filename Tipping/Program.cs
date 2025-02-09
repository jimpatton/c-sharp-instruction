namespace Tipping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Tipping\n");
            string choice = "y";
            while (choice == "y")
            {
                //Prompt for Cost of meal: decimal
                Print("Enter cost of meal: ");
                decimal cost = decimal.Parse(Console.ReadLine());
                //for decimal d = .15; d <= .25; d+=.05
                for (decimal d = .15m; d <= .25m; d += .05m)
                {
                    decimal tip = cost * d;
                    decimal total = cost + tip;
                    PrintLine(d.ToString("p0"));
                    PrintLine("Tip Amount: " + tip.ToString("c"));
                    PrintLine("Total Amount " + total.ToString("c"));
                }

                //calculate and dispalay tip amount: decimal and total amount: decimal for .15 .20 .25 tips

                Print("\nContinue? (y/n) ");
                choice = Console.ReadLine();
            }
                PrintLine("\nBye");
            }

            static void PrintLine(string msg)
            {
                Console.WriteLine(msg);
            }
            static void Print(string msg)
            {
                Console.Write(msg);
            }
        }
    }
