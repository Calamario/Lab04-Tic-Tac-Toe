using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe.Classes
{
    public class Game
    {
        /// <summary>
        /// Main logic of the game. Starts and ends the game.
        /// </summary>
        /// <param name="player1"> A Player Object for player one </param>
        /// <param name="player2"> A Player Object for player two </param>
        /// <param name="gameBoard"> The game board object </param>
        public void GameLogic(Player player1, Player player2, GameBoard gameBoard)
        {
            int counter = 0;

            Player whoPlaying = player1;

            do
            {
                whoPlaying = WhoseTurn(whoPlaying, player1, player2);
                int number = 0;
                while (number == 0)
                {
                    Console.WriteLine($"It is your turn, {whoPlaying.Name}. Please choose your position");
                    Int32.TryParse(Console.ReadLine(), out number);
                    if (number > 0 && number < 10 && !player1.GuessedNum.Contains(number) && !player2.GuessedNum.Contains(number))
                        ShowMarkerOnBoard(number, gameBoard, whoPlaying);
                    else
                        number = 0;
                }
                gameBoard.ShowPlayArea();
                whoPlaying.WinningPlayer = DidSomeoneWin(whoPlaying);

                counter++;

            } while (!whoPlaying.WinningPlayer && counter < 9);

            if (!player1.WinningPlayer && !player2.WinningPlayer)
            {
                Console.WriteLine("Tie Game!");
            }
        }

        /// <summary>
        /// All the possible winning conditions
        /// </summary>
        public int[][] Winner = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9},

            new int[] {1, 4, 7},
            new int[] {2, 5, 8},
            new int[] {3, 6, 9},

            new int[] {1, 5, 9},
            new int[] {3, 5, 7}
        };

        /// <summary>
        /// Toggles between the two players. If player one has gone, then lets player two go and vice versa
        /// </summary>
        /// <param name="whoPlaying"> Player refernce on Who is playing </param>
        /// <param name="p1"> player 1 object </param>
        /// <param name="p2"> player 2 object </param>
        /// <returns></returns>
        public Player WhoseTurn(Player whoPlaying, Player p1, Player p2)
        {
            whoPlaying = p1.MyTurn ? p1 : p2;
            p1.MyTurn = !p1.MyTurn ? true : false;
            return whoPlaying;
        }

        /// <summary>
        /// After taking the user's position, Saves that into the player's property(an array) and updates the game baord
        /// </summary>
        /// <param name="number"> the user's valid position </param>
        /// <param name="gameBoard"> gameboard object </param>
        /// <param name="whoPlaying"> reference to who is currently playing </param>
        public void ShowMarkerOnBoard( int number, GameBoard gameBoard, Player whoPlaying)
        {
            whoPlaying.GuessedNum[whoPlaying.PlayCounter] = number;
            for (int i = 0; i < gameBoard.PlayArea.Length; i++)
            {
                for (int j = 0; j < gameBoard.PlayArea[i].Length; j++)
                {
                    if (gameBoard.PlayArea[i][j] == number.ToString())
                    {
                        gameBoard.PlayArea[i][j] = whoPlaying.Marker;
                        whoPlaying.GuessedNum[whoPlaying.PlayCounter] = number;
                        whoPlaying.PlayCounter++;
                    }
                }
            }
        }

        /// <summary>
        /// Method to checks if someone has won.
        /// </summary>
        /// <param name="whoPlaying">The reference to who is playing </param>
        /// <returns> a boolean </returns>
        public bool DidSomeoneWin(Player whoPlaying)
        {
            if (whoPlaying.GuessedNum.Length >= 3)
            {
                for (int i = 0; i < Winner.Length; i++)
                {
                    int winScore = 0;
                    for (int j = 0; j < Winner[i].Length; j++)
                    {
                        if (whoPlaying.GuessedNum.Contains(Winner[i][j]))
                        {
                            winScore++;
                        }
                    }
                    if (winScore == 3)
                    {
                        Console.WriteLine($"Congratulations, {whoPlaying.Name}!! \nYOU ARE ARE TRUE CHAMPION");
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
