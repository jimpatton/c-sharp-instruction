using System.Runtime.InteropServices.JavaScript;
using ConsoleLibrary;

namespace MethodsAndCollections
{
    internal static class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            List<string> names = ["Jim", "Mike", "Landon"];
            foreach (string name in names)
            {
                MyConsole.PrintLine(name);
            }

            names.Add("Andy");
            foreach (string name in names)
            {
                MyConsole.PrintLine(name);
            }


            //MyConsole.PrintLine(AddSum(numbers).ToString());

            //MyConsole.PrintLine(Concat("jim", "patton"));
        }

        public static string Concat(string word1, string word2) =>
            $"word 1:{word1} word 2:{word2}";








        public static int AddSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }






            //foreach (int number in numbers) {
            //    sum += number;               
            //}
            return sum;
        }
    }

}
