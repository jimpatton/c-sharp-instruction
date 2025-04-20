using System.Diagnostics.Metrics;
using ConsoleLibrary;

namespace BattAvg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Batting Averages 2\n");
            string choice = "y";
            while (choice == "y")
            {
                //prompt for atBats
                int timesAtBat = MyConsole.PromptInt("\nEnter number times at bat: ");
                //store timesAtBat in an array
                double[] atBat = new double[timesAtBat];
                double countAtBat = 0;
                double sumAtBat = 0;
                MyConsole.PrintLine("\n0 = Out, 1 = Single, 2 = Double, 3 = Triple, 4 = Home Run\n");
                //for int i =0; i<arraylength i++
                for (int i = 0; i < timesAtBat; i++)
                {
                    //prompt resultsAtBat for each timesAtBat
                    int resultsAtBat = MyConsole.PromptInt("Results at bat" + (i + 1) + ": ", 0, 4);
                    //battavg = resultsAtBat/timesAtBat
                    atBat[i] = resultsAtBat;
                                      
                    if (resultsAtBat > 0) 
                    {
                        countAtBat++;
                    }
                    
                }
                sumAtBat = atBat.Sum();
                double batAvg = countAtBat / timesAtBat; 
                double slugAvg = sumAtBat / timesAtBat;
                MyConsole.PrintLine("\nBatting average: " + batAvg.ToString("f3"));
                MyConsole.PrintLine("Slugging percent: " + slugAvg.ToString("f3"));
            
                         
            choice = MyConsole.PromptString("\nAnother player? (y/n): ").ToLower();
            }








            MyConsole.PrintLine("\nBye");
        }
    }
}
