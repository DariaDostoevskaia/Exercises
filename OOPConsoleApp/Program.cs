using OOPConsoleApp.Interface;

namespace OOPConsoleApp
{
    internal class Program
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

                Console.WriteLine($"Student - {student.PersonSurname}" +
                    $" {student.PersonName}," +
                    $" {student.PersonAge} years old.");
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

                var classroom = new Classroom("Pupkin", "Vasiliy", 20);

                classroom.AddPerson("Kirkorov", "Petya", 46);
                classroom.AddPerson("Vasilyeva", "Iren", 18);

                classroom.Print();

                classroom.RemovePerson("Pupkin", "Vasiliy", 20);
                classroom.RemovePerson("Kirkorov", "Petya", 46);

                classroom.Print();

                classroom.ClearPersons();
            }
        }
    }
}

namespace OOPConsoleApp
{
    public class Classroom : IPrintable
    {
        private List<Person> _persons = new();
        private Person _person;

        public Classroom(string surname, string name, int age)
        {
            AddPerson(surname, name, age);
        }

        public void AddPerson(string surname, string name, int age)
        {
            if (IsValid(surname, name, age))
            {
                _person = new Person(surname, name, age);
                _persons.Add(_person);
            }
            else
                throw new Exception("A person's data cannot be null!");
        }

        public bool IsValid(string surname, string name, int age)
        {
            if (surname != null
                && name != null
                && age != null)
                return true;

            return false;
        }

        public void RemovePerson(string surname, string name, int age)
        {
            _persons.RemoveAll(person =>
                person.PersonSurname == surname
                && person.PersonName == name
                && person.PersonAge == age);
        }

        public void ClearPersons()
        {
            _persons.Clear();
        }

        public void Print()
        {
            foreach (var person in _persons)
            {
                Console.WriteLine($"{person.PersonSurname} {person.PersonName}, {person.PersonAge}");
            }
        }
    }
}

namespace OOPConsoleApp
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

namespace OOPConsoleApp
{
    public class Student : Person, IPrintable
    {
        private string _studentAbility;
        private int _studentAssesment;

        public Student(string personSurname, string personName, int personAge)
            : base(personSurname, personName, personAge)
        {
        }

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

namespace OOPConsoleApp
{
    public class Teacher : Person, IPrintable
    {
        private string _teacherTemperament;
        private string _teacherSubject;

        public Teacher(string personSurname, string personName, int personAge)
            : base(personSurname, personName, personAge)
        {
        }

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

namespace OOPConsoleApp.Interface
{
    public interface IPrintable
    {
        public void Print();
    }
}