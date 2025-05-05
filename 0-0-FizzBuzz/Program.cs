
namespace _0_0_FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizzbuzz Excercise");
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                int nbr = GetValidInt("Enter number: ");
                for (int i = 1; i <= nbr; i++) 
                {
                    if (i % 15 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("fizz");
                    }
                    else 
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();

            }
        }

        private static int GetValidInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();
                try
                {
                    int nbr = int.Parse(userInput);
                    return nbr;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error! Please enter a whole number");
                }
            }
        }

    }
}
