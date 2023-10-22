namespace Exercises
{

    namespace Exercises.Sprites
    {
        public static class Sprites
        {
            private static void MainSprites()
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

                List<StudentSprites.Student> students = new List<StudentSprites.Student>(5)
            {
                new StudentSprites.Student { StudentName = "John", Age = 20 },
                new StudentSprites.Student { StudentName = "Alice", Age = 21 },
                new StudentSprites.Student { StudentName = "Bob", Age = 22 },
                new StudentSprites.Student { StudentName = "Kate", Age = 20 },
                new StudentSprites.Student { StudentName = "Mike", Age = 21 }
            };

                IEnumerable<IGrouping<int, StudentSprites.Student>> groupedStudents;

                GetGroupStudents(students);

                foreach (var group in groupedStudents)
                {
                    Console.WriteLine($"Age: {group.Key}, Count: {group.Select(groupedStudents => students).Count()}");
                }

                void GetGroupStudents(IEnumerable<StudentSprites.Student> students)
                {
                    groupedStudents = students.GroupBy(student => student.Age);
                }

                //Exercise 3;

                List<Worker.Worker> workers = new List<Worker.Worker>()
            {
                new Worker.Worker { WorkerName = "John", Salary = 20000 },
                new Worker.Worker { WorkerName = "Alice", Salary = 21000 },
                new Worker.Worker  { WorkerName = "Bob", Salary = 22000 }
            };

                var groupedWorkers = new List<string>();

                GetGroupWorkers(workers);

                foreach (var worker in groupedWorkers)
                {
                    Console.WriteLine(worker);
                }

                void GetGroupWorkers(List<Worker.Worker> workers)
                {
                    groupedWorkers = workers.Select(worker => worker.WorkerName).ToList();
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

                List<string> alphabeticallyCities;

                GetCitiesAlphabetically(cities);

                foreach (var city in alphabeticallyCities)
                    Console.WriteLine(city);

                void GetCitiesAlphabetically(List<string> cities)
                {
                    alphabeticallyCities = (cities.OrderBy(city => city).ToList());
                }

                //Exercise 5;

                var numbers = new List<int> { 1, 2, 3, 4, 5 };
                var sum = 0;
                GetSum(numbers);
                Console.WriteLine(sum);

                void GetSum(List<int> numbers)
                {
                    sum = numbers.Sum();
                }
            }
        }
    }
}