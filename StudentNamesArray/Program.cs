using ConsoleLibrary;

namespace StudentNamesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine ("Student name array!\n");
            //prompt user for # of students
            int nbrStudents = MyConsole.PromptInt("Number of students: ");
            string[] studentArray = new string[nbrStudents];

            //for loop - loop through studentArray
            for (int i = 0; i < nbrStudents; i++)
            {
                // for each position in the array
                //prompt name
                string name = MyConsole.PromptString($"Student name[{i}]: ");
                //add name to student array
                studentArray[i] = name;

            }

            //print array on one line - one way
            //string names = "";
            //foreach (string name in studentArray) { 
            //names += name + "|";
            //}
            //MyConsole.PrintLine(names);

            //another way
            //foreach (string n in studentArray)
            //{
            //    MyConsole.Print(n + "|");
            //}

            //thrid way
            Array.Sort(studentArray);
            Array.ForEach(studentArray, student => Console.Write(student + "|"));
            Console.WriteLine();
            

        }
    }
}
