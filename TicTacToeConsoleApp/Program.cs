namespace TicTacToeConsoleApp
{
    public class Program
    {
        private static readonly Dictionary<string, string> _board = new();

        private static readonly Dictionary<int, string> _players = new()
        {
                { 0, "Х" },
                { 1, "О" }
        };

        private static string _currentPlayer;

        private static readonly int _cellsNumber = 3;

        private static void Main()
        {
            _currentPlayer = "X";
            InitializeBoard();

            while (true)
            {
                PrintBoard();

                bool validMove = false;

                string move = "";

                while (!validMove)
                {
                    Console.WriteLine("Ход игрока " + _currentPlayer);
                    Console.WriteLine("Введите координаты клетки в формате 'ряд столбец':");

                    move = Console.ReadLine();

                    validMove = IsValidMove(move);

                    if (!validMove)
                    {
                        Console.WriteLine("Некорректный ход! Попробуйте еще раз.");
                    }
                }

                _board[move] = _currentPlayer;

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
                else
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
            Console.WriteLine("Игрок " + _currentPlayer + " победил!");
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
            if (!_board.ContainsKey(move))
            {
                return false;
            }

            if (_board[move] != " ")
            {
                return false;
            }
            return true;
        }

        private static bool IsWinResult()
        {
            for (int i = 0; i < _cellsNumber; i++)
            {
                if (_board[i + " 0"] == _currentPlayer
                    && _board[i + " 1"] == _currentPlayer
                    && _board[i + " 2"] == _currentPlayer)
                {
                    return true;
                }

                if (_board["0 " + i] == _currentPlayer
                    && _board["1 " + i] == _currentPlayer
                    && _board["2 " + i] == _currentPlayer)
                {
                    return true;
                }
            }

            if (_board["0 0"] == _currentPlayer
                && _board["1 1"] == _currentPlayer
                && _board["2 2"] == _currentPlayer)
            {
                return true;
            }

            if (_board["0 2"] == _currentPlayer
                && _board["1 1"] == _currentPlayer
                && _board["2 0"] == _currentPlayer)
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
            var currentIndex = 0;
            foreach (KeyValuePair<int, string> player in _players)
            {
                if (player.Value == _currentPlayer)
                {
                    break;
                }
                currentIndex++;
            }

            currentIndex = (currentIndex + 1) % _players.Count;

            _currentPlayer = _players[currentIndex];
        }
    }
}