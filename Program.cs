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
            CalculateDivision(dividend, out int divisor);
            FindMax(array, out int maxValue);
            CalculateRectangleArea(width, height, out double square);
            Swap(firstNumber, secondNumber, out string swapNumbers);
            TryParseInt(inputString, out int result);

            void CalculateDivision(int dividend, out int divisor)
            {
                var dividendNumber = int.Parse(Console.ReadLine());
                var divisorNumber = int.Parse(Console.ReadLine());

                divisor = dividendNumber / divisorNumber;
                Console.WriteLine(divisor);
            }

            void FindMax(int[] array, out int maxValue)
            {
                Console.WriteLine("Введите количество чисел: ");
                var arrayNumber = int.Parse(Console.ReadLine());
                array = new int[arrayNumber];
                Console.WriteLine("Введите числа: ");
                for (int i = 0; i < arrayNumber; i++)
                {
                    var number = int.Parse(Console.ReadLine());
                    array[i] = number;
                }
                maxValue = array.Max();
                Console.WriteLine(maxValue);
            }

            void CalculateRectangleArea(double width, double height, out double square)
            {
                width = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());

                square = width * height;
            }

            void Swap(int firstNumber, int secondNumber, out string swapNumbers)
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());

                firstNumber += secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber -= secondNumber;
                swapNumbers = firstNumber + " " + secondNumber;
                Console.WriteLine(swapNumbers);
            }

            void TryParseInt(string inputString, out int result)
            {
                inputString = Console.ReadLine();

                if (inputString == null)
                {
                    Console.WriteLine("Введите значение еще раз!");
                    TryParseInt(inputString, out result);
                }
                var resultBool = int.TryParse(inputString, out result);
                Console.WriteLine(resultBool);
            }
        }
    }
}