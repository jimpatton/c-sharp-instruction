using ConsoleLibrary;

namespace _7_3GuessingGame
{
    public class Game
    {
        public string Guess { get; set; }
        public Game()
        {

        }
        public Game(string guess) {
            Guess = guess;
            int count = 0;
            int nbr = 0;
            while(guess != num)
                {
                Console.Write("\nEnter Number: ");
                guess = Int32.Parse(Console.ReadLine());
                count++;
                if (guess == num)
                {
                    MyConsole.Print("You got it in " + count + " tries.");
                    if (count <= 3)
                    {
                        MyConsole.Print("\nGreat work! You are a mathematical wizard.");
                    }
                    else if (count <= 7)
                    {
                        MyConsole.Print("Not Too Bad!");
                    }
                    else
                    {
                        MyConsole.Print("What took you so long? Maybe you should take some lessons");
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
                    MyConsole.Print("Too high. Try again");
                    //Console.Write("\nEnter number: ");
                    //guess = Int32.Parse(Console.ReadLine());
                }
                else if (guess < num - 10)
                {
                    MyConsole.Print("Way too low. Try again");
                    //Console.Write("\nEnter number: ");
                    //guess = Int32.Parse(Console.ReadLine());
                }
                else if (guess < num)
                {
                    MyConsole.Print("Too low. Try again.");
                    //Console.Write("\nEnter number: ");
                    //guess = Int32.Parse(Console.ReadLine());
                }

                else
                {
                    //Print("You got it in {attempt} tries. \nGreat work! ");//wont' show this message
                    guess = Int32.Parse(Console.ReadLine());
                }








            }

}
