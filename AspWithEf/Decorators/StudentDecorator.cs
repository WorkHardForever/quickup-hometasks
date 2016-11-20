﻿using AspWithEf.Models;
using System.Linq;

namespace AspWithEf.Decorators
{
    public class StudentDecorator
    {
        public readonly StudyContext Database;

        public StudentDecorator(StudyContext database)
        {
            Database = database;
        }

        //public bool Create(Group newGroup)
        //{
        //    foreach (var group in Database.Groups)
        //        if (group.Name == newGroup.Name)
        //            return false;

        //    Database.Groups.Add(newGroup);
        //    Database.SaveChanges();
        //    return true;
        //}

        //public Student Read(int id) => 
        //    Database.Students.Where(x => x.StudentId == id).FirstOrDefault();

        //public bool Delete(int id)
        //{
        //    var entityFromDb = Read(id);
        //    if (entityFromDb == null)
        //        return false;

        //    Database.Groups.Remove(entityFromDb);
        //    Database.SaveChanges();
        //    return true;
        //}

        //public bool Update(int id, Group group)
        //{
        //    var entityFromDb = Read(id);
        //    if (entityFromDb == null)
        //        return false;

        //    entityFromDb.Name = group.Name;
        //    entityFromDb.Students = entityFromDb.Students;

        //    Database.Groups.Update(entityFromDb);
        //    Database.SaveChanges();
        //    return true;
        //}
    }
}
