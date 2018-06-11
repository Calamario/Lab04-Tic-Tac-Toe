using System;
using System.Linq;
using Tic_Tac_Toe.Classes;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
            Console.WriteLine("game done");
            Console.ReadLine();
        }

        static void PlayGame()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Player One, please enter your name.");
            string p1 = Console.ReadLine();

            // Makes new player object with given name.
            Player player1 = new Player
            {
                Name = p1,
                Marker = "X",
                MyTurn = true,
                GuessedNum = new int[5],
            };

            Console.WriteLine("Player Two, please enter your name.");
            string p2 = Console.ReadLine();

            // Makes a second new player object with given name. 
            Player player2 = new Player
            {
                Name = p2,
                Marker = "O",
                MyTurn = false,
                GuessedNum = new int[4],
            };

            // Makes a board object to call its method ShowPlayArea.
            GameBoard gameBoard = new GameBoard();
            gameBoard.ShowPlayArea();

            Game game = new Game();

            //Player whoPlaying = player1.MyTurn ? player1 : player2;

            int counter = 0;

            while (!player1.WinningPlayer)
            {
                int number = 0;
                while (number == 0)
                {
                    Console.WriteLine($"It is your turn, {player1.Name}. Please choose your position");
                    Int32.TryParse(Console.ReadLine(), out number);
                    if (!game.GuessedNum.Contains(number))
                    {
                        game.GuessedNum[counter] = number;
                        for (int i = 0; i < gameBoard.PlayArea.Length; i++)
                        {
                            for (int j = 0; j < gameBoard.PlayArea[i].Length; j++)
                            {
                                if (gameBoard.PlayArea[i][j] == number.ToString())
                                {
                                    gameBoard.PlayArea[i][j] = player1.Marker;
                                    player1.GuessedNum[player1.PlayCounter] = number;
                                    player1.PlayCounter++;
                                }
                            }
                        }
                    }
                }
                gameBoard.ShowPlayArea();

                if (player1.GuessedNum.Length >= 3)
                {
                    for (int i = 0; i < game.Winner.Length; i++)
                    {
                        int winScore = 0;
                        for (int j = 0; j < game.Winner[i].Length; j++)
                        {
                            if (player1.GuessedNum.Contains(game.Winner[i][j]))
                            {
                                winScore++;
                            }
                        }
                        if (winScore == 3)
                        {
                            player1.WinningPlayer = true;
                            break;
                        }
                    }
                }

            }

        }
    }
}
