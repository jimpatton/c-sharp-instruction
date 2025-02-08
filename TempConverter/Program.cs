using System.Text;
using System.Xml.Serialization;

namespace TempConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Temp Converter");
            //while loop for Continue
            string choice = "y";
            while (choice == "y" || choice == "Y") 
            {
                //prompt for temp in fahrenheit
                //decimal tempFahr = Decimal.Parse(
                Print("\nEnter degrees in Fahrenheit: ");
                double tempfahr = double.Parse(Console.ReadLine());
                //biz logic
                // celcius = (tempFahr - 32) * 5/9
                double celcius = 0;
                celcius = (tempfahr - 32) * 5 / 9;
                //return temp in celcius
                celcius = Math.Round(celcius,2);
                PrintLine("Degrees in celcius: " + celcius);


                Print("\nContinue? (y/n) ");
                choice = Console.ReadLine();
            
            }











            PrintLine("\nBye");
        }
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Print(string msg)
        {
            Console.Write(msg);
        }

    }
}
