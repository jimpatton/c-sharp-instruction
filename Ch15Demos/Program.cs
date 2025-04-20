using ConsoleLibrary;

namespace Ch15Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Chapter 15 Interfaces!\n");
            List<Summarizable> things = new List<Summarizable>();
            //create some products
            Product p1 = new Product("c#", "Murach C#", 53.99m);
            Product p2 = new Product("mySql", "Murach MySql", 53.99m);
            Product p3 = new Product("andr", "Murach Android", 53.99m);
            things.Add(p1);
            things.Add(p2);
            things.Add(p3);


            //create some customers
            Customer c1 = new Customer("Adrian", "Johnson", "AJ0001");
            Customer c2 = new Customer("Celina", "Saksith", "CS0020");
            things.Add(c1);
            things.Add(c2);


            //we need a GetSummaryDetails() method on these classes
            //print a summary
            MyConsole.PrintLine("Summary");
            foreach (var item in things)
            {
                MyConsole.PrintLine($"{item.GetSummaryDetails()}");
            }

            // sort list of products
            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            MyConsole.PrintLine("=====All Products=====");
            foreach (Product p in products)
                MyConsole.PrintLine(p.GetSummaryDetails());

            //sort products
            products.Sort();
            MyConsole.PrintLine("=====All Products=====");
            foreach (Product p in products)
                MyConsole.PrintLine(p.GetSummaryDetails());


            MyConsole.PrintLine("\nBye");
        }
    }
}