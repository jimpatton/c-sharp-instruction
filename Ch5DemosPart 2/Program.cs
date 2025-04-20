namespace Chapt5DemosPart_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 5 demos part 2");

            //pg 155  While loops
            //while loop, counter and sum
            int i = 0;
            int sum = 0;
            // sum all values from0 to 10
            while (i <= 10) {
                sum += i;
                i++;
            }
            Console.WriteLine("sum = " + sum);

            //while loop for data validation
            bool success = false;
            int month = 0;
            //prompt user for month until they entera valid month
            while (!success)
            {
                Console.Write("Enter month number: ");
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Invalid month number, try again:");
                }
                else
                {
                    success = true;
                }
            }
            Console.WriteLine("Month entered: "+month);

            // while true
            // loop until even number is entered
            while (true)
            {
                Console.WriteLine("In a while true loop....");
                Console.Write("Enter and even number: ");
                int nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr % 2 == 0)
                {
                    break;
                }
            }

            //pg 157  for loops
            //sum 0 to 10 with a for loop// don't have to declare int as it was done above. Can reset value
            sum = 0;
            string numberStr = "";
            for (i = 0; i <= 10; i++)
            {
                sum +=i;
                numberStr += i + " ";
            }
            Console.WriteLine(numberStr);
            Console.WriteLine("sum = " + sum);

            //count 0 to 100 by 5
            for(i = 0; i<=100; i += 5)
            {
                Console.WriteLine("i: " + i);
            }

            // count 99 to 0 by 3
            for(i =99; i>=0; i-=3)
            {
                Console.WriteLine("i: " + i);
            }






            Console.WriteLine("Bye");
        }
    }
}
