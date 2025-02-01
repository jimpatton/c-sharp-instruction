namespace Rectangle_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Rectangle Calculator");

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("\nEnter length: ");
                decimal l = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("enter width: ");
                decimal w = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(" Area: " + (l + w));
                Console.WriteLine(" Perimeter: " + (2 * l) + (2 * w));
                Console.WriteLine("\nContinue (y/n) :");
                choice = Console.ReadLine();
            }
        }
    }
}
