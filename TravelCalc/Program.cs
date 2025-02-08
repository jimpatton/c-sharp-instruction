using System.Xml.Serialization;

namespace TravelCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Travel Time Calculator");
            string choice = "y";
            while (choice == "y") 
            {
                //prompt for mile
                Print("\nEnter miles: ");
                double miles = Double.Parse(Console.ReadLine());
                //prompt for mPh
                Print("Enter miles per hour: ");
                double mPh = Double.Parse(Console.ReadLine());
                
                
                double time = miles / mPh;
                int hours = (int)time;
                double remainder = time - hours;
                int minutes = (int)((remainder) * 60);
                
                                
                
                PrintLine("\nEstimated travel time");
                PrintLine("----------------------");
                PrintLine("Hours: " + hours);
                PrintLine("Minutes: " + minutes);
    





                Print("\nContinue? (y/n) ");
                choice = Console.ReadLine();
            }


            PrintLine("\nBye");

        }

        static void PrintLine(string msg)
        {
            Console.WriteLine (msg);
        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }
    }
}
