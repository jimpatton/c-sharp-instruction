using System.Net.NetworkInformation;
using System.Text;

namespace Chap9Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Chapter 9 demos - dates and chains");
            //what's the current date and time?
            DateTime currentDateTime = DateTime.Now;
            //what's the current date?
            DateTime today = DateTime.Today;
            //string contactenation
            PrintLine("Current date = " + currentDateTime + ".");
            //string interpolation
            PrintLine($"Today = {today}.");

            //pg 277
            PrintLine($"longDate: {currentDateTime.ToLongDateString()}");
            PrintLine($"longtime: {currentDateTime.ToLongTimeString()}");
            PrintLine($"shorttime: {currentDateTime.ToShortTimeString()}");
            PrintLine($"shortdate: {currentDateTime.ToShortDateString()}");


            //pg 279
            PrintLine($"month: {currentDateTime.Month}");
            PrintLine($"day: {currentDateTime.Day}");
            PrintLine($"day of week: {currentDateTime.DayOfWeek}");
            PrintLine($"day of year: {currentDateTime.DayOfYear}");
            PrintLine($"Year: {currentDateTime.Year}");
            PrintLine($"days in month - 2025, 2: {DateTime.DaysInMonth(2025, 2)}");
            PrintLine($"Leapyear for 2025: {DateTime.IsLeapYear(2025)}");
            PrintLine($"Leapyear for 2028: {DateTime.IsLeapYear(2028)}");

            //pg 281
            //due date in 2 months
            DateTime dueDate = currentDateTime.AddMonths(2);
            PrintLine($"due date: {dueDate}");

            //Halloween 2025
            DateTime halloween = new DateTime(2025, 10, 31);
            PrintLine($"halloween: {halloween}");
            //is halloween after today?
            PrintLine($"halloween > today? {halloween > currentDateTime}");
            TimeSpan timeTillHalloween = halloween.Subtract(currentDateTime);
            PrintLine($"days until halloween: {timeTillHalloween.Days}");

            //Strings p 285
            //loop through characters in a string
            string sentence = "whoo hoo so glad today is friday!";
            foreach (char c in sentence)
            {
                Print(c + " ");
            }

            //hangman - creating an underscore version of a word
            // word is "Superman" the hiddenVersion would be "_ _ _ _ _ _ _ _"
            string word = "superman";
            string hiddenVersion = "";
            foreach (char c in word)
            {
                hiddenVersion += "_ ";
            }
            hiddenVersion = hiddenVersion.Trim();
            PrintLine("the word is supperman");
            PrintLine($"the hidden version is: {hiddenVersion} .");

            //pg 293
            StringBuilder sb = new StringBuilder();
            sb.Append("hello");
            sb.Append(" there");
            PrintLine(sb.ToString());





            PrintLine("\nbye");
        }

        static void Print(string msg)
        {
            Console.Write(msg);
        }
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
