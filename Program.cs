namespace Exercises
{
    public static class OOP
    {
        private static void Main()
        {
            //Exercise 1;

            var person = new Person();
            person.GetSurname("Fleming");
            person.GetName("Lise");
            person.GetAge(33);

            Console.WriteLine($"{person.PersonSurname} {person.PersonName}, {person.PersonAge} years old");

            //Exercise 2;

            var student = new Student();
            student.GetSurname("Koval");
            student.GetName("Irina");
            student.GetAge(19);

            var teacher = new Teacher();
            teacher.GetSurname("Ivanov");
            teacher.GetName("Ivan");
            teacher.GetAge(41);

            Console.WriteLine($"{student.PersonSurname} {student.PersonName}," +
                $" is a {nameof(Student)}, {student.PersonAge} years old");

            Console.WriteLine($"{teacher.PersonSurname} {teacher.PersonName}," +
                $" is a {nameof(Teacher)}, {teacher.PersonAge} years old");

            //Exercise 3;

            var person1 = new Person();

            var surName = person1.PersonSurname;
            surName = "Datchin";
            person1.GetSurname(surName);

            var name = person1.PersonName;
            name = "Valery";
            person1.GetName(name);

            var age = person1.PersonAge;
            age = 43;
            person1.GetAge(age);

            person1.WritePersonData(surName, name, age);

            //Exercise 4;

            var myPerson = new Person();
            myPerson.GetSurname("Fleming");
            myPerson.GetName("Lise");
            myPerson.GetAge(33);
            ((IPrintable)myPerson).Print(myPerson.PersonSurname,
                                       myPerson.PersonName,
                                       myPerson.PersonAge);

            var myStudent = new Student();
            myStudent.GetSurname("Koval");
            myStudent.GetName("Irina");
            myStudent.GetAge(19);
            ((IPrintable)myStudent).Print(myStudent.PersonSurname,
                                          myStudent.PersonName,
                                          myStudent.PersonAge);

            var myTeacher = new Teacher();
            myTeacher.GetSurname("Ivanov");
            myTeacher.GetName("Ivan");
            myTeacher.GetAge(41);
            ((IPrintable)myTeacher).Print(myTeacher.PersonSurname,
                                          myTeacher.PersonName,
                                          myTeacher.PersonAge);

            //Exercise 5;

            var classroom = new Classroom();
            var studentsList = new List<Student>(2)
            {
            new Student(),
            new Student(),
            };
            var teachersList = new List<Teacher>(2)
            {
            new Teacher(),
            new Teacher(),
            };
            classroom.AddStudent(studentsList[0]);
            classroom.AddStudent(studentsList[1]);

            classroom.AddTeacher(teachersList[0]);
            classroom.AddTeacher(teachersList[1]);

            classroom.RemoveStudent();
            classroom.RemoveTeacher();

            classroom.ClearStudents();
            classroom.ClearTeachers();
        }

        public class Person : IPrintable
        {
            public string _personSurname;
            public string _personName;
            public int _personAge;

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

            public void WritePersonData(string personSurname, string personName, int personAge)
            {
                _personSurname = personSurname;
                _personName = personName;
                _personAge = personAge;

                Console.WriteLine($"{_personSurname} {_personName}, {_personAge}");
            }

            void IPrintable.Print(string surname, string name, int age)
            {
                _personSurname = surname;
                _personName = name;
                _personAge = age;

                Console.WriteLine($"{_personSurname} {_personName}, {_personAge}");
            }
        }

        public class Student : Person, IPrintable
        {
        }

        public class Teacher : Person, IPrintable
        {
        }

        public class Classroom
        {
            private List<Student> _students = new();
            private List<Teacher> _teachers = new();

            public List<Student> Students => _students;

            public List<Teacher> Teachers => _teachers;

            public void AddStudent(Student student)
            {
                _students.Add(student);
            }

            public void RemoveStudent()
            {
                _students.RemoveAt(0);
            }

            public void ClearStudents()
            {
                _students.Clear();
            }

            public void AddTeacher(Teacher teacher)
            {
                _teachers.Add(teacher);
            }

            public void RemoveTeacher()
            {
                _teachers.RemoveAt(0);
            }

            public void ClearTeachers()
            {
                _teachers.Clear();
            }
        }

        private interface IPrintable
        {
            void Print(string surname, string name, int age);
        }
    }

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
                new Worker { WorkerName = "John", Salary = 20000 },
                new Worker { WorkerName = "Alice", Salary = 21000 },
                new Worker { WorkerName = "Bob", Salary = 22000 }
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
}