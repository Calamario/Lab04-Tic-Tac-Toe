using System;
using System.Linq;
using Tic_Tac_Toe.Classes;

namespace Tic_Tac_Toe
{
    public   class Program
    {
        static void Main(string[] args)
        {
            bool continueGame = true;
            while (continueGame)
            {
                PlayGame();
                continueGame = PlayAgain();
            }
            Console.WriteLine("GG. Goodbbye.");
            Console.ReadLine();
        }

        /// <summary>
        /// To start the game. Has both players input their names.
        /// </summary>
        static void PlayGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Player one, please enter your name.");
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
            GameBoard gameBoard = new GameBoard { };
            gameBoard.ShowPlayArea();

            // Creates a new instance of Game class
            Game game = new Game();

            game.GameLogic(player1, player2, gameBoard);
        }

        /// <summary>
        /// Runs after the game has completed to ask the users if they want to play again or quit
        /// </summary>
        /// <returns> Boolean to continue or quit </returns>
        static bool PlayAgain()
        {
            Console.WriteLine("Would you like to start a new game?");
            int number = 0;
            while (number == 0)
            {
                Console.WriteLine("1) Play Again");
                Console.WriteLine("2) Exit");
                Int32.TryParse(Console.ReadLine(), out number);
                if (number == 2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
