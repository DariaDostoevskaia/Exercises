namespace Exercises
{
    public class Program
    {
        private static void Main()
        {
            var dividend = 6;
            var divisorNumber = 3;
            CalculateDivision(dividend, out int divisor);
            Console.WriteLine(divisor);

            var array = new int[] { 1, 9, 7, -5, 5 };

            FindMax(array, out int maxValue);
            Console.WriteLine(maxValue);

            double width = 7.467;
            double height = 8.7;
            CalculateRectangleArea(width, height, out double square);
            Console.WriteLine(square);

            var firstNumber = 6;
            var secondNumber = 9;
            Swap(firstNumber, secondNumber, out string swapNumbers);
            Console.WriteLine(swapNumbers);

            string inputString = "fjhskdh8494";
            bool resultBool;
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