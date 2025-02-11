using System.Xml.Serialization;

namespace ContactList
{
    internal class Program
    {
        static List<Contact> Contacts = new List<Contact>();
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Contact List Application!\n");
            //create class to store information

            Contact newContact = new Contact();
            string choice = "y";
            while (choice == "y")
            {
                //while loop: continue
                //prompt user for first name/ last name/ email/ phone

                string FirstName = MyConsole.PromptString("Enter first name: ");
                string LastName = MyConsole.PromptString("Enter last name: ");
                string Email = MyConsole.PromptString("Enter email address: ");
                string Phone = MyConsole.PromptString("Enter phone: ");
                newContact = new Contact(FirstName,LastName,Email, Phone);
                Contacts.Add(newContact);
                

                //display contact information
                MyConsole.PrintLine("\n-----------------------------------");
                MyConsole.PrintLine("----Current Contact----------------");
                MyConsole.PrintLine("-----------------------------------");
                foreach (Contact contact in Contacts) 
                {
                    MyConsole.PrintLine(contact.ToString());
                }
                MyConsole.PrintLine("-----------------------------------");


                choice = MyConsole.PromptString("\nContinue? (y/n)");
                
            }

            MyConsole.PrintLine("Bye");
        }
    }
}
