using System;
using Xunit;
using Tic_Tac_Toe.Classes;

namespace Tic_Tac_Toe_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 7 })]
        [InlineData(new int[] { 1, 5, 9, 6 })]
        public void TestWhoIsTheWinner(int[] value)
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
        [Theory]
        [InlineData(new int[] { 1, 4, 5, 8 })]
        [InlineData(new int[] { 1, 5, 7, 6 })]
        public void TestMakeSureNotWinner(int[] value)
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
            Assert.False(winner);
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
        [InlineData(2, new int[] { 0 })]
        [InlineData(9, new int[] { 0 })]
        public void TestUserPositionGetsSaved(int num, int[] value)
        {
            //arrange
            Player player1 = new Player
            {
                Name = "bob",
                Marker = "X",
                MyTurn = false,
                GuessedNum = value,
            };

            GameBoard gameBoard = new GameBoard();
            Game game = new Game();

            //act
            game.ShowMarkerOnBoard(num, gameBoard, player1);

            //assert
            Assert.Contains(num, player1.GuessedNum);
        }

        [Fact]
        public void TestGameBoardDisplayToConsole()
        {
            //arrange
            GameBoard gameBoard = new GameBoard();

            //act
            string rtnstring = gameBoard.ShowPlayArea();

            //assert
            Assert.Equal("Game Board Displayed", rtnstring);

        }
    }
}
