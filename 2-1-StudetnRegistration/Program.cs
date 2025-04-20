namespace _2_1_StudetnRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            string year = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome" + firstName +" " + lastName + "!");
            Console.WriteLine("Your registration is complete");
            Console.WriteLine("Your temporary password is " + firstName + "*" + year);
        }
    }
}
