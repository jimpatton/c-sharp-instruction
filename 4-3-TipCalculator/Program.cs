namespace _4_3_TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tip Calculator");
            string choice = "y";
            while (choice == "y".ToLower()) {
                Console.Write("\nCost of Meal: ");
                decimal meal = decimal.Parse(Console.ReadLine());
                for (decimal d = .15m; d <= .25m; d += .05m)
                {
                    decimal tip = meal * d;
                    decimal total = meal + tip;
                    Console.WriteLine($"{d:p0}");
                    Console.WriteLine($"Tip amount: {tip:c}");
                    Console.WriteLine($"Total amount: {total:c}");
                }
                Console.Write("\nContinue? (y/n):");
                choice = Console.ReadLine();
            }
        }
    }
}
