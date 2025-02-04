namespace InterestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interest Calculator");

            string choice = "y";
            while (choice == "y")
            {
                Console.Write("\nEnter loan Amount:     ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter interest rate: ");
                double interest = Convert.ToDouble(Console.ReadLine());
                double interestAmount = amount * interest;
                Console.WriteLine("\nLoan amount:     " + amount.ToString("c"));
                Console.WriteLine("Interest rate:       " + interest.ToString("p3"));
                Console.WriteLine("Interest:        "+interestAmount.ToString("c"));

                Console.Write("\nContinue? (y or n): ");
                choice = Console.ReadLine();
            }


                Console.WriteLine("\nBye");
         
        }

    }
}
