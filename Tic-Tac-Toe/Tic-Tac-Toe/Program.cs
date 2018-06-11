using System;
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

            if (player1.MyTurn)
            {

            }
        }
    }
}
