using System;
using System.Text;

namespace Puissance4
{
    public class Board
    {
        
        private static int[,] _board = new int[7, 7];

        public void drawnBoard ()
        {
            Console.Clear();
            Console.WriteLine(" 0 1 2 3 4 5 6 ");
            Console.WriteLine("┌─┬─┬─┬─┬─┬─┬─┐");
            for (var i = 0; i < 7; i++)
            {
                var line = new StringBuilder("│");

                for (var j = 0; j < 7; j++)
                {
                    if (_board[i, j] == 0)
                        line.Append(' ');
                    else if (_board[i, j] == 1)
                        line.Append('O');
                    else
                        line.Append('X');
                    line.Append('│');
                }

                Console.WriteLine(line.ToString());

                if (i != 6) Console.WriteLine("├─┼─┼─┼─┼─┼─┼─┤");
            }

            Console.WriteLine("└─┴─┴─┴─┴─┴─┴─┘");
            
        }

        public void AddJeton(int column, int _currentPlayer)
        {
                for (var i = 6; i > -1; i--)
                {
                    if (_board[i, column] == 0)
                    {
                        _board[i, column] = _currentPlayer;
                        break;
                    }
                }

                CheckBoardFull();
        }

        private bool CheckBoardFull()
        {
            return false;

        }

         private bool CheckColumnFull()
        {
            return false;
        }
    }
}