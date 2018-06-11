using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe.Classes
{
    class GameBoard
    {
        public string[][] PlayArea = new string[][]
        {
            new string[] { "1", "2", "3" },
            new string[] { "4", "5", "6" },
            new string[] { "7", "8", "9" }
        };

        public void ShowPlayArea()
        {
            for (int i = 0; i < PlayArea.Length; i++)
            {
                foreach (string j in PlayArea[i])
                {
                    Console.Write($"|{j}|");
                }
                Console.WriteLine();
            }
        }
    }
}
