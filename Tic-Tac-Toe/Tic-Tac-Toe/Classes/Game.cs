using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe.Classes
{
    class Game
    {
        public int[] GuessedNum = new int[9];

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
    }
}
