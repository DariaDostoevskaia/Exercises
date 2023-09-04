namespace Exercises
{
    public class Program
    {
        private static void Main()
        {
            //Exercise 1;
            var divisible = 7;
            var b = 3;

            Divide(divisible, b, out double[] remainder);

            Console.WriteLine(remainder[0]);
            Console.WriteLine(remainder[1]);

            void Divide(int divisible, int divider, out double[] remainder)
            {
                remainder = new double[2];

                double quotient = divisible / divider;
                double rem = divisible % divider;

                remainder[0] = quotient;
                remainder[1] = rem;
            }

            //Exercise 2;
            var array = new int[] { 1, 9, 7, -5, 5 };

            FindMax(array, out int maxValue);

            Console.WriteLine(maxValue);

            void FindMax(int[] array, out int maxValue)
            {
                maxValue = array.Max();
            }

            //Exercise 3;
            double width = 7.467;
            double height = 8.7;

            CalculateRectangleArea(width, height, out double square);

            Console.WriteLine(square);

            void CalculateRectangleArea(double width, double height, out double square)
            {
                square = width * height;
            }

            //Exercise 4;
            var firstNumber = 6;
            var secondNumber = 9;

            Swap(firstNumber, secondNumber, out string swapNumbers);

            Console.WriteLine(swapNumbers);

            void Swap(int firstNumber, int secondNumber, out string swapNumbers)
            {
                firstNumber += secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber -= secondNumber;
                swapNumbers = firstNumber + " " + secondNumber;
            }

            //Exercise 5;
            string input = "849";

            TryParseInt(input, out bool resultBool);

            Console.WriteLine(resultBool);

            void TryParseInt(string inputString, out bool resultBool)
            {
                resultBool = int.TryParse(inputString, out int i);
            }
        }
    }
}