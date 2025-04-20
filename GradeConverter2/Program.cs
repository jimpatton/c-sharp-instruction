namespace GradeConverter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Grade Calculator 2");

            string choice = "y";
            while (choice == "y" || choice == "Y")
            {
                // While loop for Continue?
                //y or Y
                // prompt to enter numerical grade
                Print("\nEnter numerical grade: ");
                int numGrade = Int32.Parse(Console.ReadLine());
                // convert number grade to letter 
                //if 88-100 A
                //80-87 B
                //67-79 C
                //60-67 D
                //<60 F
                string letterGrade = "";
                if (numGrade >= 88)
                    letterGrade = "A";
                else if (numGrade >= 80)
                    letterGrade = "B";
                else if (numGrade >= 67)
                    letterGrade = "C";
                else if (numGrade >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";
                Console.WriteLine("Letter grade: " + letterGrade);


                Print("\nContinue? (y/n)");
                choice = Console.ReadLine();
            }


            Print("\nBye");

        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }



    }
}
