using System.ComponentModel.Design;

namespace DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Welcome to the Dice Roller App");
            string choice = "y";
            //roll the dice, outside of while loop

                choice = GetString("\nRoll the dice? (y/n) ", "y", "n");
                Random rand = new Random();
            while (choice == "y")
            {
                //Random class
                int dieRoll1 = RollDie(rand);
                int dieRoll2 = RollDie(rand);
                int total = (dieRoll1 + dieRoll2);
                Print("Die 1: " + dieRoll1);
                Print("Die 2: " + dieRoll2);
                Print("Total: " + total);
                if (total == 2)
                {
                    Print("Snake eyes!");
                }
                else if (total == 12)
                {
                    Print("Box cars!");
                }


                choice = GetString("\nRoll again? (y/n) ", "y", "n");
            }
            Print("\nBye");
        }

        private static int RollDie(Random rand)
        {
            return rand.Next(1, 7);
        }

        static string GetString(string prompt)
        {
            Print(prompt, "");
            return Console.ReadLine();
        }
        static string GetString(string prompt, string str1, string str2)
        {
            string retStr = " ";
            bool success = false;
            while (!success)
            {
                retStr = GetString(prompt);
                if (retStr.ToLower() == str1 || retStr.ToLower() == str2)
                {
                    success = true;
                }
                else
                {
                    Print("Error entry must be either '" + str1 + "' or '" + str2 + "'. Try again.");
                }
            }
            return retStr;

        }


        static void Print(string msg, string endLine = "\n")
        {
            Console.Write(msg + endLine);
        }

    }
}

