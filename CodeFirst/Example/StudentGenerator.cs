using static System.Console;
using CodeFirst.Models;

namespace CodeFirst.Example
{
    public class StudentGenerator
    {
        private CourseContext _Database;

        public StudentGenerator(CourseContext database)
        {
            _Database = database;
        }

        public int GenerateStudents()
        {
            while (true)
            {
                CreateNewStudent();

                Write("Add new Student?(Y/N) - ");
                if (!QueryYesNo())
                    break;
            }

            return 0;
        }

        public void CreateNewStudent()
        {
            var newStudent = new Student();
            WriteLine("Write student parameters:");
            Write("\t Name: ");
            newStudent.Name = ReadLine();
            Write("\t Age: ");
            int age = -1;
            int.TryParse(ReadLine(), out age);
            newStudent.Age = age;

            Write("\t Does he visit QuickUp course?(Y/N) - ");
            if (QueryYesNo())
                _Database.Courses.Add(new CourseQuickUp { CleverStudent = newStudent });
            _Database.Students.Add(newStudent);
        }

        public void SaveChanges()
        {
            var count = _Database.SaveChanges();
            WriteLine("{0} records saved to database.", count);
        }

        public bool QueryYesNo()
        {
            int counter = 3;
            while (counter > 0)
            {
                var answer = ReadLine();

                if (answer == "y" || answer == "Y")
                {
                    return true;
                }
                else if (answer == "n" || answer == "N")
                {
                    return false;
                }

                counter--;
            }

            WriteLine("You try 3 times. Query was denied.");
            return false;
        }

        public void ShowDb()
        {
            WriteLine("All students:");
            foreach (var student in _Database.Students)
            {
                WriteLine($"\t{student.Name}: {student.Age}");
            }

            WriteLine("Students, which visit QuickUp course:");
            foreach (var CourseQuickUp in _Database.Courses)
            {
                WriteLine($"\t{CourseQuickUp.CleverStudent.Name}");
            }
        }

        public void Separator()
        {
            WriteLine("---\t---\t---\t---");
        }
    }
}
