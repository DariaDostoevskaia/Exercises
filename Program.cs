namespace Exercises
{
    internal class Program
    {
        private static readonly int dividend;

        private static readonly int[] array;

        private static readonly double width;
        private static readonly double height;

        private static readonly int firstNumber;
        private static readonly int secondNumber;

        private static readonly string inputString;

        private static void Main(string[] args)
        {
            Exercise1(dividend, out int divisor);
            FindMax(array, out int maxValue);
            CalculateRectangleArea(width, height, out double square);
            Swap(firstNumber, secondNumber, out int[] swapNumbers);
            TryParseInt(inputString, out bool result);

            void Exercise1(int dividend, out int divisor)
            {
                dividend = Convert.ToInt32(Console.ReadLine());
                divisor = Convert.ToInt32(Console.ReadLine());

                if (dividend == null
                    || divisor == null)
                {
                    Console.WriteLine("Попробуй еще раз. Введите значения.");
                    Exercise1(dividend, out divisor);
                }

                divisor = dividend / divisor;
            }

            void FindMax(int[] array, out int maxValue)
            {
                Console.WriteLine("Введите количество чисел: ");
                var arrayNumber = Convert.ToInt32(Console.ReadLine());

                if (arrayNumber == null)
                {
                    Console.WriteLine("Введите значение еще раз!");
                    FindMax(array, out maxValue);
                }

                Console.WriteLine("Введите числа: ");
                for (int i = 0; i < arrayNumber; i++)
                {
                    var number = Convert.ToInt32(Console.ReadLine());
                    array[i] = number;
                }
                maxValue = array.Max();
            }

            void CalculateRectangleArea(double width, double height, out double square)
            {
                width = Convert.ToDouble(Console.ReadLine());
                height = Convert.ToDouble(Console.ReadLine());

                if (width == null
                   || height == null)
                {
                    Console.WriteLine("Попробуй еще раз. Введите значения.");
                    CalculateRectangleArea(width, height, out square);
                }
                square = width * height;
            }

            void Swap(int firstNumber, int secondNumber, out int[] swapNumbers)
            {
                firstNumber = Convert.ToInt32(Console.ReadLine());
                secondNumber = Convert.ToInt32(Console.ReadLine());

                if (firstNumber == null
                   || secondNumber == null)
                {
                    Console.WriteLine("Попробуй еще раз. Введите значения.");
                    Swap(firstNumber, secondNumber, out swapNumbers);
                }
                swapNumbers = new int[] { firstNumber, secondNumber };

                for (int i = swapNumbers.Length - 1; i >= 0; i--)
                {
                    Console.Write(swapNumbers[i] + " ");
                }
            }

            void TryParseInt(string inputString, out bool result)
            {
                inputString = Convert.ToString(Console.ReadLine());
                int intNumber;

                if (inputString == null)
                {
                    Console.WriteLine("Введите значение еще раз!");
                    TryParseInt(inputString, out result);
                }
                result = int.TryParse(inputString, out intNumber);
                Console.WriteLine(result);
            }
        }
    }
}