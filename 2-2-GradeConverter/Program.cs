using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace _2_2_GradeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter");
            // while loop to continue
            string choice = "y".ToLower();
            while (choice == "y")
            {
                //probe for numGrade
                Console.Write("Enter numerical grade: ");
                int numGrade = int.Parse(Console.ReadLine());
                string letterGrade = "";
                //if statements for letterGrade
                if (numGrade >= 88)
                {
                    letterGrade = "A";
                }
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

                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();

            }
        }
    }
}
