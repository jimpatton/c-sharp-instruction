namespace FactorialCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator ");
            //continue with y or Y
            //enter an integer: long
            // -0 < nbr < 10
            // compute the factorial with for loop : long
            //for i = 1, i <= nbr, i++  --> factorial = factorial * i


            string choice = "y";
            while (choice == "y")
            {

                long nbr = GetLong("\nEnter and integer that's greater than 0 and less than 1000: ", 1, 1000);
                long theFactorial = 1;
                for (int i = 1; i<= nbr ; i++)
                {
                    //theFactorial = theFactorial * i;
                    theFactorial *= i;
                }
                Console.WriteLine("The factorial of  " +nbr + " is " + theFactorial + ".");

                Console.Write("\nContinue (y/n): ");
                choice = (Console.ReadLine()).ToLower();


            }
            Console.WriteLine("Bye");
        }

        private static long GetLong(string prompt, long min, long max)
        {
            long result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                if (!long.TryParse(Console.ReadLine(), out result))
                {

                    Console.WriteLine("Error - invalid number. Try again.");
                    continue;
                }
                if (result < min || result > max)
                {
                    Console.WriteLine("Error - input must be within range" + min + " - " + max + "Try again.");
                }
                else
                {
                    isValid = true;

                }
            }

            return result;
        }
    }
}
