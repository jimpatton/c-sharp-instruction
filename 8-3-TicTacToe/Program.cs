namespace _8_3_TicTacToe
{
    internal class Program
    {
        static string boardBoarder = "+---+---+---+";
        static string[,] board = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");
            string choice = "y";
            while (choice.ToLower() == "y") 
            { 
                board = new string[,] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
                bool winner = false;
                while ( (!winner && !isBoardFull()))
                {
                    displayBoard();
                    Console.WriteLine("X's turn");
                    bool isValidMove = false;
                    while (!isValidMove) 
                    {
                        Console.Write("Pick a row. (1, 2, 3): ");
                        int row = int.Parse(Console.ReadLine())-1;
                        Console.Write("Pick a column. (1,2,3): ");
                        int col = int.Parse(Console.ReadLine()) - 1;
                        if (board[row, col] == " ")
                        {
                            board[row, col] = "X";
                            isValidMove = true;
                            displayBoard();
                        }
                        else 
                        {
                            Console.WriteLine("Spot already taken, please choose again.");
                        }
                        winner = checkWinner();
                        if (winner)
                        {
                            break;
                        }
                    }
                    if (winner || isBoardFull()) 
                    {
                        break;
                    }
                    

                    Console.WriteLine("O's turn");
                    isValidMove = false;
                    while (!isValidMove)
                    {
                        Console.Write("Pick a row. (1, 2, 3): ");
                        int row = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Pick a column. (1,2,3): ");
                        int col = int.Parse(Console.ReadLine()) - 1;
                        if (board[row, col] == " ")
                        {
                            board[row, col] = "O";
                            isValidMove = true;
                            displayBoard();
                        }
                        else
                        {
                            Console.WriteLine("Spot already taken, please choose again.");
                        }
                        winner = checkWinner();
                        if (winner)
                        {
                            break;
                        }
                    }
                    if (winner || isBoardFull())
                    {
                        break;
                    }    
                }
                if (!winner && isBoardFull())
                {
                    Console.WriteLine("It's a tie");
                }












                Console.Write("Another game? (y/n): ");
                choice = Console.ReadLine();
            }

        }

    



        public static bool isBoardFull() 
        { 
            for (int r = 0; r < board.GetLength(0); r++) 
            { 
                for (int c = 0; c < board.GetLength(1); c++) 
                { 
                    if (board[r, c] == " ")
                    {
                        return false;
                    }
                }
            }
            return true;        
        }

        public static void displayBoard()
        {
            string boardString = boardBoarder + "\n";
            for (int r = 0; r < board.GetLength(0); r++)
            {
                boardString += "|";
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    boardString += " " + (board[r, c] + " |");
                }
                boardString += "\n" + boardBoarder + "\n";
            }
            Console.WriteLine(boardString);
        }

        public static bool checkWinner()
        {
            bool winner = false;
            for (int r = 0;r < board.GetLength(0); r++)
            {
                if (board[r, 0].Trim() != "" && board[r, 0] == board[r, 1] && board[r, 1] == board[r, 2])
                {
                    winner = true;
                    Console.WriteLine("Winner is " + board[r, 0]);
                    return true;
                }                    
            }
            for (int c = 0; c < board.GetLength(1); c++)
            {
                if (board[0,c].Trim() != "" && board[0, c] == board[1, c] && board[1, c] == board[2, c])
                {
                    winner = true;
                    Console.WriteLine("Winner is " + board[0, c]);
                    return true;
                }
            }
            if (board[0,0].Trim() != "" && board[0,0] == board[1,1] && board[1,1] == board[2, 2])
            {
                winner = true;
                Console.WriteLine("Winner is " + board[0,0]);
                return true;
            }
            if (board[0, 2].Trim() != "" && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                winner = true;
                Console.WriteLine("Winner is " + board[0, 2]);
                return true;
            }
            return false;
        }






    }
}
