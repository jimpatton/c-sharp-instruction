namespace BattingAvgDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Batting AVG Demo");
            string choice = "y";
            while (choice == "y")
            {

                //while choice =="y"
                //promt user -->nbrAtBat: int
                int nbrAtBat = PromptInt("Enter number of times at bat: ", 1, 30);
                int[] atBat = new int[nbrAtBat];
                int countAtBat = 0;
                int sumAtBat = 0;
                for (int i = 0; i < nbrAtBat; i++)
                {
                    int result = PromptInt("Result for at-bat " + (i + 1) + ": ", 0, 4);
                    atBat[i] = result;
                    if (result > 0)
                    {
                        countAtBat++;
                    }
                    sumAtBat += result;
                }

                double battAvg = (double) countAtBat / nbrAtBat;
                double slugPct = (double) sumAtBat / nbrAtBat;
                Print("\nBatting Average: " + battAvg.ToString("f3"));
                Print("Slugging Percentage: " + slugPct.ToString("f3"));
                //display results --> formatting 3 decimal places
                //prompt Another player?
                Console.Write("Another player? (y/n)");
                choice = Console.ReadLine().ToLower();
            }


            static int PromptInt(string prompt, int min, int max)
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
                            Print("Error, must be within range");
                        }
                    }
                    else
                    {
                        Print("Error, entry must be an integer");

                    }
                }
                return result;
            }





            Print("\nBye");
        }
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
