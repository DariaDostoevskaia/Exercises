namespace Exercises
{
    internal class Program
    {
        private static void MainLinq()
        {
            string s = " 4 6 7 8 9 0 10 45 6 56 342 ";
            string[] a = s.Split(new char[] { ' ' });
            a.ToList();
            GetEvenNumbers(a);

            void GetEvenNumbers(string[] a)
            {
                a.Where((a, result) => result % 2 == 0);
                Console.WriteLine(a);
            }
        }
    }
}