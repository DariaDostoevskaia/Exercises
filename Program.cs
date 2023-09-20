using Exercises.Exercises.Interfaces;

namespace Exercises
{
    namespace Exercises.ExercisesOop
    {
        public static class ExercisesOOP
        {
            private static void Main()
            {
                //Exercise 1;

                var person = new Person.Person();
                person.GetSurname("Fleming");
                person.GetName("Lise");
                person.GetAge(33);

                Console.WriteLine($"{person.PersonSurname} {person.PersonName}, {person.PersonAge} years old");

                //Exercise 2;

                var student = new Student.Student();
                student.GetSurname("Koval");
                student.GetName("Irina");
                student.GetAge(19);

                var teacher = new Teacher.Teacher();
                teacher.GetSurname("Ivanov");
                teacher.GetName("Ivan");
                teacher.GetAge(41);

                Console.WriteLine($"{student.PersonSurname} {student.PersonName}," +
                    $" is a {nameof(Student)}, {student.PersonAge} years old");

                Console.WriteLine($"{teacher.PersonSurname} {teacher.PersonName}," +
                    $" is a {nameof(Teacher)}, {teacher.PersonAge} years old");

                //Exercise 3;

                var person1 = new Person.Person();

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

                var myPerson = new Person.Person();
                myPerson.GetSurname("Fleming");
                myPerson.GetName("Lise");
                myPerson.GetAge(33);
                myPerson.Print(myPerson.PersonSurname,
                                           myPerson.PersonName,
                                           myPerson.PersonAge);

                var myStudent = new Student.Student();
                myStudent.GetSurname("Koval");
                myStudent.GetName("Irina");
                myStudent.GetAge(19);
                myStudent.Print(myStudent.PersonSurname,
                                              myStudent.PersonName,
                                              myStudent.PersonAge);

                var myTeacher = new Teacher.Teacher();
                myTeacher.GetSurname("Ivanov");
                myTeacher.GetName("Ivan");
                myTeacher.GetAge(41);
                myTeacher.Print(myTeacher.PersonSurname,
                                              myTeacher.PersonName,
                                              myTeacher.PersonAge);

                //Exercise 5;

                var classroom = new Classroom.Classroom();
                var studentsList = new List<Student.Student>(2)
                 {
                   new Student.Student(),
                 new Student.Student(),
                   };
                var teachersList = new List<Teacher.Teacher>(2)
                  {
               new Teacher.Teacher(),
                new Teacher.Teacher(),
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
        }
    }

    namespace Exercises.Person
    {
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

            public void Print(string surname, string name, int age)
            {
                _personSurname = surname;
                _personName = name;
                _personAge = age;

                Console.WriteLine($"{_personSurname} {_personName}, {_personAge}");
            }
        }
    }

    namespace Exercises.Student
    {
        public class Student : Person.Person, IPrintable
        {
        }
    }

    namespace Exercises.Teacher
    {
        public class Teacher : Person.Person, IPrintable
        {
        }
    }

    namespace Exercises.Classroom
    {
        public class Classroom
        {
            private List<Student.Student> _students = new();
            private List<Teacher.Teacher> _teachers = new();

            public List<Student.Student> Students => _students;

            public List<Teacher.Teacher> Teachers => _teachers;

            public void AddStudent(Student.Student student)
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

            public void AddTeacher(Teacher.Teacher teacher)
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
    }

    namespace Exercises.Interfaces
    {
        public interface IPrintable
        {
            void Print(string surname, string name, int age);
        }
    }

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

    namespace Exercises.StudentSprites
    {
        public class Student
        {
            public string StudentName { get; set; }

            public int Age { get; set; }
        }
    }

    namespace Exercises.Worker
    {
        public class Worker
        {
            public string WorkerName { get; set; }

            public int Salary { get; set; }
        }
    }
}