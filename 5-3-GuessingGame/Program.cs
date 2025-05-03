using System.ComponentModel.Design;

namespace _5_3_GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Welcome to the Guess the Number Game");
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.WriteLine("\nI'm thinking of a number between 1 and 100.\nTry to guess it.");
                
                int nbr = random.Next(1,101);
                int count = 0;
                int guess = 0;
                while (guess != nbr) 
                {
                    guess = GetValidInteger("\nEnter number: ",1,100);
                    count++;
                    if (guess == nbr)
                    {
                        Console.WriteLine($"You guessed it in {count} tries");
                        if (count < 3)
                        {
                            Console.WriteLine("You are a mathematical wizard");
                        }
                        else if (count <= 7)
                        {
                            Console.WriteLine("Not too bad! You've got some potential");
                        }
                        else
                        {
                            Console.WriteLine("What took you so long?");
                        }
                    }
                    else if (guess >= nbr + 10)
                    {
                        Console.WriteLine("Way too high!");
                    }
                    else if (guess > nbr)
                    {
                        Console.WriteLine("Too high");
                    }
                    else if (guess <= nbr - 10)
                    {
                        Console.WriteLine("Way too low!");                   
                    }
                    else if (guess < nbr)
                    {
                        Console.WriteLine("Too low");
                    }
                }
                Console.Write("\nPlay again? (y/n)");
                choice = Console.ReadLine();

            }   
        }
        public static int GetValidInteger(string prompt, int min, int max)
        {
            int value = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out value))
                {
                    if (value >= min && value <= max)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine($"Error! Please enter a number between {min} and {max}");
                    }
                }
                else
                {
                    Console.WriteLine("Error! Please enter a whole number");
                }
            }
            return value;
        }
    }
}
