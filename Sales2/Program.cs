namespace Sales2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Sales Report");
            //array for sales data from sean's demo
            decimal[,] sales = { {1540.0m, 2010.0m, 2450.0m, 1845.0m},
                                {1130.0m, 1168.0m, 1847.0m, 1491.0m},
                                {1580.0m, 2305.0m, 2710.0m, 1284.0m},
                                {1105.0m, 4102.0m, 2391.0m, 1576.0m}};
            decimal sum = 0.0m;
            PrintLine("\nRegion\tQ1\t\tQ2\t\tQ3\t\tQ4");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Console.Write((i + 1) + "\t");
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    Console.Write(sales[i, j].ToString("c") + "\t");
                }
                PrintLine(" ");
            }
            //add sales by region -> each row of array is diff region -> need sum of each line
            PrintLine("\nSales by Region");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Console.Write(("Region " + (i + 1) + "\t"));
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[i, j];
                }
                PrintLine(sum.ToString("c"));
            }
            PrintLine("\nSales by Quarter");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Console.Write(("Quarter " + (i + 1) + "\t"));
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[j, i];
                }
                PrintLine(sum.ToString("c"));
            }
            //total sales -> sum of all entries in array
            sum = 0.0m;
            Console.Write("\nTotal sales: ");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[i, j];
                }
            }
            Console.Write(sum.ToString("c"));



        }
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
