using OOP.Interface;

namespace OOP
{
    public static class OOP
    {
        private static void Main()
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();

            void Exercise1()
            {
                Console.WriteLine("Exercise 1.");

                var person = new Person("Fleming", "Lise", 33);

                Console.WriteLine($"{person.GetSurname()} " +
                    $"{person.GetName()}, " +
                    $"{person.GetAge()}");
            }

            void Exercise2()
            {
                Console.WriteLine("Exercise 2.");

                var student = new Student("Koval", "Irina", 19);
                student.SetStudentAbility("musical ear");
                student.SetStudentAssesment(5);

                Console.WriteLine($"Student - {student.Surname}" +
                    $" {student.Name}," +
                    $" {student.Age} years old.");
                Console.WriteLine($"Ability: {student.StudentAbility}. Assesment: {student.StudentAssesment}.");

                var teacher = new Teacher("Ivanov", "Ivan", 41);
                teacher.SetTeacherTemperament("sanguine");
                teacher.SetTeacherSubject("Mathematicks");

                Console.WriteLine($"Teacher - {teacher.PersonSurname} " +
                    $"{teacher.PersonName}, " +
                    $"{teacher.PersonAge} years old. ");
                Console.WriteLine($"Temperament: {teacher.TeacherTemperament}. Subject: {teacher.TeacherSubject}.");
            }
            void Exercise3()
            {
                Console.WriteLine("Exercise 3.");

                var personSecond = new Person("Datchin", "Valery", 43);

                Console.WriteLine($"{personSecond.GetSurname()} {personSecond.GetName()}," +
                $" {personSecond.GetAge()} y.o.");
            }
            void Exercise4()
            {
                Console.WriteLine("Exercise 4.");

                var myPerson = new Person("Fleming", "Lise", 33);
                myPerson.Print();

                var myStudent = new Student("Koval", "Irina", 19);
                myStudent.Print();

                var myTeacher = new Teacher("Ivanov", "Ivan", 41);
                myTeacher.Print();
            }

            void Exercise5()
            {
                Console.WriteLine("Exercise 5.");

                var classroom = new Classroom();
                classroom.AddPersons();
                classroom.Print();
                classroom.RemovePersons();
                classroom.ClearPersons();
            }
        }
    }
}

namespace OOP
{
    public class Classroom : IPrintable
    {
        private List<Person> _persons = new();

        public void AddPersons()
        {
            var person1 = new Person("Pupkin", "Vasiliy", 20);
            var person2 = new Person("Kirkorov", "Petya", 46);

            _persons.Add(person1);
            _persons.Add(person2);
        }

        public void RemovePersons()
        {
            _persons.RemoveAll(x => x == _persons[0]);
        }

        public void ClearPersons()
        {
            _persons.Clear();
        }

        public void Print()
        {
            foreach (var person in _persons)
            {
                string output = string.Join(" ", person.ToString());
                Console.WriteLine($"{output}");
            }
        }
    }
}

namespace OOP
{
    public class Person : IPrintable
    {
        private string _personSurname;
        private string _personName;
        private int _personAge;
        public string PersonSurname => _personSurname;

        public string PersonName => _personName;

        public int PersonAge => _personAge;

        public Person(string personSurname, string personName, int personAge)
        {
            _personSurname = personSurname;
            _personName = personName;
            _personAge = personAge;
        }

        public override string ToString()
        {
            return $"{PersonSurname} {PersonName}, {PersonAge}";
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
            Console.WriteLine($"{PersonSurname} {PersonName}, {PersonAge}");
        }

        public void Print()
        {
            Console.WriteLine($"{PersonSurname} {PersonName}, {PersonAge} y.o.");
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

namespace OOP
{
    public class Student : Person, IPrintable
    {
        private string _studentAbility;
        private int _studentAssesment;

        public Student(string personSurname, string personName, int personAge) : base(personSurname, personName, personAge)
        {
            Surname = personSurname;
            Name = personName;
            Age = personAge;
        }

        public string StudentAbility => _studentAbility;

        public int StudentAssesment => _studentAssesment;

        public string Surname { get; }

        public string Name { get; }

        public int Age { get; }

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

namespace OOP
{
    public class Teacher : Person, IPrintable
    {
        private string _teacherTemperament;
        private string _teacherSubject;

        public Teacher(string personSurname, string personName, int personAge) : base(personSurname, personName, personAge)
        {
            PersonSurname = personSurname;
            PersonName = personName;
            PersonAge = personAge;
        }

        public string TeacherTemperament => _teacherTemperament;

        public string TeacherSubject => _teacherSubject;

        public string PersonSurname { get; }

        public string PersonName { get; }

        public int PersonAge { get; }

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

namespace OOP.Interface
{
    public interface IPrintable
    {
        public void Print();
    }
}