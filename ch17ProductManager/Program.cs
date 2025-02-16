using ConsoleLibrary;

namespace ch17ProductManager
{
    internal class Program
    {
        static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to product manager!\n");

            //program that provides CRUD features for products
            //products stored in text file named products.txt

            //load products from file
            products = ProductDB.GetProducts();

            int command = 9;
            while (command != 0)
            {
                DisplayMenu();
                command = MyConsole.PromptInt("Command: ");
                switch (command)
                {
                    case 1:
                        ListProducts();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 0:
                        break;
                    default:
                        MyConsole.PrintLine("Invalid Command. Try again.");
                        break;
                }
            }






            MyConsole.PrintLine("\nBye");
        }

        private static void DeleteProduct()
        {
            MyConsole.PrintLine("\nDelete Products");
            MyConsole.PrintLine("===================");
            string code = MyConsole.PromptString("Product Code to delete: ");
            //loop through products
            Product found = null;
            foreach (Product p in products)
            {
                if (p.Code == code)
                {
                    found = p;
                    break;
                }
            }
            if (found != null)
            {
                products.Remove(found);
                ProductDB.SaveProducts(products);
                MyConsole.PrintLine("Product removed.\n");
            }
            else
            {
                MyConsole.PrintLine("\nProduct not found");
            }

            //find product whose code matches code to delete
            //remove that product from list



            //save products




        }

        private static void AddProduct()
        {
            MyConsole.PrintLine("\nAdd Products");
            MyConsole.PrintLine("================");
            string code = MyConsole.PromptString("Code: ");
            string desc = MyConsole.PromptString("Description: ");
            decimal price = MyConsole.PromptDecimal("Price: ");
            Product p = new Product(code, desc, price);
            products.Add(p);
            ProductDB.SaveProducts(products);
            MyConsole.PrintLine("Product added.\n");
        }

        private static void ListProducts()
        {
            MyConsole.PrintLine("\nList Products");
            MyConsole.PrintLine("=================");
            //check to see if list is not empty
            foreach (Product p in products)
            {
                MyConsole.PrintLine(p.ToString());
            }
        }

        static void DisplayMenu()
        {
            MyConsole.PrintLine("\nCOMMAND MENU:");
            MyConsole.PrintLine("1) List Products");
            MyConsole.PrintLine("2) Add Product");
            MyConsole.PrintLine("3) Delete Product");
            MyConsole.PrintLine("0) Exit");
        }
    }
}
