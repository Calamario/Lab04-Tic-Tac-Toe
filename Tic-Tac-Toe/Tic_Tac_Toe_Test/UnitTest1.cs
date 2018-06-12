using System;
using Xunit;
using Tic_Tac_Toe.Classes;

namespace Tic_Tac_Toe_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 7 })]
        [InlineData(new int[] { 1, 4, 5, 8 })]
        [InlineData(new int[] { 1, 5, 9, 6 })]
        public void TestWhoIsTheWinner1(int[] value)
        {
            //arrange
            Player player1 = new Player
            {
                Name = "bob",
                Marker = "X",
                MyTurn = false,
                GuessedNum = value
            };

            Game game = new Game();

            //act
            bool winner = game.DidSomeoneWin(player1);

            //assert
            Assert.True(winner);
        }

        [Fact]
        public void TestPlayersSwitchTrueToFalse()
        {
            //arrange
            Player player1 = new Player
            {
                Name = "bob",
                Marker = "X",
                MyTurn = true,
                GuessedNum = new int[] { 3, 4 }
            };

            Player player2 = new Player
            {
                Name = "bob2",
                Marker = "O",
                MyTurn = false,
                GuessedNum = new int[] { 1, 2 }
            };

            Game game = new Game();
            Player whoPlaying = player1;

            //act
            game.WhoseTurn(whoPlaying, player1, player2);

            //assert
            Assert.False(player1.MyTurn);
        }

        [Fact]
        public void TestPlayersSwitchFalseToTrue()
        {
            //arrange
            Player player1 = new Player
            {
                Name = "bob",
                Marker = "X",
                MyTurn = false,
                GuessedNum = new int[] { 3, 4 }
            };

            Player player2 = new Player
            {
                Name = "bob2",
                Marker = "O",
                MyTurn = false,
                GuessedNum = new int[] { 1, 2 }
            };

            Game game = new Game();
            Player whoPlaying = player1;

            //act
            game.WhoseTurn(whoPlaying, player1, player2);

            //assert
            Assert.True(player1.MyTurn);
        }

        [Theory]
        [InlineData(2, new int[] { 1, 3, 4 }, 3)]
        public void TestUserPositionGetsSaved(int num, int[] value, int index)
        {
            //arrange
            Player player1 = new Player
            {
                Name = "bob",
                Marker = "X",
                MyTurn = false,
                GuessedNum = value,
                PlayCounter = index
            };

            GameBoard gameBoard = new GameBoard();
            Game game = new Game();

            //act
            game.ShowMarkerOnBoard(num, gameBoard, player1);

            //assert
            Assert.Contains(2, );
        }
    }
}
