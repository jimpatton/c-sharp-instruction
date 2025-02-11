using ContactList;

namespace LetterGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Letter Grade Converter!\n");
            string choice = "y";
            while (choice == "y")
            {
                //prompt for numerical grade
                //show letter grade from GetLetter
                int number = ValidateNumber("Enter numerical grade: ", 1, 100);
                Grade grade = new Grade(number);
                MyConsole.PrintLine("Letter grade: " + grade.GetLetter());

                choice = MyConsole.PromptString("\nContinue? (y/n): ");

            }

            MyConsole.PrintLine("\nBye");
        }
        public static int ValidateNumber(string prompt, int min, int max)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= min && result <= max)
                    {

                        isValid = true;
                    }
                    else
                    {
                        MyConsole.PrintLine("Error must be within range");
                    }

                }
                else
                {
                    MyConsole.PrintLine("Error must be an integer");
                }
            }
            return result;
        }

    }
}
