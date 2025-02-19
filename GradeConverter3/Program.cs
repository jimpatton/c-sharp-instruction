using System.Xml.Serialization;
using ConsoleLibrary;

namespace GradeConverter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Grade converter version 3!\n");
            //While loop for continue
            string choice = "y";
            while (choice == "y")
            {
                //prompt numerical grade
                int numericalGrade = MyConsole.PromptInt("\nEnter numerical grade: ");
                
                //return letter grade
                MyConsole.PrintLine($"Letter grade: {GetGrade(numericalGrade)}");


                choice = MyConsole.PromptString("\nContinue? (y/n)").ToLower();
            }

            MyConsole.PrintLine("\nBye");
        }

        private static string GetGrade(int numericalGrade)
        {
            string letterGrade = "";
            if (numericalGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numericalGrade >= 80)
            {
                letterGrade = "B";
            }
            else if (numericalGrade >= 68)
            {
                letterGrade = "C";
            }
            else if (numericalGrade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            return letterGrade;
        }

    }
}

