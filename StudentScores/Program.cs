using ConsoleLibrary;

namespace StudentScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("The Student Scores Application\n");
            List<Student> persons = new List<Student>();
            string choice = "y";
            while (choice == "y")
            {
                //prompt last name, first name, score
                MyConsole.PrintLine("Student");
                string lastName = MyConsole.PromptString("Last name: ");
                
                string firstName = MyConsole.PromptString("First name: ");
                
                int score = MyConsole.PromptInt("Score: ");
                Student student = new Student(lastName, firstName, score);
                persons.Add(student);



                choice = MyConsole.PromptString("\nEnter another student? (y/n) ").ToLower();
            }

            //score summary outside loop
            MyConsole.PrintLine("SUMMARY");
            foreach (Student person in persons)
            {
                {
                    MyConsole.Print(person.ToString());
                }

                //class Student should hold names and scores
            }

                MyConsole.PrintLine("\nBye");
            
        }
    }
}
