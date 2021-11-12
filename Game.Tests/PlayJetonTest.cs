using System;
using System.Collections.Generic;
using System.Linq;
using Puissance4;
using NUnit.Framework;

namespace Game.Tests
{
    public class PlayJetonTest
    {
        [Test]
        public void checkJetonPlace()
        {
            Board board = new Board();
            Player player1 = new Player(1);

            int[,] boardArray = Board._board;

            board.AddJeton(6, player1.currentPlayer);
            Assert.AreEqual(1, boardArray[6,6]);
        }

        // [Test]
        // public void checkComputerPlay()
        // {
        //     Board board = new Board();
        //     Computer player2 = new Computer(2);

        //     int[,] boardArray = Board._board;

        //     int computerColumn = player2.play();

        //     board.AddJeton(computerColumn, player2.currentPlayer);
        //     Assert.AreEqual(2, boardArray[6,computerColumn]);
        // }
    
    }
}