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

        public int checkIfWinRow()
        {
            int player1Win = 0;
            int player2Win = 0;
             for (var i = 0; i < 7; i++)
            {
                for (var j = 0; j < 7; j++)
                {
                    if (_board[i, j] == 0)
                    {
                        player1Win = 0;
                        player2Win = 0;
                    }
                        
                    else if (_board[i, j] == 1)
                        {
                        player1Win++;
                        player2Win = 0;
                    }
                    else
                        {
                        player1Win = 0;
                        player2Win++;
                    }
                    if(player1Win >= 4 || player2Win >= 4)
                        break;
                }
                if(player1Win >= 4 || player2Win >= 4)
                    break;

            }

            if (player1Win >= 4)
                return 1;
            else if (player2Win >=4)
                return 2;
            return 0;
        }
    }
}