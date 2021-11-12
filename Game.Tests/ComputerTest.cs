using System;
using System.Collections.Generic;
using System.Linq;
using Puissance4;
using NUnit.Framework;

namespace Game.Tests
{
    public class ComputerTest
    {
        [Test]
        public void checkComputerPlay()
        {
            Board board = new Board();
            Computer player2 = new Computer(2);

            int[,] boardArray = Board._board;

            int computerColumn = player2.play();

            board.AddJeton(computerColumn, player2.currentPlayer);
            Assert.AreEqual(2, boardArray[6,computerColumn]);
        }
    
    }
}