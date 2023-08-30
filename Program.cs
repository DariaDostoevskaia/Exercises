using System.Collections;
using System.Collections.Generic;
using static Exercises.Program;

namespace Exercises
{
    public static class Program
    {
        private static void Main()
        {
            //Exercise 1;

            var myList = new List<int> { 5543210, 273, 8, 41, 87643, 6 };
            IEnumerable<int> evenNumbers;

            GetEvenNumbers(myList);

            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }

            void GetEvenNumbers(List<int> myList)
            {
                evenNumbers = myList.Where(n => n % 2 == 0);
            }

            //Exercise 2;

            List<Student> students = new List<Student>()
            {
                new Student { StudentName = "John", Age = 20 },
                new Student { StudentName = "Alice", Age = 21 },
                new Student { StudentName = "Bob", Age = 22 },
                new Student { StudentName = "Kate", Age = 20 },
                new Student { StudentName = "Mike", Age = 21 }
            };

            IEnumerable<IGrouping<int, Student>> groupedStudents;

            GetGroupStudents(students);

            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Age: {group.Key}, Count: {group.Count()}");
            }

            void GetGroupStudents(IEnumerable<Student> students)
            {
                groupedStudents = from student in students
                                  group student by student.Age;
            }

            //Exercise 3;

            List<Worker> workers = new List<Worker>()
            {
                new Worker { WorkerName = "John", Salary = 20000 },
                new Worker { WorkerName = "Alice", Salary = 21000 },
                new Worker { WorkerName = "Bob", Salary = 22000 }
            };

            IEnumerable<IGrouping<string, Worker>> groupedWorkers;

            GetGroupWorkers(workers);

            foreach (var group in groupedWorkers)
            {
                Console.WriteLine(group.Key);
            }

            void GetGroupWorkers(IEnumerable<Worker> workers)
            {
                groupedWorkers = from worker in workers
                                 group worker by worker.WorkerName;
            }

            //Exercise 4;

            var cities = new List<string>()
            {
            "New York",
            "Moscow",
            "Cheboksary",
            "Baku",
            "Madrid",
            "Paris",
            "Astana",
            "Lisbon"
            };

            IOrderedEnumerable<string> alphabeticallyCities;

            GetCitiesAlphabetically(cities);

            foreach (var city in alphabeticallyCities)
                Console.WriteLine(city);

            void GetCitiesAlphabetically(List<string> cities)
            {
                alphabeticallyCities = from city in cities
                                       orderby city
                                       select city;
            }

            //Exercise 5;

            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            int sum = 0;
            GetSum(numbers);
            Console.WriteLine(sum);

            void GetSum(List<int> numbers)
            {
                sum = numbers.Aggregate((x, y) => x + y);
            }
        }
    }

    public class Student
    {
        public string StudentName { get; set; }

        public int Age { get; set; }
    }

    public class Worker
    {
        public string WorkerName { get; set; }

        public int Salary { get; set; }
    }
}