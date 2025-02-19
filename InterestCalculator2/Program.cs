using ConsoleLibrary;

namespace InterestCalculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Interest Calculator2!\n");
            //While loop: Continue
            string choice = "y";
            while (choice == "y")
            {
                //prompt for loan amount
                double loanAmount = MyConsole.PromptDouble("\nEnter loan amount: ");
                //prompt for interest rate
                double interestRate = MyConsole.PromptDouble("Enter interest rate: ");
                //display loan amount and interest rate: doubles
                MyConsole.PrintLine($"\nLoan amount: \t{loanAmount.ToString("c")}");
                // interest = loan amount * interest rate
                MyConsole.PrintLine($"Interest rate: \t{interestRate.ToString("p3")}");
                MyConsole.PrintLine($"Interest: \t{(loanAmount * interestRate).ToString("c")}");

                choice = MyConsole.PromptString("\nContinue? (y/n) ").ToLower();

            }
            MyConsole.PrintLine("\nBye");
        }
    }
}
