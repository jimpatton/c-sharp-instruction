namespace SquaresCubes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Squares and Cubes");
            string choice = "y";
            while (choice == "y")
            {
                Print("\nEnter an integer: ");
                int nbr = Int32.Parse(Console.ReadLine());
                PrintLine("\nNumber\tSquared\tCubed");
                PrintLine("======\t=======\t=====");
                int squared = nbr * nbr;
                int cubed = nbr * nbr * nbr;
                for (int i = 1; i <= nbr; i++)
                {
                    PrintLine(i + "\t\t" + i * i + "\t\t" + i * i * i);
                }




                Print("\nContinue? (y/n) ");
                choice = Console.ReadLine().ToLower();

                PrintLine("\nBye");
            }
            static void PrintLine(string msg)
            {
                Console.WriteLine(msg);
            }
            static void Print(string msg)
            {
                Console.Write(msg);
            }

        }
    }
}
