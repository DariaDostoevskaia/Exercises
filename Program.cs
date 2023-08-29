namespace Exercises
{
    public class Program
    {
        private static void Main()
        {
            var dividend = int.Parse(Console.ReadLine());
            var divisorNumber = int.Parse(Console.ReadLine());
            CalculateDivision(dividend, out int divisor);
            Console.WriteLine(divisor);

            Console.WriteLine("Введите количество чисел: ");
            var arrayNumber = int.Parse(Console.ReadLine());
            var array = new int[arrayNumber];
            Console.WriteLine("Введите числа: ");
            for (int i = 0; i < arrayNumber; i++)
            {
                var number = int.Parse(Console.ReadLine());
                array[i] = number;
            }
            FindMax(array, out int maxValue);
            Console.WriteLine(maxValue);

            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            CalculateRectangleArea(width, height, out double square);
            Console.WriteLine(square);

            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            Swap(firstNumber, secondNumber, out string swapNumbers);
            Console.WriteLine(swapNumbers);

            var inputString = Console.ReadLine();
            var resultBool = false;
            TryParseInt(inputString, out int result);
            Console.WriteLine(resultBool);

            void CalculateDivision(int dividend, out int divisor)
            {
                divisor = divisorNumber;
                divisor /= dividend;
            }

            void FindMax(int[] array, out int maxValue)
            {
                maxValue = array.Max();
            }

            void CalculateRectangleArea(double width, double height, out double square)
            {
                square = width * height;
            }

            void Swap(int firstNumber, int secondNumber, out string swapNumbers)
            {
                firstNumber += secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber -= secondNumber;
                swapNumbers = firstNumber + " " + secondNumber;
            }

            void TryParseInt(string inputString, out int result)
            {
                resultBool = int.TryParse(inputString, out result);
            }
        }
    }
}