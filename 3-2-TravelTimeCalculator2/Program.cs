namespace _3_2_TravelTimeCalculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("Enter miles: ");
                int miles = int.Parse(Console.ReadLine());
                Console.Write("Enter miles per hour: ");
                int mph = int.Parse(Console.ReadLine());
                float time = (float)miles / mph;
                int hours = (int)time;
                float minutes = (time - hours) * 60;
                int roundMinutes = (int)Math.Round(minutes);
                Console.WriteLine("\nEstimated Travel Time");
                Console.WriteLine("Hours: " + hours);
                Console.WriteLine("Minutes: " + roundMinutes);
                Console.Write("\nContinue? (y/n) ");
                choice = Console.ReadLine();
            }
        }

    }
}
