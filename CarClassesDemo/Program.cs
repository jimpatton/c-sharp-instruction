using ConsoleLibrary;

namespace CarClassesDemo
{
    internal class Program
    {
        //create list for cars
        static List<Car> Cars = new List<Car>();
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Car Classes Demo!\n");
            //create Class for Car
            //create 3 instances of Car
            Car newCar = new Car(1,"Jeep", "Wrangler", 2020);
            //newCar.Id = 1;
            //newCar.Make = "Jeep";
            //newCar.Model = "Wrangler";
            //newCar.Year = 2020;
            Cars.Add(newCar);
            string choice = "y";
            while (choice == "y")
            {
                int id = MyConsole.PromptInt("ID: ");
                string make = MyConsole.PromptString("Make: ");
                string model = MyConsole.PromptString("Model: ");
                int year = MyConsole.PromptInt("Year: ");
                newCar = new Car(id, make, model, year);
                Cars.Add(newCar);

                choice = MyConsole.PromptString("Add another car? (yes/no): ");
            }
            //foreach loop
            foreach (Car car in Cars)
            {
                MyConsole.PrintLine(car.ToString());
            }

            //print details of cars

            MyConsole.PrintLine("\nBye");
        }
    }
}
