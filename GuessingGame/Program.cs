using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace GuessingGame
{
    internal class Program
    {
        //constants
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        static void Main(string[] args)
        {
            Print("Welcome to the Guess the Number Game");
            Print("+++++++++++++++++++++++++++++++++++++");
            string choice = "y";
            Random rand = new Random();
            while (choice == "y")
            {
                //user enter's guess
                Print("\nI'm thinking of a number from " + MIN_VAL + " to " + MAX_VAL);
                Print("\nTry to guess it.");
                int num = rand.Next(MIN_VAL, MAX_VAL + 1);
                int count = 0;
                int guess = 0;

                //compare user guess to random
                //track number of guesses 
                //if higher then random: "Too High",  if 10 or more higher "Way too high!
                //if lower then opposite
                while (guess != num)
                {
                    Console.Write("\nEnter Number: ");
                    guess = Int32.Parse(Console.ReadLine());
                    count++;
                    if (guess == num)
                    {
                        Print("You got it in " + count + " tries.");
                        if (count <= 3) {
                            Print("\nGreat work! You are a mathematical wizard.");
                        }
                        else if (count <= 7)
                        {
                            Print("Not Too Bad!");
                        }
                        else
                        {
                            Print("What took you so long? Maybe you should take some lessons");
                        }
                    }
                    else if (guess > num + 10)
                    {
                        Print("Way too high. Try again");
                        //Console.Write("\nEnter number: ");
                        //guess = Int32.Parse(Console.ReadLine());
                    }
                    else if (guess > num)
                    {
                        Print("Too high. Try again");
                        //Console.Write("\nEnter number: ");
                        //guess = Int32.Parse(Console.ReadLine());
                    }
                    else if (guess < num - 10)
                    {
                        Print("Way too low. Try again");
                        //Console.Write("\nEnter number: ");
                        //guess = Int32.Parse(Console.ReadLine());
                    }
                    else if (guess < num)
                    {
                        Print("Too low. Try again.");
                        //Console.Write("\nEnter number: ");
                        //guess = Int32.Parse(Console.ReadLine());
                    }

                    else
                    {
                        //Print("You got it in {attempt} tries. \nGreat work! ");//wont' show this message
                        guess = Int32.Parse(Console.ReadLine());
                    }


                }

                Console.WriteLine("You got it! Congratulations!");


                Console.Write("\nTry again? (y/n) ");
                choice = Console.ReadLine();


            }


            Print("\nBye - Come back again soon!");
        }



        //static int GetNumber(string prompt)
        //{
        //    int nbr = 0;
        //    bool success = false;
        //    while (!success)
        //    {
        //        Console.Write(prompt);
        //        // was user entry a whole number?
        //        try
        //        {
        //            nbr = Int32.Parse(Console.ReadLine());
        //            }
        //           catch{
        //           Print("error - entry must be a whole number");
        //            continue;
        //        //}
                  
        //        if (nbr >= 1 && nbr <= 100)
        //        {
        //            success = true;

        //        }
        //        else
        //        {
        //            Print("error - entry must be between 1 and 100");
        //        }

        //        return nbr;






                static void Print(string msg)
        {
            Console.Write(msg);
        }
    }
}
