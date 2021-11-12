using System;
using System.Collections.Generic;
using System.Linq;
using Puissance4;
using NUnit.Framework;

namespace Game.Tests
{
    public class CheckWinTest
    {
        [Test]
        public void checkWinRow()
        {
            Board board = new Board();
            Player player1 = new Player(1);
            Player player2 = new Player(2);

            int[,] boardArray = Board._board;

            board.AddJeton(0, player1.currentPlayer);
            board.AddJeton(0, player2.currentPlayer);
            board.AddJeton(1, player1.currentPlayer);
            board.AddJeton(1, player2.currentPlayer);
            board.AddJeton(2, player1.currentPlayer);
            board.AddJeton(2, player2.currentPlayer);
            board.AddJeton(3, player1.currentPlayer);
            Assert.AreEqual(1, board.checkIfWinRow());
        }

         [Test]
        public void checkWinColumn()
        {
            Board board = new Board();
            Player player1 = new Player(1);
            Player player2 = new Player(2);

            int[,] boardArray = Board._board;

            board.AddJeton(0, player1.currentPlayer);
            board.AddJeton(1, player2.currentPlayer);
            board.AddJeton(0, player1.currentPlayer);
            board.AddJeton(1, player2.currentPlayer);
            board.AddJeton(0, player1.currentPlayer);
            board.AddJeton(2, player2.currentPlayer);
            board.AddJeton(0, player1.currentPlayer);
            Assert.AreEqual(1, board.checkIfWinColumn());
        }
    
    }
}