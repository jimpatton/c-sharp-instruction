using System.Collections.Specialized;
using System.ComponentModel;
using ConsoleLibrary;

namespace ArrayVsListVsArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Array vs List vs ArrayList\n");

            //process a set of numbers 1-10 using Arrays
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //loop through numbers printing to the console
            string outputStr = "";
            int sum = 0;
            foreach (int i in numbers)
            {
                outputStr += i.ToString() + " ";
                sum += i;
            }
            MyConsole.PrintLine(outputStr);
            MyConsole.PrintLine($"sum= {sum}");

            //add 11 through 15
            numbers = numbers.Append(11).ToArray();

            Array.ForEach(numbers, i=> {MyConsole.Print(i.ToString() + " "); });
            MyConsole.PrintLine();

            //change an element within an array: at position 5, multiply value by 10?
            numbers[5] = numbers[5] * 10;
            Array.ForEach(numbers, i => { MyConsole.Print(i.ToString() + " "); });

            //list
            MyConsole.PrintLine("\n====List====");
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            sum = 0;
            string numsStr = "";
            foreach (int i in nums) {
                numsStr+= $"{i}, ";
                sum += i;   
            }
            numsStr = numsStr.Substring(0, numsStr.Length - 2);
            MyConsole.PrintLine(numsStr);
            MyConsole.PrintLine($"\nsum = {sum}");

            //add 11 to the end
            nums.Add(11);
            nums.ForEach(nums => { MyConsole.Print($"{nums}, "); });

            MyConsole.PrintLine();
            //change an element within an array: at position 5, multiply value by 10?
            nums[5] = nums[5] * 10;
            nums.ForEach(nums => { MyConsole.Print($"{nums}, "); });
            MyConsole.PrintLine();

            //remove an element from a list - position 5
            nums.RemoveAt(5);
            nums.ForEach(nums => { MyConsole.Print($"{nums}, "); });
            MyConsole.PrintLine();


            //create some products
            Product p1 = new Product(1, "c#", "Murach's C#", 54.99m);
            Product p2 = new Product(2, "java", "Murach's Java", 55.99m);
            Product p3 = new Product(3, "mysql", "Murach's SQL", 45.99m);

            List<Product> products = new List<Product>() { p1, p2, p3};
            // loop through the list of products and print product details
            //foreach (Product p in products)
            //{
            //    MyConsole.PrintLine(p.ToString());
            //}
            products.ForEach(p => MyConsole.PrintLine(p.ToString()));

            //CRUD on a list
            //-Adding an element to the list
            Product p4 = new Product(99, "test", "TestBook", 11.11m);
            products.Add(p4);
            products.ForEach(p => MyConsole.PrintLine(p.ToString()));
            // - Get an element from the list
            Product p = null;
            foreach (Product prod in products)
            {
                if (prod.ProductId == 99)
                {
                    p = prod;
                    break;
                }
            }
            MyConsole.PrintLine($"Product found! :{p.ToString()}");

            //-Update and element from the list - update the code to test for id for 99
            foreach (Product prod in products)
            {
                if (prod.ProductId == 99)
                {
                    prod.Code = "TEST";
                    break;
                }
            }
            products.ForEach(p => MyConsole.PrintLine(p.ToString()));

            //-Delete an element from the list - id 99
            foreach (Product prod in products)
            {
                if (prod.ProductId == 99)
                {
                    products.Remove(prod);
                    break;
                }
            }
            products.ForEach(p => MyConsole.PrintLine(p.ToString()));





            MyConsole.PrintLine("\nBye");
        }
    }
}
