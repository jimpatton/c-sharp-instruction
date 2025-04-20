namespace _3_1_Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            string choice = "y".ToLower();
            while (choice == "y")
            {
                Console.Write("Enter the temperature in Fahrenheit: ");
                float f = float.Parse(Console.ReadLine());
                // celsius = (farhenheit-32) * 5/9
                float c = (f - 32) * 5 / 9;
                Console.WriteLine("Degrees in Celsius: " + c);
                Console.Write("\nContinue? (y/n): ");
                choice = Console.ReadLine();

            }

        }
    }
}
