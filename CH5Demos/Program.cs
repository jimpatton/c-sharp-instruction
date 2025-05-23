﻿namespace CH5Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 5 demos!");


            //coding control structures

            //pg 139 relational operators
            //boolean conditions are any conditions that are true/false (==, >=, <=, !=, etc.)
            int a = 5;
            int b = 5;
            Console.WriteLine(a == b);

            string name1 = "Bob";
            string name2 = "bob";
            Console.WriteLine(name1 == name2);

            //pg 141 Logical operators ( &&, ||, !)
            //is sky blue and is temperature above 74?
            int temp = 76;
            string skyColor = "blue";

            if (skyColor == "blue" && temp > 74)
            {
                Console.WriteLine("blue and above 74");
            }
            // && means both need to be true for result

            //pg 143 Nested If - traffic light
            //simple r, y, g
            // yellow light rules:
            // dist <20 yrds 
            // dist >= 20 < 30 speed up
            // dist >= 30 slow down
            string choice = "y";
            while (choice == "y")
            {
                Console.Write("light color? (r,y,g): ");
                string lightColor = Console.ReadLine();
                if (lightColor == "r")
                {
                    Console.WriteLine("STOP!");
                }
                else if (lightColor == "y")
                {
                    Console.Write("Distance to light in yards? ");
                    int dist = Convert.ToInt32(Console.ReadLine());
                    string msg = "";
                    if (dist < 20)
                    {
                        msg = "Go!";
                    }
                    else if (dist < 30)
                    {
                        msg = "Go! Speed up!";
                    }
                    else
                    {
                        msg = "slow down";
                    }
                    Console.WriteLine(msg);
                }

                else if (lightColor == "g")
                {
                    Console.WriteLine("Go!");
                }
                else
                {
                    Console.WriteLine("Invalid light color: " + lightColor);
                }

                Console.Write("continue?  ");
                choice = Console.ReadLine();
            }


            //switch statement
            //CRUD operations
            Console.WriteLine("Movie Table - which action to perform?");
            string action = "";
            while(action != "exit")
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("===========");
                Console.WriteLine("Get : Get All Movies");
                Console.WriteLine("GID : Get Movie by ID");
                Console.WriteLine("Add : Add a Movie");
                Console.WriteLine("Upd : Update a Movie");
                Console.WriteLine("Del : Delete a Movie");
                Console.WriteLine("Exit : Exit");
                Console.Write("Action:");
                action = Console.ReadLine().ToLower();

                switch (action) {
                    case "get":
                        Console.WriteLine("Get was selected");
                        break;
                    case "gid":
                        Console.WriteLine("GID was selected");
                        break;
                    case "add":
                        Console.WriteLine("Add was selected");
                        break;
                    case "upt":
                        Console.WriteLine("Upt was selected");
                        break;
                    case "del":
                        Console.WriteLine("Del was selected");
                        break;
                    case "exit":
                        Console.WriteLine("Exit was selected");
                        break;
                    default:
                        Console.WriteLine("Invalid selection - "+ action);
                        break;
        
                }

            }

            // pg 147 case w/ arrow operators
            // customer type: discountPct
            //"R" = 10% discount
            //"C" = 20%
            //else - 0%
            string custType = "R";
            decimal discPct = 0.0m;

            discPct = custType switch
            {
                "R" => .1m,
                "C" => .2m,
                _ => .0m
            };
            Console.WriteLine("discPct = " + discPct);

            //pg 151 conditional expression/ ternary operator
            // day of week: weekday/weekend conversion
            // day is 1-5: weekday, 6 or 7: weekend
            int dow = 4;
            //string msg = "";
            //if (dow <= 5)
            //{
            //    msg = "weekday";
            //}
            //else
            //{
            //    msg = "weekend";
            //}
            string msg1 = (dow <= 5) ? "weekday": "weekend";
            Console.WriteLine(msg1);

            //pg 155
            Console.WriteLine(msg1);

            // For Loops
            Console.WriteLine("=================== FOR LOOPS ====================");
            // p. 155
            // while loop, counter and sum
            int i = 0;
            int sum = 0;
            // sum all values from 0 to 10
            while (i <= 10)
            {
                sum += i;
                //sum = sum + i;
                i++;
            }
            Console.WriteLine("sum = " + sum);

            // while loop for data validation
            bool success = false;
            int month = 0;
            // prompt user for month until they enter a valid month
            while (!success)
            {
                Console.WriteLine("Enter month #: ");
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Invalid month # try again.");
                }
                else
                {
                    success = true;
                }
            }
            Console.WriteLine("Month entered: " + month);

            // while true
            // loop until even number is entered
            while (true)
            {
                Console.WriteLine("In a while true loop...");
                Console.Write("Enter an even #: ");
                int nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr % 2 == 0)
                {
                    break;
                }
            }

            // p. 157 for loops
            // sum 0 to 10 w/ for loop
            sum = 0;
            string numberStr = "";
            for (i = 0; i <= 10; i++)
            {
                sum += i;
                numberStr += i + " ";
            }
            Console.WriteLine(numberStr);
            Console.WriteLine("sum = " + sum);

            // count 0 to 100 by 5
            for (i = 0; i <= 100; i += 5)
            {
                Console.WriteLine("i: " + i);
            }

            // count 99 to 0 by 3
            for (i = 99; i >= 0; i -= 3)
            {
                Console.WriteLine("i: " + i);
            }


            Console.WriteLine("Bye");


        }
    }
}
