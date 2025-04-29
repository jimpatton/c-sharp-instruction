using System.Xml.Serialization;

namespace _4_4_CommonDivisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greatest Common Divisor Finder");
            string choice = "y";
            while (choice == "y".ToLower()) {
                Console.Write("\nEnter first number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int y = int.Parse(Console.ReadLine());
                if (x > y) {
                    int temp = x;
                    x = y;
                    y = temp;
                }
                for (;y != 0;)
                {
                    int remainder = x % y;
                    x = y;
                    y = remainder;
                }
                Console.WriteLine("Greatest common divisor: " + x);

                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();

            }

        }
    }
}
