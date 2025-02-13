using System;
using ConsoleLibrary;

namespace PersonManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Person Manager\n");
            //while: continue y/n
            string choice = "y";
            while (choice == "y")
            {

                //prompt for create customer or employee c/e PromptReqString
                choice = MyConsole.PromptReqString("Create customer or employee? (c/e): ", "c", "e");
                //if c
                if (choice == "c")
                {
                    //prompt for First Name, Last Name, Customer number
                    MyConsole.PromptString("First name: ");
                    MyConsole.PromptString("Last name: ");
                    MyConsole.PromptString("Customer number: ");
                    
                    //return name and customer number
                    MyConsole.PrintLine($"You entered a new Customer:\nName: \nCustomer Number: ");
                }
                //else if e
                else 
                {
                    //prompt for First Name, Last Name, Ssn
                    MyConsole.PromptString("First name: ");
                    MyConsole.PromptString("Last name: ");
                    MyConsole.PromptString("SSN: ");
                    //return name and ssn
                    MyConsole.PrintLine($"You entered a new Employee:\nName: \nSSN: ");
                }



                choice = MyConsole.PromptReqString("\nContinue? (y/n): ", "y", "n");
            }

            MyConsole.PrintLine("\nBye");
        }
    }
}
