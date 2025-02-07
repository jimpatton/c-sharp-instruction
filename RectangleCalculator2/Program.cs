namespace RectangleCalculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Rectangle area and perimiter");
            //while loop y or Y
            string choice = "y";
            while (choice == "y" || choice == "Y") {
                //allow decimals
                //prompt for length
                //prompt for width
                Print("\nEnter length: ");
                decimal length = Decimal.Parse(Console.ReadLine());
                Print("Enter width: ");
                decimal width = Decimal.Parse(Console.ReadLine());
                //biz logic
                decimal area = width * length;
                decimal perimeter = (2 * width) + (2 * length);
                PrintLine("Area: " + area);
                PrintLine("Perimeter: " +  perimeter);











                Print("\nContinue? (y/n): ");
                choice = Console.ReadLine();
            
            }


                







            Print("\nBye");
        }

        static void PrintLine(string msg)
            { Console.WriteLine(msg); }

        static void Print(string msg)
        { Console.Write(msg); }




    }
}
