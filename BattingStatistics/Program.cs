using System.Net.Mail;
using System.Runtime;
using System.Transactions;

namespace BattingStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Batting Average Calculator");

            //While loop - Anoter Player continue with y or Y
            // enter number of times atBat (1-30)
            //array: 
            //enter number from  for each turn at bat --> 0 = out,1 = single, 2 = double, 3 = triple, 4 = home
            //batting average = instances > 0 / number of atBat
            //Sugging percent = totalnbr / number of atBat


            string choice = "y";
            while (choice == "y")
            {
                int atBat = 0;
                Console.Write("\nEnter number of times at bat: ", 1, 30);
                string atBatInput = Console.ReadLine() ?? "0";

                if (Int32.TryParse(atBatInput, out atBat) == false)
                {
                    Console.WriteLine("Error, must enter integer between 1 and 30");
                }
                else
                {
                    if (atBat < 1 || atBat > 30)
                    {
                        Console.WriteLine("Error, must enter integer between 1 and 30");
                    }
                    else
                    {

                        int[] stats = new int[atBat];
                        Console.WriteLine("\n0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
                        Console.WriteLine("");
                        int currentAtBat = 0;

                        for (int i = 0; i < atBat; i++)
                        {
                            //prompt user for result & add result to atbat[i]
                            Console.Write("Result of at-bat " + (i + 1) + ": ");
                            string currentUserInput = Console.ReadLine() ?? "-1";
                            if (Int32.TryParse(currentUserInput, out currentAtBat) == false)
                            {
                                Console.WriteLine("Error, must enter integer between 0 and 4");
                                i--;
                                continue;
                            }
                            if (currentAtBat < 0 || currentAtBat > 4) {
                                Console.WriteLine("Error, must enter integer between 0 and 4");
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
                        decimal battAvg = (decimal)hits / atBat;
                        decimal slugPct = (decimal)bases / atBat;
                        
                        Console.WriteLine("\nBatting average: {0:f3}" , battAvg);
                        Console.WriteLine("Slugging percent: {0:f3}" , slugPct);
                    }
                }


                Console.Write("\nAnother player? (y/n): ");
                choice = (Console.ReadLine()).ToLower();

            }


            Console.WriteLine("\nBye");
        }
    }
}
