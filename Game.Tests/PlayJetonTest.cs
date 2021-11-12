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
    
    }
}