namespace Exercises
{
    public class Sprites
    {
        private static void Main()
        {
            //Exercise 1;
            var divisible = 7;
            var divider = 3;

            Divide(divisible, divider, out double[] remainder);

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

            if (TryParseToInt(input, out int result))
                Console.WriteLine(result);
            else
                Console.WriteLine("Error!");

            bool TryParseToInt(string inputString, out int result)
            {
                return int.TryParse(inputString, out result);
    public static class ExercisesDictionary
    {
        private static void Main()
        {
            //Exercise1();
            Exercise2();

            void Exercise1()
            {
                Console.WriteLine("Exercise 1.");

                var employees = new Dictionary<int, Students>
                 {
                { 1, new Students(4, "John") },
                { 2, new Students(5, "Henry") }
                  };
                foreach (KeyValuePair<int, Students> pair in employees)
                {
                    Console.WriteLine($"Student {pair.Value.Name}, estimation: {pair.Value.AverageRating}.");
                }
            }
            void Exercise2()
            {
                var englishDictionary = new Dictionary<string, string>();
                var franchDictionary = new Dictionary<string, string>();
            }
        }
    }
}

namespace Exercises
{
    public class Students
    {
        public int AverageRating { get; }
        public string Name { get; }

        public Students(int averageRating, string name)
        {
            AverageRating = averageRating;
            Name = name;
        }
    }
}

namespace Exercises
{
    public static class ExercisesOOP
    {
        private static void MainOOP()
        {
            //Exercise 1;
            Console.WriteLine("Exercise 1.");

            var person = new Person();
            person.SetSurname("Fleming");
            person.SetName("Lise");
            person.SetAge(33);

            Console.WriteLine($"{person.GetSurname()} " +
                $"{person.GetName()}, " +
                $"{person.GetAge()}");

            //Exercise 2;
            Console.WriteLine("Exercise 2.");

            var student = new Student();
            student.SetSurname("Koval");
            student.SetName("Irina");
            student.SetAge(19);

            student.SetStudentAbility("musical ear");
            student.SetStudentAssesment(5);

            Console.WriteLine($"Student - {student.PersonSurname}" +
                $" {student.PersonName}," +
                $" {student.PersonAge} years old.");
            Console.WriteLine($"Ability: {student.StudentAbility}. Assesment: {student.StudentAssesment}.");

            var teacher = new Teacher();
            teacher.SetSurname("Ivanov");
            teacher.SetName("Ivan");
            teacher.SetAge(41);

            teacher.SetTeacherTemperament("sanguine");
            teacher.SetTeacherSubject("Mathematicks");

            Console.WriteLine($"Teacher - {teacher.PersonSurname} " +
                $"{teacher.PersonName}, " +
                $"{teacher.PersonAge} years old. ");
            Console.WriteLine($"Temperament: {teacher.TeacherTemperament}. Subject: {teacher.TeacherSubject}.");

            //Exercise 3;
            Console.WriteLine("Exercise 3.");

            var personSecond = new Person();
            personSecond.PersonSurname = "Datchin";
            personSecond.PersonName = "Valery";
            personSecond.PersonAge = 43;

            Console.WriteLine($"{personSecond.GetSurname()} {personSecond.GetName()}," +
            $" {personSecond.GetAge()} y.o.");

            ////Exercise 4;
            Console.WriteLine("Exercise 4.");

            var myPerson = new Person();
            myPerson.SetSurname("Fleming");
            myPerson.SetName("Lise");
            myPerson.SetAge(33);
            myPerson.Print();

            var myStudent = new Student();
            myStudent.SetSurname("Koval");
            myStudent.SetName("Irina");
            myStudent.SetAge(19);
            myStudent.Print();

            var myTeacher = new Teacher();
            myTeacher.SetSurname("Ivanov");
            myTeacher.SetName("Ivan");
            myTeacher.SetAge(41);
            myTeacher.Print();

            ////Exercise 5;
            Console.WriteLine("Exercise 5.");

            var classroom = new Classroom();
            classroom.AddPersons();
            classroom.Print();
            classroom.RemovePersons();
            classroom.ClearPersons();
        }
    }
}

namespace Exercises
{
    public class Person : IPrintable
    {
        private string _personSurname;
        private string _personName;
        private int _personAge;

        public string PersonSurname
        {
            set { SetSurname(_personSurname = value); }
            get { return GetSurname(); }
        }

        public string PersonName
        {
            set { SetName(_personName = value); }
            get { return GetName(); }
        }

        public int PersonAge
        {
            set
            {
                SetAge(_personAge = value);
            }
            get
            {
                return GetAge();
            }
        }

        public void SetSurname(string personSurname)
        {
            _personSurname = personSurname;
        }

        public void SetName(string personName)
        {
            _personName = personName;
        }

        public void SetAge(int personAge)
        {
            _personAge = personAge;
        }

        public void WritePersonData()
        {
            Console.WriteLine($"{_personSurname} {_personName}, {_personAge}");
        }

        public void Print()
        {
            Console.WriteLine($"{_personSurname} {_personName}, {_personAge} y.o.");
        }

        public string GetSurname()
        {
            return _personSurname;
        }

        public string GetName()
        {
            return _personName;
        }

        public int GetAge()
        {
            return _personAge;
        }
    }
}

namespace Exercises
{
    public class Student : Person, IPrintable
    {
        private string _studentAbility;
        private int _studentAssesment;

        public string StudentAbility => _studentAbility;

        public int StudentAssesment => _studentAssesment;

        public void SetStudentAbility(string studentAbility)
        {
            _studentAbility = studentAbility;
        }

        public void SetStudentAssesment(int assesment)
        {
            _studentAssesment = assesment;
        }
    }
}

namespace Exercises
{
    public class Teacher : Person, IPrintable
    {
        private string _teacherTemperament;
        private string _teacherSubject;

        public string TeacherTemperament => _teacherTemperament;

        public string TeacherSubject => _teacherSubject;

        public void SetTeacherTemperament(string teacherTemperament)
        {
            _teacherTemperament = teacherTemperament;
        }

        public void SetTeacherSubject(string subject)
        {
            _teacherSubject = subject;
        }
    }
}

namespace Exercises
{
    public class Classroom : IPrintable
    {
        private List<Person> _persons = new List<Person>();
        private Student _student;
        private Teacher _teacher;

        public void AddPersons()
        {
            _persons.Add(_teacher);
            _persons.Add(_student);
        }

        public void RemovePersons()
        {
            for (int i = 0; i < _persons.Count; i++)
            {
                _persons.RemoveAt(i);
            }
        }

        public void ClearPersons()
        {
            _persons.Clear();
        }

        public void Print()
        {
            Console.WriteLine($"{_persons.Count}");
        }
    }
}

namespace Exercises
{
    public interface IPrintable
    {
        public void Print();
    }
}

namespace Exercises.Sprites
{
    public static class ExercisesSprites
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

            List<Student> students = new List<Student>(5)
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
                Console.WriteLine($"Age: {group.Key}, Count: {group.Select(groupedStudents => students).Count()}");
            }

            void GetGroupStudents(IEnumerable<Student> students)
            {
                groupedStudents = students.GroupBy(student => student.Age);
            }

            //Exercise 3;

            List<Worker> workers = new List<Worker>()
            {
                new Worker{ WorkerName = "John", Salary = 20000 },
                new Worker { WorkerName = "Alice", Salary = 21000 },
                new Worker  { WorkerName = "Bob", Salary = 22000 }
            };

            var groupedWorkers = new List<string>();

            GetGroupWorkers(workers);

            foreach (var worker in groupedWorkers)
            {
                Console.WriteLine(worker);
            }

            void GetGroupWorkers(List<Worker> workers)
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
                alphabeticallyCities = cities
                    .OrderBy(city => city)
                    .ToList();
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

namespace Exercises.Sprites
{
    public class Student
    {
        public string StudentName { get; set; }

        public int Age { get; set; }
    }
}

namespace Exercises.Sprites
{
    public class Worker
    {
        public string WorkerName { get; set; }

        public int Salary { get; set; }
    }
}