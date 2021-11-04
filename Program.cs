using System;
using System.Text;

namespace Puissance4
{
    class Program
    {
        private static int[,] _board = new int[7, 7];
        private static int _currentPlayer = 1;

        static void Main(string[] args)
        {
            while (true)
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
                Console.WriteLine($"Joueur {_currentPlayer}, en quelle colonne jouez-vous ?");

                if (!int.TryParse(Console.ReadLine(), out int column) || column < 0 || column > 6) continue;
                
                var full = true;
                for (var i = 6; i > -1; i--)
                {
                    if (_board[i, column] == 0)
                    {
                        _board[i, column] = _currentPlayer;
                        full = false;
                        break;
                    }
                }

                if (!full) _currentPlayer = _currentPlayer == 1 ? 2 : 1;
            }
        }
    }
}
