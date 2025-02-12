using ConsoleLibrary;

namespace WizardInventory
{
    internal class Program
    {
        static List<string> items = new List<string>();
        static void Main(string[] args)
        {
            MyConsole.PrintLine("The Wizard Inventory Game\n");
            items.Add("wooden staff");
            items.Add("wizard hat");
            items.Add("cloth shoes");
            //while
            string command = "";
            while (command != "exit")
            {
                //display menu
                DisplayMenu();
                //prompt command 
                MyConsole.Print("\nCommand: ");
                command = Console.ReadLine().ToLower();
                //evaluate command:show, grab, edit or drop item
                switch (command)
                {
                    case "show":
                        ShowItems();
                        break;
                    case "grab":
                        GrabItems();
                        break;
                    case "edit":
                        EditItems();
                        break;
                    case "drop":
                        DropItems();
                        break;
                    case "exit":
                        break;
    
                }

                //stop loop when command = "exit"

            }

            MyConsole.PrintLine("\nBye!");
        }
        static void DisplayMenu()
        {
            MyConsole.PrintLine("\nCOMMAND MENU");
            MyConsole.PrintLine("show - Show all items");
            MyConsole.PrintLine("grab - Grab an item");
            MyConsole.PrintLine("edit - Edit an item");
            MyConsole.PrintLine("drop - Drop an item");
            MyConsole.PrintLine("exit - Exit program");
        }

        static int PromptInt(string prompt, int min, int max)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                MyConsole.Print(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= min && result <= max)
                    {
                        isValid = true;
                    }
                    else
                    {
                        MyConsole.PrintLine("error entry must be in range");
                    }
                }
                else
                {
                    MyConsole.PrintLine("Error - entry must be a whole number");
                }

            }

            return result;
        }

        private static void DropItems()
        {
            MyConsole.PrintLine("Drop an item: ");
            int itemNumber = PromptInt("Item # to drop: ", 1, items.Count);
            string itemName = items[itemNumber - 1];
            items.Remove(itemName);
            MyConsole.PrintLine($"{itemName} was removed");
        }
        private static void EditItems()
        {
            MyConsole.PrintLine("Edit and item: ");
            int itemNumber = PromptInt("Item # to edit: ", 1, items.Count);
            MyConsole.Print("Updated name: ");
            string updatedName = Console.ReadLine();
            items[itemNumber - 1] = updatedName;
            MyConsole.PrintLine($"Item number {itemNumber} was updated");
        }

        private static void GrabItems()
        {
            MyConsole.PrintLine("Grab/add an item: ");
            if (items.Count >= 4)
            {
                MyConsole.PrintLine("You can't carry anymore items. Drop something first.");
            }
            else
            {
                MyConsole.Print("Item to add: ");
                string itemName = Console.ReadLine();
                items.Add(itemName);
                MyConsole.PrintLine($"{itemName} was added.");
            }
        }

        private static void ShowItems()
        {
            MyConsole.PrintLine("Show all items: ");
            for (int i = 0; i < items.Count; i++)
            {
                MyConsole.PrintLine($"{i + 1}.{items[i]}");
            }
        }

    }
}
