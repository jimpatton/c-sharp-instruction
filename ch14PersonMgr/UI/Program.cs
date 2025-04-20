using ch14PersonMgr.Model;
using ConsoleLibrary;

namespace ch14PersonMgr.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Person Manager\n");

            //while choice =="y"
            string choice = "y";
            while (choice == "y")
            {
                //prompt personType: string (c or e)
                string personType = MyConsole.PromptReqString("\nCreate customer or employee (c/e): ", "c", "e");
                //prompt firstName: string
                string firstName = MyConsole.PromptString("First Name: ");
                //Prompt lastName: string
                string lasttName = MyConsole.PromptString("Last Name: ");
                Person p;
                if (personType == "c")
                {
                    string customerNumber = MyConsole.PromptString("Customer number: ");
                    Customer c = new Customer(firstName, lasttName, customerNumber);
                    p = c;
                }
                else
                {
                    string ssn = MyConsole.PromptString("SSN: ");
                        Employee e = new Employee(firstName, lasttName, ssn);
                    p = e;
                }
                MyConsole.PrintLine("");
                MyConsole.PrintLine("You entered a new " + p.GetType().Name + ":");
                MyConsole.PrintLine(p.ToString());

                //prompt for customer (customerNumber:string) or employee (ssn: string) info
                // print person summary







                choice = MyConsole.PromptReqString("Continue? (y/n): ", "y", "n");
            }









            MyConsole.PrintLine("\nBye");
        }
    }
}
