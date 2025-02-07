namespace StudentRegistration2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Student Registration");
            // prompt for 1st name,
            // prompt for last name
            // prompt for year
            //return msg "Welcome (first and last name)"
            //return msg "Your registration is complete"
            //return msg "Your temporary password is (first + * + year of birth)
            Print("\nEnter first name: ");
            string firstName = Console.ReadLine();
            Print("Enter last name: ");
            string lastName = Console.ReadLine();
            Print("Enter year of birth: ");
            string year = Console.ReadLine();
            PrintLine("\nWelcome " + firstName + " " + lastName);
            PrintLine("Your registration is complete.");
            PrintLine("Your temporary password is: " + firstName + "*" + year);



            PrintLine("\nBye");
        }
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }

    }
}
