namespace TicTacToeConsoleApp
{
    public class Program
    {
        private static readonly Dictionary<string, string> _board = new();

        private static readonly string[] _players = { "X", "O" };

        private static int _currentIndex = 0;

        private static readonly int _cellsNumber = 3;

        private static void Main()
        {
            InitializeBoard();

            while (true)
            {
                PrintBoard();

                bool validMove = false;

                string move = "";

                while (!validMove)
                {
                    Console.WriteLine("Ход игрока " + _players[_currentIndex]);
                    Console.WriteLine("Введите координаты клетки в формате 'ряд столбец':");

                    move = Console.ReadLine();

                    validMove = IsValidMove(move);

                    if (!validMove)
                    {
                        Console.WriteLine("Некорректный ход! Попробуйте еще раз.");
                    }
                }

                _board[move] = _players[_currentIndex];

                if (IsWinResult())
                {
                    PrintBoard();
                    PrintWinner();

                    Console.WriteLine("Игра окончена!");

                    return;
                }
                if (IsDrawResult())
                {
                    PrintBoard();
                    PrintNonWinner();

                    Console.WriteLine("Игра окончена!");
                    return;
                }

                SwitchPlayer();
            }
        }

        private static void InitializeBoard()
        {
            for (int i = 0; i < _cellsNumber; i++)
            {
                for (int j = 0; j < _cellsNumber; j++)
                {
                    _board.Add(i + " " + j, " ");
                }
            }
        }

        private static void PrintWinner()
        {
            Console.WriteLine("Игрок " + _players[_currentIndex] + " победил!");
        }

        private static void PrintNonWinner()
        {
            Console.WriteLine("Игра окончена вничью!");
        }

        private static void PrintBoard()
        {
            Console.Clear();
            Console.WriteLine("   0  1  2");

            for (int i = 0; i < _cellsNumber; i++)
            {
                Console.Write(i + " ");

                for (int j = 0; j < _cellsNumber; j++)
                {
                    Console.Write("[" + _board[i + " " + j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static bool IsValidMove(string move)
        {
            if (_board.Any(cell => cell.Value == " "))
            {
                return false;
            }

            if (!string.IsNullOrWhiteSpace(_board[move]))
            {
                return false;
            }
            return true;
        }

        private static bool IsWinResult()
        {
            for (int i = 0; i < _cellsNumber; i++)
            {
                if (_board[i + " 0"] == _players[_currentIndex]
                    && _board[i + " 1"] == _players[_currentIndex]
                    && _board[i + " 2"] == _players[_currentIndex])
                {
                    return true;
                }

                if (_board["0 " + i] == _players[_currentIndex]
                    && _board["1 " + i] == _players[_currentIndex]
                    && _board["2 " + i] == _players[_currentIndex])
                {
                    return true;
                }
            }

            if (_board["0 0"] == _players[_currentIndex]
                && _board["1 1"] == _players[_currentIndex]
                && _board["2 2"] == _players[_currentIndex])
            {
                return true;
            }

            if (_board["0 2"] == _players[_currentIndex]
                && _board["1 1"] == _players[_currentIndex]
                && _board["2 0"] == _players[_currentIndex])
            {
                return true;
            }

            return false;
        }

        private static bool IsDrawResult()
        {
            foreach (KeyValuePair<string, string> cell in _board)
            {
                if (string.IsNullOrWhiteSpace(cell.Value))
                {
                    return false;
                }
            }
            return true;
        }

        private static void SwitchPlayer()
        {
            _currentIndex = ++_currentIndex % _players.Length;
        }
    }
}