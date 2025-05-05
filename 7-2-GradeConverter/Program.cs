
namespace _7_2_GradeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Letter Grade Converter");
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                int grade = getNumGrade("\nEnter numerical grade: ");
                string letterGrade = Grade.getLetterGrade(grade);
                Console.WriteLine($"Letter grade: {letterGrade}");
            }
        }

        private static int getNumGrade(string prompt)
        {
            while (true)
            {


                Console.Write(prompt);
                string userInput = Console.ReadLine();
                try
                {
                    int grade = int.Parse(userInput);
                    return grade;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter a whole number.");
                }


            }
        }
    }
}
