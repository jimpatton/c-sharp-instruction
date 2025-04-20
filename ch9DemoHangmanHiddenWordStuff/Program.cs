using ConsoleLibrary;

namespace ch9DemoHangmanHiddenWordStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Hangman Hidden Word Resolution!\n");

            //define theWord
            string theWord = "superstitious";
            MyConsole.PrintLine($"theWord = {theWord}");

            // generate hidden word (string == word.Length , all underscores
            string hiddenWord = "";
            //# of letters in theWord
            // hiddenWord -> same length as theWord but all underscores
            foreach (char word in theWord)
            {
                hiddenWord += "_";
            }
            MyConsole.PrintLine($"hiddenWord: {hiddenWord}");

            //Display the hiddenword with spaces separating underscores
            DisplayHiddenWord(hiddenWord);


            string letter = " ";
            bool winner = false;
            while (!winner)
            {
                //resolve correctly guessed letter
                //prompt user for a letter: string
                letter = MyConsole.PromptString("Guess a letter: ");
                //iterate over the word, and find any matches for letter
                char[] charsTheWord = theWord.ToCharArray();
                char[] charsHiddenWord = hiddenWord.ToCharArray();
                for (int i = 0; i < charsTheWord.Length; i++)
                {
                    char c = charsTheWord[i];

                    if (letter.Equals(c.ToString()))

                    {
                        MyConsole.PrintLine($"Letter found  {i}");
                        //resolve this character in hiddenWord
                        charsHiddenWord[i] = c;
                    }
                }
                hiddenWord = new string(charsHiddenWord);
                //if (hiddenWord == theWord)
                if (hiddenWord.IndexOf('_') == -1)
                {
                    winner = true;
                }
                DisplayHiddenWord(hiddenWord);
            }



            MyConsole.PrintLine("\nBye");
        }

        private static void DisplayHiddenWord(string hiddenWord)
        {
            MyConsole.PrintLine("Display hiddenWord");
            foreach (char c in hiddenWord)
            {
                MyConsole.Print(c + " ");
            }
            MyConsole.PrintLine();
        }
    }
}
