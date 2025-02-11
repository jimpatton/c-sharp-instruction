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
                //while loop: continue
            string choice = "y";
            while (choice == "y")
            {
                //prompt user for first name/ last name/ email/ phone

                string firstName = MyConsole.PromptString("Enter first name: ");
                string lastName = MyConsole.PromptString("Enter last name: ");
                string email = MyConsole.PromptString("Enter email address: ");
                string phone = MyConsole.PromptString("Enter phone: ");
                newContact = new Contact(firstName,lastName,email, phone);
                Contacts.Add(newContact);


                //displayContact information
                
                foreach (Contact contact in Contacts) 
                {
                    MyConsole.PrintLine(contact.DisplayContact());
                }
                


                choice = MyConsole.PromptString("\nContinue? (y/n)");
                
            }

            MyConsole.PrintLine("Bye");
        }
    }
}
