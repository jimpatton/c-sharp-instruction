using ConsoleLibrary;

namespace ch12GuessGame
{
    internal class Program
    {
        //constants
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Guess the Number Game");
            MyConsole.PrintLine("+++++++++++++++++++++++++++++++++++++\n");
            string choice = "y";
            Random rand = new Random();
            while (choice == "y")
            {
                //user enter's guess
                MyConsole.PrintLine("\nI'm thinking of a number from " + MIN_VAL + " to " + MAX_VAL);
                MyConsole.PrintLine("\nTry to guess it.");
                int num = rand.Next(MIN_VAL, MAX_VAL + 1);
                int count = 0;
                int guess = 0;

                //compare user guess to random
                //track number of guesses 
                //if higher then random: "Too High",  if 10 or more higher "Way too high!
                //if lower then opposite
                while (guess != num)
                {
                    MyConsole.Print("\nEnter Number: ");
                    guess = Int32.Parse(Console.ReadLine());
                    count++;
                    if (guess == num)
                    {
                        MyConsole.PrintLine("You got it in " + count + " tries.");
                        if (count <= 3)
                        {
                            MyConsole.PrintLine("\nGreat work! You are a mathematical wizard.");
                        }
                        else if (count <= 7)
                        {
                            MyConsole.PrintLine("Not Too Bad!");
                        }
                        else
                        {
                            MyConsole.PrintLine("What took you so long? Maybe you should take some lessons");
                        }
                    }
                    else if (guess > num + 10)
                    {
                        MyConsole.PrintLine("Way too high. Try again");
                        //Console.Write("\nEnter number: ");
                        //guess = Int32.Parse(Console.ReadLine());
                    }
                    else if (guess > num)
                    {
                        MyConsole.PrintLine("Too high. Try again");
                        //Console.Write("\nEnter number: ");
                        //guess = Int32.Parse(Console.ReadLine());
                    }
                    else if (guess < num - 10)
                    {
                        MyConsole.PrintLine("Way too low. Try again");
                        //Console.Write("\nEnter number: ");
                        //guess = Int32.Parse(Console.ReadLine());
                    }
                    else if (guess < num)
                    {
                        MyConsole.PrintLine("Too low. Try again.");
                        //Console.Write("\nEnter number: ");
                        //guess = Int32.Parse(Console.ReadLine());
                    }

                    else
                    {
                        
                        guess = Int32.Parse(Console.ReadLine());
                    }


                }

                MyConsole.PrintLine("You got it! Congratulations!");


                MyConsole.Print("\nTry again? (y/n) ");
                choice = Console.ReadLine();


            }


            MyConsole.Print("\nBye - Come back again soon!");
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
