namespace Hangman.Model
{
    internal class HangmanWords
    {
        public string word { get; set; }
        public HangmanWords() { }
        public HangmanWords(string words)
        {
            this.word = word;
        }

        static List<string> words = new List<string>();

    }
}
