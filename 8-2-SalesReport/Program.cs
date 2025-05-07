namespace _8_2_SalesReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sales Report");
            double[,] sales = { 
                { 1540.0, 2010.0, 2450.0, 1845.0 }, 
                { 1130.0, 1168.0, 1847.0, 1491.0 },
                { 1580.0, 2305.0, 2710.0, 1284.0 }, 
                { 1105.0, 4102.0, 2391.0, 1576.0 } 
            };
            double sum = 0;
            Console.WriteLine("\nRegion\t\tQ1\t\tQ2\t\tQ3\t\tQ4");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Console.Write($"Region {i + 1}\t");
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    Console.Write($"{sales[i,j].ToString("c"),-10}\t");
                }
                Console.WriteLine();
            }
            //add sales by region
            Console.WriteLine("\nSales by Region");
            for(int i = 0;i < sales.GetLength(0); i++)
            {
                //Console.Write($"Region {(i + 1)}\t");
                sum = 0.0;
                for (int j = 0;j < sales.GetLength(1); j++)
                {
                    sum += sales[i,j];
                }
                Console.WriteLine($"Region {i + 1}\t{sum.ToString("C")}");
            }
            //add sales by quarter
            Console.WriteLine("\nSales by Quarter");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                sum = 0.0;
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[j, i];
                }
                Console.WriteLine($"Quarter {i + 1}\t{sum.ToString("C")}");
            }
            //total sales
            
            sum = 0.0;            
            for (int i = 0; i < sales.GetLength(0); i++) 
            { 
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[i,j];
                }
            }
            Console.WriteLine($"\nTotal sales: {sum.ToString("c")}");
        }
    }
}
