namespace Exercises
{
    public static class Program
    {
        private static void Main()
        {
            var myList = new List<int> { 1, 2, 3, 4, 5, 6 };
            GetEvenNumbers(myList);

            void GetEvenNumbers(List<int> myList)
            {
                var evenIndexes = myList.Where((num, index) => index % 2 == 0);
                Console.WriteLine(evenIndexes);
            }
        }
    }
}