namespace InterestCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Interest calculator");
            string choice = "y";
            while (choice == "y") 
            {
                //prompt for loan amount (amt)
                Print("\nEnter loan amount:\t");
                double amt = Double.Parse(Console.ReadLine());
                //prompt for interest rate (rate)
                Print("Enter interest rate:\t");
                double rate = Double.Parse(Console.ReadLine());
                double interest = (amt * rate);
                //present amt in currency
                PrintLine("\nLoan amount:\t\t" + amt.ToString("c"));
                //present rate in percentage with 3 decimal points
                PrintLine("Interest rate:\t\t" +  rate.ToString("p3"));
                //return interest in currency  (amt * rate)
                PrintLine("Interest:\t\t" + interest.ToString("c"));



                Print("\nContinue? (y/n) ");
                choice = Console.ReadLine().ToLower();
            
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
