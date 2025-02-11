using ContactList;

namespace LetterGrade
{
    public class Grade
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string F { get; set; }

        public Grade()
        {
        }

        public static void SetNumber(int number)
        {
        }

        public static int GetNumber(int prompt, int min, int max)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= min && result <= max)
                    {

                        isValid = true;
                    }
                    else
                    {
                        MyConsole.PrintLine("Error must be within range");
                    }

                }
                else
                {
                    MyConsole.PrintLine("Error must be an integer");
                }
            }
        }

        public string GetLetter()
        {
        }












    }
}
