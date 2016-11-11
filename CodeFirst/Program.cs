using System;
using static System.Console;
using CodeFirst.Models;
using CodeFirst.Example;

namespace CodeFirst
{
    public class Program
    {
        public static void Main()
        {
            var db = new CourseContext();
            var generator = new StudentGenerator(db);
            generator.GenerateStudents();
            generator.Separator();
            generator.SaveChanges();
            generator.Separator();
            generator.ShowDb();
            ReadKey();
        }
    }
}
