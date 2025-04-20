using System;
using System.Globalization;
using ConsoleLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArraysListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Arrays and List Practice\n");




            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DisplayListAsString(numbers, "Original List");
            //create new list called doubleNumbers -> each number *2
            List<int> twoTimes = new List<int>();
            foreach (int number in numbers)
            {
                twoTimes.Add(number * 2);
            }
            DisplayListAsString(twoTimes, "Multiplied by 2 (1)");
            //do the same with a method
            List<int> twoTimes2 = numbers.Select(timesTwo).ToList();
            DisplayListAsString(twoTimes2, "Multiplied by 2 (2)");
            //do same with Lambda expression
            List<int> twoTimes3 = numbers.Select(x => x * 2).ToList();
            DisplayListAsString(twoTimes3, "Multiplied by 2 (3)");

            //create new list called evenNumbers (evenly divisible by 2)
            List<int> divTwo = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    divTwo.Add(number);
                }
            }
            DisplayListAsString(divTwo, "Even Numbers (1)");
            //do same but with odd numbers
            List<int> notDivTwo = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    notDivTwo.Add(number);
                }
            }
            DisplayListAsString(notDivTwo, "Odd Numbers (1)");

            List<string> names = new List<string>() { "jim", "nick", "andy", "christian", "adrian", "sean", "celina", "joe", "heath" };
            //create a new list so that names are Capitalized
            List<string> titleNames = new List<string>() { "jim", "nick", "andy", "christian", "adrian", "sean", "celina", "joe", "heath" };
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            for (int i = 0; i < names.Count; i++)
            {
                names[i] = textInfo.ToTitleCase(names[i].ToLower());

            }
            foreach (string name in titleNames)
            {
            }
            DisplayListAsString2(names, "Title Case (1)");

            //do again another way
            string firstLetter = "";
            string otherLetter = "";
            List<string> titleNames2 = new List<string>();
            foreach (string name in titleNames2)
            {
                firstLetter = name.Substring(0, 1).ToUpper();
                otherLetter = name.Substring(1).ToLower();
            }
            DisplayListAsString2(names, "Title Case (2)");



            //filter for names starting with A or C
            List<string> filteredNames = new List<string>();
            foreach (string name in names)
            {
                if (name.StartsWith("A")|| name.StartsWith("C"))
                {
                    filteredNames.Add(name);
                    filteredNames.Sort();
                }
                //else if (name.StartsWith("C"))
                //{
                //    filteredNames.Add(name);
                //}
                
            }
                DisplayListAsString2(filteredNames, "Filtered Names");



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
        private static int timesTwo(int nbr)
        {
            return nbr * 2;
        }

        private static void DisplayListAsString2(List<string> names, string header)
        {
            string result = "========================================\n";
            result += header + "\n";
            result += "========================================\n";
            foreach (var value in names)
            {
                result += value.ToString() + " ";
            }
            result += "\n";
            MyConsole.PrintLine(result);
        }
    }
}
