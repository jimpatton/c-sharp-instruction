using ConsoleLibrary;

namespace ContactList2
{
    internal class Program
    {
        static List<Contact> Contacts = new List<Contact>();
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Contact List 2\n");
            Contact newContact = new Contact();
            //while loop :continue
            string choice = "y";
            while (choice == "y")
            {
                //prompt first, last, email, phone: strings
                string firstName = MyConsole.PromptString("Enter first name: ");
                string lastName = MyConsole.PromptString("Enter last name: ");
                string email = MyConsole.PromptString("Enter email: ");
                string phoneNumber = MyConsole.PromptString("Enter phone number: ");
                newContact = new Contact(firstName, lastName, email, phoneNumber);
                Contacts.Add(newContact);

                foreach (Contact contact in Contacts)
                {
                    MyConsole.PrintLine(contact.DisplayContact());
                }

                choice = MyConsole.PromptString("\nContinue? (y/n): ").ToLower();
            }


            MyConsole.PrintLine("\nBye");
        }
    }
}
