﻿namespace chap12Demos
{
    public class MyConsole
    {
       public static int PromptInt(string prompt)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Print(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    isValid = true;
                }
                else
                {
                    PrintLine("error invalid int");
                }
            }






            return result;
        }

        public static string PromptString(string prompt)
        {
            Print(prompt);
            return Console.ReadLine();
        }

       public static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Print(string msg)
        {
            Console.Write(msg);
        }
    }
}
