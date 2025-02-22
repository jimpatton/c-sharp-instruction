using ConsoleLibrary;

namespace StudentScores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Student Scores 2\n");
            List<Student> students = new List<Student>();
            string choice = "y";
            while (choice == "y")
            {
                MyConsole.PrintLine("\nSTUDENT");
                string lastName = MyConsole.PromptString("Last name: ");
                string firstName = MyConsole.PromptString("First name: ");
                int score = MyConsole.PromptInt("Score: ");
                Student student = new Student(firstName,lastName,score);
                students.Add(student);



                choice = MyConsole.PromptString("\nEnter another student? (y/n): ");
            }

            MyConsole.PrintLine("\nSUMMARY");
            foreach (Student student in students)
            {

                MyConsole.Print(student.ToString());
            }

        }
    }
}
