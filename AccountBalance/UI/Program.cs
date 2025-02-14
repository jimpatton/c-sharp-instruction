using AccountBalance.Model;
using ConsoleLibrary;

namespace AccountBalance.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Account application\n");

            MyConsole.PrintLine("Starting Balances: ");
            //initialize checkingAccount, savingsAccount
            CheckingAccount ca = new CheckingAccount(1.0m);
            ca.Balance = 1000.0m;
            SavingsAccount sa = new SavingsAccount(.01m);
            sa.Balance = 1000.0m;

            //dispaly starting balances
            DisplayBalances(ca, sa);
            MyConsole.PrintLine("\nEnter transactions for the month\n");

            //while choice == "y"
            string choice = "y";
            while (choice == "y")
            {
                Account a;
                // prompt action: string (w/d)
                string action = MyConsole.PromptReqString("Withdraw or Deposit? ", "w", "d");
                // prompt account: string (c/s)
                string account = MyConsole.PromptReqString("Checking or Savings? ", "c", "s");
                // prompt amount: decimal
                decimal amount = MyConsole.PromptDecimal("Amount? ");
                //processTransaction
                if (account == "c")
                {
                    a = ca;
                }
                else
                {
                    a = sa;
                }
                if (action == "w")
                {
                    a.Withdraw(amount);
                }
                else
                {
                    a.Deposit(amount);
                }

                // prompt continue
                choice = MyConsole.PromptReqString("\nContinue: (y/n): ", "y", "n");
            }


            // processEndOfMonth  - interest and fees
            sa.ApplyInterestPaymentToBalance();
            ca.SubtractFeeFromBalance();
            MyConsole.PrintLine("\nMonthly Payments and Fees");
            MyConsole.PrintLine("Checking Fee: " + ca.MonthlyFee.ToString("c"));
            MyConsole.PrintLine("Savings Interest Payment: " + sa.MonthlyInterestPayment.ToString("c"));

            MyConsole.PrintLine("\nFinal Balances: ");
            DisplayBalances(ca, sa);
            // sa = calc interest payment and add to balance
            
            // ca = subtract fee from balance
            //Display Final Balances






            MyConsole.PrintLine("\nBye");
        }
        static void DisplayBalances(CheckingAccount ca, SavingsAccount sa)
        {
            MyConsole.PrintLine("Checking: " + ca.Balance.ToString("c"));
            MyConsole.PrintLine("Savings: " + sa.Balance.ToString("c"));
        }
    }
}
