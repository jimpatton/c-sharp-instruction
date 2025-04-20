using System.Reflection;
using ConsoleLibrary;

namespace CountryList2
{

    internal class Program
    {
        static List<string> countries = new List<string>();
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Country List 2");
            string command = "";
            while (command != "3")
            {
                DisplayMenu();
                MyConsole.Print("\nCommand: ");
                command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        ListCountries();
                        break;
                    case "2":
                        AddCountry();
                        break;
                    case "3":
                        break;
                }
            }
            MyConsole.PrintLine("\nGoodbye");
        }
        private static void AddCountry()
        {
            MyConsole.Print("\nEnter country: ");
            string country = Console.ReadLine();
            countries.Add(country);
            MyConsole.PrintLine("\nThis country has been added");
        }

        private static void ListCountries()
        {
            if (countries.Count < 1)
            {
                MyConsole.PrintLine("\nNo countries in list");
            }
            else
            {
                countries.Sort();
                foreach (string country in countries) { }
                for (int i = 0; i < countries.Count; i++)
                {
                    MyConsole.PrintLine($"\n{countries[i]}");
                }
            }

        }

        private static void DisplayMenu()
        {
            MyConsole.PrintLine("\nCOMMAND MENU");
            MyConsole.PrintLine("1 - List countries");
            MyConsole.PrintLine("2 - Add country");
            MyConsole.PrintLine("3 - Exit");
        }
    }
}
