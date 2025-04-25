namespace _4_1_TableOfPowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes table");
            string choice = "y";
            while (choice == "y".ToLower())
            {
                Console.Write("\nEnter and integer: ");
                int nbr = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNumber\tSquared\tCubed");
                Console.WriteLine("======\t=======\t=====");                
                for (int i = 1; i <= nbr; i++) 
                Console.WriteLine($"{i}\t\t{i * i}\t\t{i * i * i}");
                Console.Write("\nContinue? (y/n) ");
                choice = Console.ReadLine();
            }
        }
    }
}
