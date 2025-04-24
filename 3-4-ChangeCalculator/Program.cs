namespace _3_4_ChangeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calculator");
            string choice = "y";
            while (choice == "y".ToLower())
            {
                Console.Write("\nEnter number of cents (0-99): ");
                int cents = int.Parse(Console.ReadLine());
                int quarters = cents / 25;
                cents = cents % 25;
                int dimes = cents / 10;
                cents = cents % 10;
                int nickels = cents / 5;
                cents = cents % 5;
                int pennies = cents;
                Console.WriteLine("\nQuarters: " + quarters);
                Console.WriteLine("Dimes:\t  " + dimes);
                Console.WriteLine("Nickels:  " + nickels);
                Console.WriteLine("Pennies:  " + pennies);
                Console.Write("\nContinue? (y/n) ");
                choice = Console.ReadLine();







            }

        }
    }
}
