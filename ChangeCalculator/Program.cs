namespace ChangeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calculator");

            //while loop
                // get input - cents:int
                //biz logic
                // quarters : int = cents/25
                // cents = cents % 25
                //dimes: int = cents /10
                //cents = cents % 10
                //nickels: int = cents / 5
                //pennies: int = cents % 5


            string choice = "y";
            while (choice == "y" || choice=="Y")
            {
                Console.Write("\nEnter the number of cents (0-99): ");
                int cents = Convert.ToInt32(Console.ReadLine());
                int quarters = cents / 25;
                cents %= 25;
                int dimes = cents / 10;
                cents %= 10;
                int nickels = cents / 5;
                cents %= 5;
                int pennies = cents;

                Console.WriteLine("\nQuarters:    " + quarters);
                Console.WriteLine("Dimes:       " + dimes);
                Console.WriteLine("Nickels:     " + nickels);
                Console.WriteLine("Pennies:     " + pennies);


                Console.Write("\nContinue? (y or n): ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("\nBye");
        }
    }
}
