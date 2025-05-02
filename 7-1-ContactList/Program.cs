using System.Text.RegularExpressions;

namespace _7_1_ContactList
{
    internal class Program
    {
        static List<Contact> Contacts = new List<Contact>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contact List application");
            Contact newContact = new Contact();
            string choice = "y";
            while (choice.ToLower() == "y") {
                Console.Write("\nEnter first name: ");
                string FirstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                string LastName = Console.ReadLine();
                Console.Write("Enter email address: ");
                string Email = Console.ReadLine();
                while (!IsValidEmail(Email)) {
                    Console.WriteLine("Error! Please enter valid email format.");
                    Console.Write("Enter email address: ");
                    Email = Console.ReadLine();                
                }
                Console.Write("Enter phone number: ");
                string Phone = Console.ReadLine();
                while (!IsValidPhone(Phone)) {
                    Console.WriteLine("Error! Please use format xxx-xxx-xxxx");
                    Console.Write("Enter phone number: ");
                    Phone = Console.ReadLine();                
                }
                newContact = new Contact(FirstName,LastName,Email,Phone);
                Contacts.Add(newContact);
                foreach (Contact contact in Contacts) {
                    Console.WriteLine(contact.DisplayContact());
                }
                Console.Write("\nContinue? (y/n)");
                choice = Console.ReadLine();
            }

        }

        public static Boolean IsValidEmail(string email) {
            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w{2,6}";
            return Regex.IsMatch(email, pattern);        
        }

        public static Boolean IsValidPhone(string phone) { 
            string pattern = @"^\d{3}-\d{3}-\d{4}$";
            return Regex.IsMatch(phone, pattern);        
        }
    }
}
