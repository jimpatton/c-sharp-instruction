using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace RollTheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Dice Roller");
            string choice = "y";
            Print("\nRoll the dice? (y/n): ");
            choice = Console.ReadLine().ToLower();

            while (choice == "y")
            {
                //get 2 random dice rolls -> use Random class
                //total the 2 rolls
                // if total == 2 then return "Snake eyes!"
                //else if total == 7 then return "Craps!"
                //else if total == 12 then return "Box cars!"
                Random rand = new Random();
                int dieRoll1 = RollDie(rand);
                int dieRoll2 = RollDie(rand);
                int total = (dieRoll1 + dieRoll2);
                PrintLine("\nDie 1:\t" + dieRoll1);
                PrintLine("Die 2:\t" + dieRoll2);
                PrintLine("Total:\t" + total);
                if (total == 2)
                {
                    PrintLine("Snake Eyes!");
                }
                else if (total == 7)
                {
                    PrintLine("Craps!");
                }
                else if (total == 12)
                {
                    PrintLine("Box cars!");
                }








                Print("\nRoll again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }







            PrintLine("\nBye");
        }
        private static int RollDie(Random rand)
        {
            return rand.Next(1, 7);
        }

        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(string msg)
        {
            Console.Write(msg);

        }
    }
}
