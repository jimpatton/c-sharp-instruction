namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            //convert temp from Fahrenheit to Celcius: c= (f-32) * 5/9
            //continue  "y" or "Y"

            string choice = "y";
            while (choice == "y" || choice == "Y")
            {
                Console.Write("Enter degrees in Fahrenheit: ");
                double fDegrees = Double.Parse(Console.ReadLine());
                double cDegrees = ((fDegrees - 32) * 5 / 9);
                cDegrees = Math.Round(cDegrees,2);
                Console.WriteLine("Degrees in Celcius: "+ cDegrees);
                Console.Write("\nContinue? (y or n) ");
                choice = Console.ReadLine();
                
               
            }






            Console.WriteLine("Bye");
        }
    }
}
