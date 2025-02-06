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
                //was user entry a whole number?
                try
                {
                    nbr = Int32.Parse(Console.ReadLine());
                } 
                //catch
                //{
                //    Console.WriteLine("Error, entry must be and interger");
                //    continue;
                //}
                catch (Exception e)
                {
                    Console.WriteLine("Error, entry must be and interger");
                    //Console.Error.WriteLine("e.Message: " + e.Message);
                    //Console.Error.WriteLine("e.ToString(): " + e.ToString());
                    continue;
                }
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
