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
                Console.Write("\nEnter length: ");
                int l = int.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                int w = int.Parse(Console.ReadLine());
                //area  = l*w
                //perimeter = 2*l + 2*w
                Console.WriteLine($"Area: { l* w}");
                Console.WriteLine($"Perimeter: {(2 * l) + (2 * w)}");

                Console.Write("\nContinue (y/n): ");
                choice = Console.ReadLine();
            }
                
            }
        }
}
