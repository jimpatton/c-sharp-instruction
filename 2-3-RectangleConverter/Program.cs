namespace _2_3_RectangleConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rectangle Area and Perimeter Calculator");
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                //Console.Write("\nEnter length: ");
                //int l = int.Parse(Console.ReadLine());
                double l = GetPositiveDouble("/nEnter length: ");
                //Console.Write("Enter width: ");
                //int w = int.Parse(Console.ReadLine());
                double w = GetPositiveDouble("Enter width: ");
                double area = l * w;
                double perimeter = 2 * l + 2 * w;
                Console.WriteLine($"Area: {area:F2}");
                Console.WriteLine($"Perimeter: {perimeter:F2}");

                Console.Write("\nContinue (y/n): ");
                choice = Console.ReadLine();
            }


        }

        public static double GetPositiveDouble (String prompt)
        {
            double num = -1;
            while (true) {
                Console.Write(prompt);
                string input = Console.ReadLine().Trim();
                try
                {
                    num = double.Parse(input);
                    if (num > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error! Please enter a positive number.");
                    }
                }
                catch (FormatException) {
                    Console.WriteLine("Error! Please enter a numeric value");
                }

            }
            return num;

        }
    }
}
