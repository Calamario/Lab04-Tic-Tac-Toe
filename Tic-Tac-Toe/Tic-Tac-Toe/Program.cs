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
            };

            Console.WriteLine("Player Two, please enter your name.");
            string p2 = Console.ReadLine();

            // Makes a second new player object with given name. 
            Player player2 = new Player
            {
                Name = p2,
                Marker = "O",
                MyTurn = false,
            };

            // Makes a board object to call its method ShowPlayArea.
            GameBoard gameBoard = new GameBoard();
            gameBoard.ShowPlayArea();

            Game game = new Game();

            int counter = 0;

            if (player1.MyTurn)
            {
                Console.WriteLine($"It is your turn, {player1.Name}. Please choose your position");
                Int32.TryParse(Console.ReadLine(), out int number);
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
                            }
                        }
                    }
                }
            }

            if (player1)
            {

            }
        }
    }
}
