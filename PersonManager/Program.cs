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
                string firstName = MyConsole.PromptString("First name: ");
                string lastName = MyConsole.PromptString("Last name: ");
                Person p;
                if (choice == "c")
                {
                    //prompt for First Name, Last Name, Customer number
                    string customerNumber = MyConsole.PromptString("Customer number: ");
                    Customer c = new Customer(firstName, lastName, customerNumber);
                    p = c;




                }
                //else if e
                else
                {
                    //prompt for First Name, Last Name, Ssn

                    string ssn = MyConsole.PromptString("SSN: ");
                    Employee e = new Employee(firstName, lastName, ssn);
                    p = e;
                }
                //return name and ssn
                MyConsole.PrintLine("\nYou entered a new " + p.GetType().Name + ":");
                MyConsole.PrintLine(p.ToString());


                choice = MyConsole.PromptReqString("\nContinue? (y/n): ", "y", "n");
            }

            MyConsole.PrintLine("\nBye");
        }
    }
}
