namespace Wizard
{
    internal class Program
    {
        static List<string> items = new List<string>();
        static void Main(string[] args)
        {
            PrintLine("Wizard Inventory\n");
            items.Add("wooden staff");
            items.Add("wizard hat");
            items.Add("cloth shoes");
            string command = "";
            while (command != "exit")
            {
                DisplayMenu();
                Print("Command: ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "show:":

                        ShowItems();
                        break;
                    case "grab:":

                        GrabItems();
                        break;
                    case "edit:":

                        EditItems();
                        break;
                    case "drop:":

                        DropItems();
                        break;
                    case "exit:":
                        break;

                        //while
                        // display menu
                        //prompt command
                        //evaluate command: show, grab, edit or drop item(s)
                        //stop loop when command = "exit"
                }
                PrintLine("");


                PrintLine("Bye");
            }
            static void DisplayMenu()
            {
                PrintLine("COMMAND MENU");
                PrintLine("show - show all items");
                PrintLine("grab - grab all items");
                PrintLine("edit - edit an item");
                PrintLine("drop - drop an item");
                PrintLine("exit - exit the app");



            }
        }
        static int PromptInt(string prompt, int min, int max)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Print(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= min && result <= max)
                    {
                        isValid = true;
                    }
                    else
                    {
                        PrintLine("error entry must be in range");
                    }
                }
                else
                {
                    PrintLine("Error - entry must be a whole number");
                }

            }


            return result;
        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }

        private static void DropItems()
        {
            PrintLine("Drop an items:");
            int itemNumber = PromptInt("Item # to drop: ", 1, items.Count);
            string itemName = items[itemNumber - 1];
            items.Remove(itemName);
            PrintLine($"{itemName} was removed");
        }

        private static void EditItems()
        {
            PrintLine("edit an items:");
            //prompt for item number to edit
            int itemNumber = PromptInt("Item # to edit: ", 1, items.Count);
            //prompt for updated name
            Print("Updated name: ");
            string updatedName = Console.ReadLine();
            //edit the item at that position
            items[itemNumber - 1] = updatedName;
            //dispalay message confirm item # was updated
            PrintLine($"Item number {itemNumber} was updated");


        }

        private static void GrabItems()
        {
            PrintLine("grab/add all items:");
            if (items.Count >= 4)
            {
                PrintLine("Carrrying too many items, please drop one first");
            }
            else
            {
                Print("Item to add: ");
                string itemName = Console.ReadLine();
                items.Add(itemName);
                PrintLine($"{itemName} was added.");
            }
        }

        private static void ShowItems()
        {
            PrintLine("show all items:");
            for (int i = 0; i < items.Count; i++)
            {
                PrintLine($"{i + 1}. {items[i]}");
            }

        }
    }
}
