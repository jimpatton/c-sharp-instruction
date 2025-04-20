using ConsoleLibrary;
namespace PigDiceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Pig Dice!\n");
            Random rand = new Random();
            //while choice
            string choice = "y";
            while (choice == "y")
            {
                //prompt for number of games: int
                int nbrGames = MyConsole.PromptInt("Number of games to play? ");
                //highScore = 0 
                int highScore = 0;
                int highScoreNumRolls = 0;
                //for i <= nbrGames
                for (int i = 0; i < nbrGames; i++)
                {
                    //play game
                    //roll: int = 0
                    int roll = 0;

                    //score: int =0
                    int score = 0;
                    // while roll != 1
                    int rollcount = 0;
                    while (roll != 1)
                    {
                        rollcount++;
                        //roll = rand(1-6)
                        roll = rand.Next(1, 7);
                        //if roll !=1
                        if (roll != 1)
                        {
                            //score += roll
                            score += roll;
                        }
                    }
                    //store score compare to highScore
                    //highScore = (score > highScore) ? score : highScore;
                    if (score> highScore)
                    {
                        highScore = score;
                        highScoreNumRolls = rollcount;


                    }
                      

                }

            //display highScore
            //prompt Again?
            MyConsole.PrintLine ("Highscore was " +  highScore);
                MyConsole.PrintLine("HighScore # of rolls = " + highScoreNumRolls);

                choice = MyConsole.PromptReqString("Again? (y/n): ", "y", "n");

            }


            MyConsole.PrintLine("\n Bye");
        }
    }
}
