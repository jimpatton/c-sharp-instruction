namespace FactorialCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator ");
            //continue with y or Y
            //enter an integer
            string choice = "y";
            while (choice == "y" || choice == "Y")
            {
                int nbr = 0;
                Console.Write("\nEnter and integer that's greater than 0 and less than 10: ");
                nbr = Int32.Parse(Console.ReadLine());
                //try
                //{
                //    nbr = Int32.Parse(Console.ReadLine());
                //}
                //catch
                //{
                //    Console.WriteLine("Error, entry must be and interger");
                //    continue;
                //}
                
                
                    Console.WriteLine("The factorial of " + nbr + " is " + nbr!);
                
                Console.Write("\nContinue (y/n): ");
                choice = (Console.ReadLine());


            }
                Console.WriteLine("Bye");
        }
    }
}
