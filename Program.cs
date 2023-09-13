using System.Globalization;

namespace Exercises
{
    public static class OOP
    {
        private static void Main()
        {
            //Exercise 1;

            //var person = new Person();
            //person.GetSurname("Fleming");
            //person.GetName("Lise");
            //person.GetAge(33);

            //Console.WriteLine($"{person.PersonSurname} {person.PersonName}, {person.PersonAge} years old");

            //Exercise 2;

            //var myStudent = new Student();
            //myStudent.GetSurname("Koval");
            //myStudent.GetName("Irina");
            //myStudent.GetAge(19);

            //var myTeacher = new Teacher();
            //myTeacher.GetSurname("Ivanov");
            //myTeacher.GetName("Ivan");
            //myTeacher.GetAge(43);

            //Console.WriteLine($"{myStudent.PersonSurname} {myStudent.PersonName}," +
            //    $" is a {nameof(Student)}, {myStudent.PersonAge} years old");

            //Console.WriteLine($"{myTeacher.PersonSurname} {myTeacher.PersonName}," +
            //    $" is a {nameof(Teacher)}, {myTeacher.PersonAge} years old");

            //Exercise 3;

            var myPerson = new Person();

            var surName = myPerson.PersonSurname;
            surName = "Datchin";
            myPerson.GetSurname(surName);

            var name = myPerson.PersonName;
            name = "Valery";
            myPerson.GetName(name);

            var age = myPerson.PersonAge;
            age = 43;
            myPerson.GetAge(age);

            Console.WriteLine();
        }

        public class Person
        {
            private string _personSurname;
            private string _personName;
            private int _personAge;

            public string PersonSurname => _personSurname;

            public string PersonName => _personName;

            public int PersonAge => _personAge;

            public void GetSurname(string personSurname)
            {
                _personSurname = personSurname;
            }

            public void GetName(string personName)
            {
                _personName = personName;
            }

            public void GetAge(int personAge)
            {
                _personAge = personAge;
            }

            public void GetPersonData(string personSurname, string personName, int personAge)
            {
                _personSurname = personSurname;
                _personName = personName;
                _personAge = personAge;
                Console.WriteLine($"{_personSurname} {_personName}, {_personAge}");
            }
        }

        public class Student : Person
        {
        }

        public class Teacher : Person
        {
        }
    }

    //    public static class Program
    //    {
    //        private static void Main()
    //        {
    //            //Exercise 1;

    //            var myList = new List<int> { 5543210, 273, 8, 41, 87643, 6 };
    //            IEnumerable<int> evenNumbers;

    //            GetEvenNumbers(myList);

    //            foreach (var number in evenNumbers)
    //            {
    //                Console.Write(number + " ");
    //            }

    //            void GetEvenNumbers(List<int> myList)
    //            {
    //                evenNumbers = myList.Where(n => n % 2 == 0);
    //            }

    //            //Exercise 2;

    //            List<Student> students = new List<Student>(5)
    //        {
    //            new Student { StudentName = "John", Age = 20 },
    //            new Student { StudentName = "Alice", Age = 21 },
    //            new Student { StudentName = "Bob", Age = 22 },
    //            new Student { StudentName = "Kate", Age = 20 },
    //            new Student { StudentName = "Mike", Age = 21 }
    //        };

    //            IEnumerable<IGrouping<int, Student>> groupedStudents;

    //            GetGroupStudents(students);

    //            foreach (var group in groupedStudents)
    //            {
    //                Console.WriteLine($"Age: {group.Key}, Count: {group.Select(groupedStudents => students).Count()}");
    //            }

    //            void GetGroupStudents(IEnumerable<Student> students)
    //            {
    //                groupedStudents = students.GroupBy(student => student.Age);
    //            }

    //            //Exercise 3;

    //            List<Worker> workers = new List<Worker>()
    //        {
    //            new Worker { WorkerName = "John", Salary = 20000 },
    //            new Worker { WorkerName = "Alice", Salary = 21000 },
    //            new Worker { WorkerName = "Bob", Salary = 22000 }
    //        };

    //            var groupedWorkers = new List<string>();

    //            GetGroupWorkers(workers);

    //            foreach (var worker in groupedWorkers)
    //            {
    //                Console.WriteLine(worker);
    //            }

    //            void GetGroupWorkers(List<Worker> workers)
    //            {
    //                groupedWorkers = workers.Select(worker => worker.WorkerName).ToList();
    //            }

    //            //Exercise 4;

    //            var cities = new List<string>()
    //        {
    //        "New York",
    //        "Moscow",
    //        "Cheboksary",
    //        "Baku",
    //        "Madrid",
    //        "Paris",
    //        "Astana",
    //        "Lisbon"
    //        };

    //            List<string> alphabeticallyCities;

    //            GetCitiesAlphabetically(cities);

    //            foreach (var city in alphabeticallyCities)
    //                Console.WriteLine(city);

    //            void GetCitiesAlphabetically(List<string> cities)
    //            {
    //                alphabeticallyCities = (cities.OrderBy(city => city).ToList());
    //            }

    //            //Exercise 5;

    //            var numbers = new List<int> { 1, 2, 3, 4, 5 };
    //            var sum = 0;
    //            GetSum(numbers);
    //            Console.WriteLine(sum);

    //            void GetSum(List<int> numbers)
    //            {
    //                sum = numbers.Sum();
    //            }
    //        }
    //public class Student
    //{
    //    public string StudentName { get; set; }

    //    public int Age { get; set; }
    //}

    //public class Worker
    //{
    //    public string WorkerName { get; set; }

    //    public int Salary { get; set; }
    //}
    //    }
}