﻿
using chap14Inheritance;
using ConsoleLibrary;

namespace ch14Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Inheritance!\n");

            string name = "Bob";
            MyConsole.PrintLine(name.ToString());
            MyConsole.PrintLine(name);
            int nbr1 = 11;
            MyConsole.PrintLine(nbr1 + nbr1.ToString());

            Movie m1 = new Movie(1, "testmovie", 2000, "PG", "test director");
            MyConsole.PrintLine(m1.ToString());
            Movie m2 = new Movie(2, "actionmovie", 2014, "R", "test director");
            MyConsole.PrintLine(m2.ToString());

            int nbr2 = 11;
            MyConsole.PrintLine($"nbr1 == nbr2? {nbr1 == nbr2}");
            MyConsole.PrintLine($"m1 == m2? {m1==m2}");
            Movie m3 = new Movie(2, "actionmovie", 2014, "R", "test director");
            MyConsole.PrintLine($"m2 == m3? {m2==m3}");

            string str1 = "abc";
            string str2 = "abc";
            MyConsole.PrintLine($"str1 == str2? {str1==str2}");

            Movie m4 = m3;
            MyConsole.PrintLine($"m4 == m3? {m4 == m3}");

            //create instances of Product
            //Product p1 = new Product("c#", "Murach's C#", 54.99m);
            //MyConsole.PrintLine(p1.GetDisplayText("|"));

            Book b1 = new Book("java", "Murach's Java", 49.99m, "Joel Murach");
            MyConsole.PrintLine(b1.GetDisplayText("|"));

            Software s1 = new Software("vs", "Visual Studio", 0.00m, "8.0");
            MyConsole.PrintLine(s1.GetDisplayText("|"));

            Book b2 = new Book("c#", "Murach's C#", 54.99m, "Mike Murach");
            Book b3 = new Book("andr", "Murach's Android", 59.99m, "Joel Murach");

            List<Product> products = new List<Product>();
            products.Add(b1);
            products.Add(b2);
            products.Add(s1);
            products.Add(b3);


            MyConsole.PrintLine("-----------Products Summary ---------");
            foreach(Product p in products)
            {
                MyConsole.PrintLine(p.GetDisplayText("|"));
            }



            MyConsole.PrintLine("\nBye");
        }
    }
}
