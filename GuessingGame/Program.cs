using System.Xml.Serialization;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Welcome to the Guess the Number Game");
            Print("+++++++++++++++++++++++++++++++++++++");
            Print("\nI'm thinking of a number from 1 to 100");
            Print("Try to guess it.");
            string choice = "y";
            while (choice == "y")
            {
            // random generate number between 1 and 100 for guessing
                Random rand = new Random();
                int num = rand.Next(1, 100);
            //user enter's guess
                Console.Write("\nEnter Number: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                int attempt = 0;
                attempt = attempt++;
                //compare user guess to random
                //track number of guesses 
                //if higher then random: "Too High",  if 10 or more higher "Way too high!
                //if lower then opposite
                while (guess != num)
                {
                if (guess == num)
                {
                    Print("You got it in 1 tries. \nGreat work! You are a mathematical wizard.");
                }
                    if (guess > num + 10)
                    {
                        Print("Way too high. Try again");

                    }
                    else if (guess > num)
                    {
                        Print("Too high. Try again");
                    }
                    else if (guess < num - 10)
                    {
                        Print("Way too low. Try again");
                    }
                    else if (guess < num)
                    {
                        Print("Too low. Try again.");
                    }
                    
                    else if (guess == num)
                    {
                        Print("You got it in {attempt} tries. \nGreat work! ");
                    }
                    
                        



                }
                              
                




                Console.Write("\nTry again? (y/n) ");
                choice = Console.ReadLine();


            }
                                 
            
            Print("\nBye");
        }

        static string GetString(string prompt)
        {
            Print(prompt, "");
            return Console.ReadLine();
        }

        
            static void Print(string msg, string endLine = "\n")
        {
            Console.Write(msg + endLine);
        }
    }
}
