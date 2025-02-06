using System.Numerics;

namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tip Calculator");

            string choice = "y";
            while (choice == "y") {
                Console.Write("Cost of meal: ");
                // prompt for cost of meal: decimal
                // skipping validation
                decimal costOfMeal = Decimal.Parse(Console.ReadLine()); 
                // biz logic:
                    //calulate and display tipamt: decimal & totalAmt: decimal   for .15 .20 .25
                    // for decimal d = .15m; d<+ .25m; d += .05
                for (decimal d =.15m; d<= .25m; d += .05m)
                {
                    decimal tipAmt = costOfMeal * d;
                    decimal totalAmt = costOfMeal + tipAmt;
                    Console.WriteLine(d.ToString("p0"));
                    Console.WriteLine("Tip Amount " + tipAmt.ToString("c"));
                    Console.WriteLine("Total Amount " +totalAmt.ToString("c"));

                    Console.WriteLine();
                }




                Console.WriteLine("Continue? (y/n)");
                Console.ReadLine().ToLower();
            }






            Console.WriteLine("Bye");
        }
    }
}
