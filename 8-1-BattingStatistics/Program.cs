using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace _8_1_BattingStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Batting Average Calculator");
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                int atBat = 0;
                Console.Write("\nEnter number of times at bat: ");
                string atBatInput = Console.ReadLine() ?? "0";
                if (!int.TryParse(atBatInput, out atBat))
                {
                    Console.WriteLine("Error! Please enter a number between 1 and 30");
                }
                else if (atBat < 1 || atBat > 30)
                    {
                        Console.WriteLine("Error! Please enter a number between 1 and 30");
                    }
                    else 
                    {
                        int[] stats = new int[atBat];
                        Console.WriteLine("\n0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run ");
                        int currentAtBat = 0;

                        for (int i = 0; i < atBat; i++)
                        {
                            Console.Write("\nResult of at bat " + (i + 1) + ": ", 0, 4);
                            string numAtBat = Console.ReadLine() ?? "0";
                            if (Int32.TryParse(numAtBat, out currentAtBat) == false)
                            {
                                Console.WriteLine("Error! Please enter an integer between 0 and 4");
                                i--;
                                continue;
                            }
                            else if (currentAtBat<0 || currentAtBat > 4)
                            {
                                Console.WriteLine("Error! Please enter an integer between 0 and 4");
                                i--;
                                continue;
                            }
                            stats[i] = currentAtBat;                        
                        }
                        int hits = 0;
                        int bases = 0;
                        for (int i = 0; i < atBat; i++) 
                        { 
                            int curBases = stats[i];
                            bases += curBases;
                            if (curBases > 0) 
                            {
                                hits++;
                            }                           
                        }
                        decimal battAve = (decimal)hits/atBat;
                        decimal slugPct = (decimal)bases/atBat;

                        Console.WriteLine("\nBatting average: {0:f3}", battAve);
                        Console.WriteLine("Slugging percent: {0:f3}", slugPct);

                    }
                
                Console.Write("\nAnother player? ");
                choice = Console.ReadLine().ToLower();
            }
        }
    }
}
