using ConsoleLibrary;

namespace LambdasDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Lambdas Demo!\n");

            MyConsole.PrintLine("Original List");
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int number in numbers)
            {
                MyConsole.PrintLine(number.ToString());
            }

            //create a new list called squaredNums1
            //store the squared version of all numbers
            MyConsole.PrintLine("\nSquared Numbers");
            List<int> squaredNumbers = new List<int>();
            foreach (int number in numbers)
            {
                squaredNumbers.Add(Square(number));
            }
            foreach (int number in squaredNumbers)
            {
                MyConsole.PrintLine(number.ToString());
            }

            //Do squared list again using a method as a parameter
            List<int> squares2 = numbers.Select(Square).ToList();
            DisplayListAsString(squares2, "Squared list (2) using method as a parameter");

            //Do squared list again using a lambda expression
            List<int> squares3 = numbers.Select(x => x * x).ToList();
            DisplayListAsString(squares3, "Squared list (3) using a lambda expression");




            //create a new list called divThree1
            //store the nums from numbers that are evenly divisible by 3
            MyConsole.PrintLine("\nDivisible by 3 evenly");
            List<int> divThree1 = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 3 == 0)
                {
                    divThree1.Add(number);
                };
            }
            foreach (int number in divThree1)
            {
                MyConsole.PrintLine(number.ToString());
            }

            // do again with method
            List<int>divThree2 = numbers.FindAll(IsDivisibleByThree);
            DisplayListAsString(divThree2, "Div 3 List (2)");
            //so again with lambda

            List<int> divThree3 = numbers.FindAll(x=> x % 3 == 0).ToList();
            DisplayListAsString(divThree3, "Div 3 List (3)");









            MyConsole.PrintLine("\nBye");
        }
        private static void DisplayListAsString(List<int> numbers, string header)
        {
            string result = "========================================\n";
            result += header + "\n";
            result += "========================================\n";
            foreach (var value in numbers)
            {
                result += value.ToString() + " ";
            }
            result += "\n";
            MyConsole.PrintLine(result);
        }
        private static int Square(int nbr)
        {
            return nbr * nbr;
        }

        private static bool IsDivisibleByThree(int x)
        {
            return x % 3 == 0;
        }
    }
}
