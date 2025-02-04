namespace RectangleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rectangle Calculator App!");

            string choice = "y";
            //upper or lower case y is OK use an "or" like this (||) you could also use
            //while(choice.toLower() == "y")
            while (choice == "y" || choice == "Y")
            {

                // get input - length: double, width: double
                Console.Write("\nEnter length: ");
                decimal length = Decimal.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                decimal width = Decimal.Parse(Console.ReadLine());

                // do biz logic
                // - calc area: length * width
                // - calc perimeter: 2 * length + 2 * width
                decimal area = length * width;
                decimal perimeter = 2 * length + 2 * width;

                // display output
                // - output area and perimeter
                Console.WriteLine("Area:\n" + area);
                Console.WriteLine("Perimeter:" + perimeter);

                Console.Write("\nContinue? (y or n) ");
                choice = Console.ReadLine();
            }

        }
    
    }
}
