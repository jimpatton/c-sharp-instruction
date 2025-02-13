using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using ConsoleLibrary;

namespace CountryList
{
    internal class Program
    {
        static List<string> items = new List<string>();
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Country List Manager\n");

            //while
            string command = "";
            while (command != "3")
            {
                //DisplayMenu() ->method
                DisplayMenu();
                //Prompt command "Enter menu number
                MyConsole.Print("\nEnter menu number: ");
                command = Console.ReadLine();
                //evaluate command: 1(list), 2(add), 3(exit)
                switch (command)
                {
                    case "1":
                        ListCountries();
                        break;
                    case "2":
                        AddCountry();
                        break;
                    // stop loop when command 3(exit)
                    case "3":
                        break;

                }

            }

            MyConsole.PrintLine("\nGoodbye");
        }

        static void DisplayMenu()
        {
            MyConsole.PrintLine("\nCOMMAND MENU");
            MyConsole.PrintLine("1 - List countries");
            MyConsole.PrintLine("2 - Add a country");
            MyConsole.PrintLine("3 - Exit");
        }

        static void ListCountries()
        {
            if (items.Count < 1)
            {
                MyConsole.PrintLine("\nNo countries on the list");
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    MyConsole.PrintLine($"{items[i]}");
                }


            }
        }

            static void AddCountry()
            {
                MyConsole.Print("\nEnter country: ");
                string country = Console.ReadLine();
                items.Add(country);
                MyConsole.PrintLine($"\n{country} was added.");
            }


        

    }
}
