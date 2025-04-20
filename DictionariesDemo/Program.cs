using ConsoleLibrary;

namespace DictionariesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Dictionary Demo!");

            Dictionary<string, string> usStates = new Dictionary<string, string>();
            //Add adds and entry, throws and exception if already exists
            usStates.Add("OH", "Ohio");
            //[]Indexer - sets position in dictionary, replaces entry if already exists
            usStates["IN"] = "Indiana";
            MyConsole.PrintLine("Enter some US states. Enter EX to exit");
            MyConsole.PrintLine("===========================");

            string stateAbbreviation = "";
            while (stateAbbreviation != "EX")
            {
                stateAbbreviation = MyConsole.PromptString("US State Abbreviation: ").ToUpper();
                if (stateAbbreviation == "EX")
                    break;
                string stateName = MyConsole.PromptString("State name: ");
                //usStates.Add(stateAbbreviation, stateName);
                usStates[stateAbbreviation] = stateName;


                //store in a dictionary
            }
            MyConsole.PrintLine("Get States:");
            MyConsole.PrintLine($"Key 'OH' = {usStates["OH"]}");


            MyConsole.PrintLine("Display all keys: ");
            //List<string> states = new List<string>(usStates.Keys);
            foreach (string s in usStates.Keys)
            {
                MyConsole.Print(s+ ", ");
            }

            MyConsole.PrintLine("");

            MyConsole.PrintLine("Display all values: ");
            foreach (string s in usStates.Values)
            {
                MyConsole.Print(s + ", ");
            }

            MyConsole.PrintLine("\nKey Value Pairs");
            foreach (KeyValuePair<string,string> entry in usStates)
            {
                MyConsole.PrintLine($"{entry.Key} - {entry.Value}");
            }

            MyConsole.PrintLine("Remove an entry");
            usStates.Remove("OH");

            //MyConsole.PrintLine(usStates.ToString());

            foreach (KeyValuePair<string, string> entry in usStates)
            {
                MyConsole.PrintLine($"{entry.Key} - {entry.Value}");
            }




            MyConsole.PrintLine("\nBye");
        }
    }
}
