using ConsoleLibrary;

namespace _1on1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("1on1!");
            int number1 = 11;
            int number2 = 22;

            MyConsole.PrintLine($"Sum of number1 and numbe21 is {GetSum(number1,number2)}");
            MyConsole.PrintLine($"difference of number1 and number2 is {GetDif(number1, number2)}");


        }
        public static int GetSum(int number1, int number2) {
            return number1 + number2;
        }

        public static int GetDif(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
