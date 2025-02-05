using System.Xml.Serialization;

namespace TableOfPowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes Table");

            //valid intergers only
            //continue with y or Y
            //enter an integer
            string choice = "y";
            while (choice == "y" || choice == "Y")
            {
                int nbr = 0;
                Console.Write("\nEnter an integer: ");
                nbr = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("======\t\t=======\t\t=====");
                //square of an interger is i*i
                int squared = nbr * nbr;
                //cube of an interger is i*i*i
                int cubed = nbr * nbr * nbr;
                //display Number    Squared     Cubed (double underlined)
                for (int i = 1; i <= nbr; i++)
                {
                    Console.WriteLine(i + "\t\t" + i*i + "\t\t" + i*i*i);

                }

                Console.Write("\nContinue? (y/n): ");
                choice = (Console.ReadLine());
            }







            Console.WriteLine("\nBye");
        }
    }
}
