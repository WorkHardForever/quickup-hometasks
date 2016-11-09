using System;
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

                WriteLine("Add new Student?(Y/N) - ");
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
            newStudent.Name = ReadLine();

            _Database.Students.Add(newStudent);

            // TODO ??? //
            //Write("\t Is he visit QuickUp course?(Y/N) - ");
            //if (QueryYesNo())
            //    _Database.Courses.Add(new CourseQuickUp { CleverStudent = newStudent });
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

                if (answer == "y")
                {
                    return true;
                }
                else if (answer == "n")
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
            // TODO ??? //
            foreach (var student in _Database.Students)
            {
                WriteLine("{0}: {1}", student.Name, student.Age);
            }
        }
    }
}
