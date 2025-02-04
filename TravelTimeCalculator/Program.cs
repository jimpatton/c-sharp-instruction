namespace TravelTimeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
            // enter miles and mph - return hours and minutes

            string choice = "y";
            while (choice == "y")
            {
                Console.Write("\nEnter miles:                ");
                double miles = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Enter miles per hour:       ");
                double milesPerHour = Convert.ToDouble(Console.ReadLine());
                double hours = miles / milesPerHour;//wrong
                double minutes = (miles % milesPerHour);
                Console.WriteLine("Estimated Travel Time");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Hours:   " + hours);
                Console.WriteLine("Minutes: "+ minutes);

                Console.Write("\nContinue? (y or n): ");
                choice = Console.ReadLine();
            }



                Console.WriteLine("Bye");
        }
    }
}
