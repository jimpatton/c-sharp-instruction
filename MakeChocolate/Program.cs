using ConsoleLibrary;

namespace MakeChocolate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Make Chocolate!\n");


            //goal/ 5 = number of big bars
            //int big = goal/5
            //small = goal % 5
            //if (small <= goal){return small}
            //else {return -1}





            MyConsole.PrintLine("\nBye");
        }
        public static int MakeChocolate(int small, int big, int goal)
        {
            if (small!= 0)
            {
                int kilogoal = goal / 5;
                goal = goal % 5;
                small = goal;
                string k = $"{small}";
                return k;
            }

        }


    }
}
