using ConsoleLibrary;

namespace Hangman
{
    internal class Program
    {
        static string[] images = new string[7];
        static void Main(string[] args)

        {
            MyConsole.PrintLine("Welcome to Hangman!\n");

            PopulateImages();

            for (int i = 0; i < images.Length; i++)
            {
                MyConsole.PrintLine($"Image{i}");
                MyConsole.PrintLine(images[i]);
                MyConsole.PrintLine("================");

            }






            MyConsole.PrintLine("\nBye");
        }

        private static string GetHangmanImage(int incorrectGuesses)
        {
            return images[incorrectGuesses];
        }
        public static void PopulateImages()
        {
            images[0] =
                """
                -----
                |   |
                |  
                | 
                |  
                |
                -------
                """;
            images[1] =
                """
                -----
                |   |
                |   0
                | 
                |  
                |
                -------
                """;
            images[2] =
                """
                -----
                |   |
                |   0
                |   |
                |  
                |
                -------
                """;
            images[3] =
                """
                -----
                |   |
                |   0
                |  /|
                |  
                |
                -------
                """;
            images[4] =
                """
                -----
                |   |
                |   0
                |  /|\
                |  
                |
                -------
                """;
            images[5] =
                """
                -----
                |   |
                |   0
                |  /|\
                |  / 
                |
                -------
                """;
            images[6] =
                """
                -----
                |   |
                |   0
                |  /|\
                |  / \
                |
                -------
                """;

        }

    }
}


