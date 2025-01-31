namespace Ch4StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");

            Console.WriteLine("\nEnter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your year of birth: ");
            string yearOfBirth = Console.ReadLine();
            Console.WriteLine("\nWelcome " + firstName + " " + lastName);
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " +firstName +"*" +yearOfBirth);
            
        }
    }
}
