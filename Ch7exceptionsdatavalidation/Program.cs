using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Chapt7exceptionsdatavalidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chapter 7 Exceptions and Data Validation");

            int nbr1 = 0;
            while (true)
            {
                Console.Write("Enter and integer: ");
                if (!Int32.TryParse(Console.ReadLine(), out nbr1))
                {
                    Console.WriteLine("error enter whole number");
                }
                else
                {
                    break;
                }
            }



                Console.WriteLine("You entered : " + nbr1);


                Console.WriteLine("Bye");


            }
        }
    }
