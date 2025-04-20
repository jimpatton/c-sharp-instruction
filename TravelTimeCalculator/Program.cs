using System.Numerics;

namespace TravelTimeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
            // enter miles and mph - return hours and minutes
            // biz logic hours and minutes (whole numbers)


            string choice = "y";
            while (choice == "y" || choice == "Y")
            {
                Console.Write("\nEnter miles:                ");
                double miles = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Enter miles per hour:       ");
                double milesPerHour = Convert.ToDouble(Console.ReadLine());

                //hours:int = (int) total itme
                //minutes: int = (int)(miles % milesPerHour) * 60

                double totalTime = miles / milesPerHour;
                int hours = (int)totalTime;
                double remainder = totalTime - hours;
                int minutes = (int)((remainder) * 60);


                
                Console.WriteLine("\nEstimated Travel Time");
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
