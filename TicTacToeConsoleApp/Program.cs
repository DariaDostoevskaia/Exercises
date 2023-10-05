namespace TicTacToeConsoleApp
{
    public class Program
    {
        private static Dictionary<string, string> board;
        private static string currentPlayer;

        private static void Main(string[] args)
        {
            // Инициализация игрового поля и переменных
            board = new Dictionary<string, string>();

            currentPlayer = "X";

            InitializeBoard();

            // Основной цикл игры
            bool gameOver = false;
            while (!gameOver)
            {
                // Вывод игрового поля
                PrintBoard();

                // Получение хода от текущего игрока
                bool validMove = false;

                string move = "";

                while (!validMove)
                {
                    Console.WriteLine("Ход игрока " + currentPlayer);
                    Console.WriteLine("Введите координаты клетки в формате 'ряд столбец':");

                    move = Console.ReadLine();

                    validMove = IsValidMove(move);

                    if (!validMove)
                    {
                        Console.WriteLine("Некорректный ход! Попробуйте еще раз.");
                    }
                }
                // Обновление игрового поля
                board[move] = currentPlayer;

                // Проверка на победу

                if (CheckWin())
                    gameOver = true;

                if (CheckDraw())
                    gameOver = true;

                // Смена текущего игрока
                SwitchPlayer();
            }

            // Вывод окончательного игрового поля
            PrintBoard();

            Console.WriteLine("Игра окончена!");
        }

        // Инициализация игрового поля
        private static void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board.Add(i + " " + j, " ");
                }
            }
        }

        private static void PrintWinner()
        {
            Console.WriteLine("Игрок " + currentPlayer + " победил!");
        }

        private static void PrintNonWinner()
        {
            Console.WriteLine("Игра окончена вничью!");
        }

        // Вывод игрового поля на экран
        private static void PrintBoard()
        {
            Console.Clear();
            Console.WriteLine("   0  1  2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + board[i + " " + j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Проверка на корректность хода
        private static bool IsValidMove(string move)
        {
            if (!board.ContainsKey(move))
            {
                return false;
            }
            if (board[move] != " ")
            {
                return false;
            }
            return true;
        }

        // Проверка на победу
        private static bool CheckWin()
        {
            // Проверка по строкам и столбцам
            for (int i = 0; i < 3; i++)
            {
                if (board[i + " 0"] == currentPlayer && board[i + " 1"] == currentPlayer && board[i + " 2"] == currentPlayer)
                {
                    return true;
                }
                if (board["0 " + i] == currentPlayer && board["1 " + i] == currentPlayer && board["2 " + i] == currentPlayer)
                {
                    return true;
                }
            }

            // Проверка по диагоналям
            if (board["0 0"] == currentPlayer && board["1 1"] == currentPlayer && board["2 2"] == currentPlayer)
            {
                return true;
            }
            if (board["0 2"] == currentPlayer && board["1 1"] == currentPlayer && board["2 0"] == currentPlayer)
            {
                return true;
            }

            return false;
        }

        // Проверка на ничью
        private static bool CheckDraw()
        {
            foreach (KeyValuePair<string, string> cell in board)
            {
                if (cell.Value == " ")
                {
                    return false;
                }
            }
            return true;
        }

        // Смена текущего игрока
        private static void SwitchPlayer()
        {
            currentPlayer = currentPlayer == "X"
                ? "O"
                : "X";
            //if (currentPlayer == "X")
            //{
            //    currentPlayer = "O";
            //}
            //else
            //{
            //    currentPlayer = "X";
            //}
        }
    }
}