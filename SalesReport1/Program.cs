using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;

namespace SalesReport1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("The Sales Report Application\n");
            //array for quarterly sales data -> in sean's demo
            decimal[,] sales = { {1540.0m, 2010.0m, 2450.0m, 1845.0m},
                                {1130.0m, 1168.0m, 1847.0m, 1491.0m},
                                {1580.0m, 2305.0m, 2710.0m, 1284.0m},
                                {1105.0m, 4102.0m, 2391.0m, 1576.0m}};
            decimal sum = 0.0m;
            // dump data to console by region and quarter
            PrintLine("Region\tQ1\t\tQ2\t\tQ3\t\tQ4");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Print((i + 1) + "\t");
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    Print(sales[i, j].ToString("c") + "\t");
                }
                PrintLine(" ");
            }
            PrintLine(" ");
            //add sales by region -> each row of array is diff region -> need sum of each line
            PrintLine("Sales by region:");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Print("Region " + (i + 1) + ": ");
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[i, j];
                }
                PrintLine(sum.ToString("c"));
            }
            PrintLine(" ");
            //add sales by quarter -> each column of array is diff quarter -> sum each column
            PrintLine("Sales by quarter:");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Print("Q" + (i + 1) + ": ");
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[j, i];
                }
                PrintLine(sum.ToString("c"));
            }
            PrintLine(" ");
            //total sales -> sum of all entries in array
            sum = 0.0m;
            PrintLine("Total Sales:");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[i, j];
                }
            }
            PrintLine(sum.ToString("c"));



            PrintLine("\nBye");
        }
        static void PrintLine(string msg)
        { Console.WriteLine(msg); }

        static void Print(string msg)
        {
            Console.Write(msg);
        }


    }
}
