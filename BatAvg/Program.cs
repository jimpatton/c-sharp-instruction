namespace BatAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("batting avg");
            PrintLine("Batting Avg and Slugger Pct\n");
            string choice = "y";
            while (choice == "y")
            {
                //prompt number of times atBat from 1-30
                int nbrAtBat = PromptInt("Enter number of times at bat: ", 1, 30);
                int[] atBat = new int[nbrAtBat];
                int countAtBat = 0;
                int sumAtBat = 0;
                // give options 0=out, 1=single, 2=double, 3=triple, 4=home run
                PrintLine("\n0 = Out, 1 = Single, 2 = Double, 3 == Triple, 4 = Home Run");
                for (int i = 0; i < nbrAtBat; i++)
                {
                    //prompt for each at bat 0-4 (as above)
                    int result = PromptInt("Result for at-bat " + (i + 1) + ": ", 0, 4);
                    atBat[i] = result;
                    if (result > 0)
                    {
                        countAtBat++;
                    }
                    sumAtBat += result;
                }
                //batting avg = count >0 / atBat
                //slugging pct = totalnbr / atBat
                double batAvg = countAtBat / nbrAtBat;
                double slugPct = sumAtBat / nbrAtBat;
                PrintLine("\nBatting average: " + batAvg.ToString("f3"));
                PrintLine("Slugging percent: " + slugPct.ToString("f3"));




                Print("\nAnother Player? (y/n)");
                choice = Console.ReadLine().ToLower();
            }
            PrintLine("\nBye");

        }

        static int PromptInt(string prompt, int min, int max)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Print(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= min && result <= max)
                    {
                        isValid = true;
                    }
                    else
                    {
                        PrintLine("Error - must be within range");
                    }
                }
                else
                {
                    PrintLine("Error - must be an integer");
                }
            }
            return result;
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
