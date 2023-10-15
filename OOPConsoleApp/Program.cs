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

                var student1 = new Student("Pupkin", "Vasiliy", 20);
                var student2 = new Student("Vasilyeva", "Iren", 18);

                var teacher1 = new Teacher("Kirkorov", "Petya", 46);

                var classroom = new Classroom(student1);

                classroom.AddPerson(teacher1);
                classroom.AddPerson(student2);

                classroom.Print();

                classroom.RemovePerson(student1);
                classroom.RemovePerson(teacher1);

                classroom.ClearPersons();
            }
        }
    }
}

namespace OOPConsoleApp
{
    public class Classroom : IPrintable
    {
        private Dictionary<int, Person> _persons = new();
        private Person _person;

        public Classroom(Person person)
        {
            if (person is Student
                || person is Teacher)
            {
                _person = person;
                AddPerson(_person);
            }
        }

        public void AddPerson(Person person)
        {
            var surname = person.PersonSurname;
            var name = person.PersonName;
            var age = person.PersonAge;

            if (IsValid(surname, name, age))
            {
                person = new Person(surname, name, age);
                _persons.Add(_persons.Count + 1, person);
            }
            else
                throw new Exception("A person's data cannot be null!");
        }

        public bool IsValid(string surname, string name, int age)
        {
            if (!string.IsNullOrEmpty(surname)
                && !string.IsNullOrEmpty(name))
                return true;

            return false;
        }

        public void RemovePerson(Person person)
        {
            foreach (var thisPerson in _persons)
            {
                if (thisPerson.Value == person)
                {
                    _persons.Remove(thisPerson.Key);
                    break;
                }
            }
        }

        public void ClearPersons()
        {
            _persons.Clear();
        }

        public void Print()
        {
            foreach (var person in _persons)
            {
                Console.WriteLine($"{person.Value.PersonSurname} {person.Value.PersonName}, " +
                    $"{person.Value.PersonAge}");
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

        public Person(string personSurname, string personName, int personAge)
        {
            _personSurname = personSurname;
            _personName = personName;
            _personAge = personAge;
        }

        public string PersonSurname => _personSurname;

        public string PersonName => _personName;

        public int PersonAge => _personAge;

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