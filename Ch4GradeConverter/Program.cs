using System.ComponentModel.Design;

namespace Ch4GradeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Letter Grade Converter");

            
            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("\nEnter numerical grade: ");
                int numGrade = Convert.ToInt32(Console.ReadLine());
                string letterGrade = "";
                //if numGrade >= 88 letterGrade = A
                if (numGrade >= 88)
                {
                    letterGrade = "A";
                }
                //else if numGrade >= 80 lg = B
                else if (numGrade >= 80)
                {
                    letterGrade = "B";
                }
                else if (numGrade >= 68)
                {
                    letterGrade = "C";
                }
                else if (numGrade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }
                Console.WriteLine("Letter grade: " + letterGrade);
                Console.WriteLine("\nContinue? (y/n): ");
                choice = Console.ReadLine();
            }
        }
    }
}
