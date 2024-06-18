using System;

public class TicTacToe
{
    public static void Main(string[] args)
    {
        // Tic Tac Toe   
        string[,] ticTacToeBoard = new string[3, 3]
        {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"},
        };
        bool exitGame = false;

        Console.WriteLine("Welcome to the Tic Tac Toe game");
        Console.WriteLine("Player 1: X");
        Console.WriteLine("Player 2: O");
        Console.WriteLine("To mark a position, choose the corresponding number.");

        while (!exitGame)
        {
            Console.Clear();
            bool gameEnded = false;

            while (!gameEnded)
            {
                PrintBoard(ticTacToeBoard);
                gameEnded = PlayerTurn(ticTacToeBoard, "Player 1", "X");
                if (gameEnded) break;
                Console.Clear();
                PrintBoard(ticTacToeBoard);
                gameEnded = PlayerTurn(ticTacToeBoard, "Player 2", "O");
                if (gameEnded) break;
                Console.Clear();
            }

            Console.WriteLine("Do you want to play again? (y/n)");
            string response = Console.ReadLine();
            if (response.ToLower() != "y")
            {
                exitGame = true;
            }
            else
            {
                ResetBoard(ticTacToeBoard);
            }
        }
    }

    static bool PlayerTurn(string[,] board, string player, string mark)
    {
        if (BoardFull(board))
        {
            Console.WriteLine("It's a draw!");
            return true;
        }

        int choice;
        bool validInput = false;
        while (!validInput)
        {
            Console.WriteLine($"{player}, choose a number: ");
            choice = PlayerChoice();
            validInput = MarkPosition(choice, board, mark);
        }

        if (PlayerWin(board))
        {
            PrintBoard(board);
            Console.WriteLine($"{player} wins, CONGRATULATIONS!");
            return true;
        }
        else if (BoardFull(board))
        {
            PrintBoard(board);
            Console.WriteLine("It's a draw!");
            return true;
        }
        return false;
    }

    static bool PlayerWin(string[,] board)
    {
        // Check rows
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                return true;
        }

        // Check columns
        for (int j = 0; j < board.GetLength(1); j++)
        {
            if (board[0, j] == board[1, j] && board[1, j] == board[2, j])
                return true;
        }

        // Check diagonals
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            return true;
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            return true;

        return false;
    }

    static void PrintBoard(string[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(" " + board[i, j] + " ");
                if (j < board.GetLength(1) - 1)
                    Console.Write("|");
            }
            Console.WriteLine();
            if (i < board.GetLength(0) - 1)
                Console.WriteLine("---+---+---");
        }
    }


    static int PlayerChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 9)
        {
            Console.WriteLine("You did not choose a valid option, please try again:");
        }
        return choice;
    }

    static bool MarkPosition(int num, string[,] board, string mark)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == num.ToString())
                {
                    board[i, j] = mark;
                    return true;
                }
            }
        }
        Console.WriteLine("That position is already taken. Try again.");
        return false;
    }

    static bool BoardFull(string[,] board)
    {
        foreach (string cell in board)
        {
            if (cell != "X" && cell != "O")
            {
                return false;
            }
        }
        return true;
    }

    static void ResetBoard(string[,] board)
    {
        int counter = 1;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = counter.ToString();
                counter++;
            }
        }
    }
}
