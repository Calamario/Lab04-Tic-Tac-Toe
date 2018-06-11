using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe.Classes
{
    class Player
    {
        public string Name { get; set; }

        public string Marker { get; set; }

        public bool MyTurn { get; set; }

        public int PlayCounter { get; set; } = 0;

        public int[] GuessedNum { get; set; }

        public bool WinningPlayer { get; set; } = false;
    }
}
