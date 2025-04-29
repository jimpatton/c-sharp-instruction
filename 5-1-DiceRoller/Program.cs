using System.Xml.Serialization;

namespace _5_1_DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Roller");
            string choice = "y";
            while (choice.ToLower() == "y") {
            Random random = new Random();
                int d1 = random.Next(1, 6);
                int d2 = random.Next(1, 6);
                int total = d1 + d2;
                Console.WriteLine("\nDie 1: " + d1);
                Console.WriteLine("Die 2: " + d2);
                Console.WriteLine("Total: " + total);
                if (total == 2)
                {
                    Console.WriteLine("Snake eyes!");
                }
                else if (total == 7) {
                    Console.WriteLine("Craps!");                
                }
                else if (total ==12) {
                    Console.WriteLine("Box cars!");                   
                }
                Console.Write("\nRoll again? ");
                choice = Console.ReadLine();
            }


        }
    }
}
