using Microsoft.AspNetCore.Mvc;
using AspWithEf.Contracts;
using AspWithEf.Decorators;
using AspWithEf.Models;

namespace AspWithEf.Controllers
{
    public class StudentsController : Controller, IStudentsCRUD
    {
        public readonly StudentDecorator Students;

        public StudentsController(StudentDecorator students)
        {
            Students = students;
        }

        [HttpGet("api/groups/{id}/students")]
        public IActionResult Read(int id)
        {
            return new ObjectResult($"Hello! {id}");
        }

        //[HttpPost("{groupId}/[controller]")]
        //public IActionResult Create([FromBody] Student student)
        //{
        //    if (student?.Name == null)
        //        return BadRequest("Bad json request!");

        //    if (Students.Create(student))
        //        return new OkObjectResult($"The student is creting now! Use id = {student.GroupId} that find this student.");
        //    else
        //        return BadRequest("Such name has been used yet!");
        //}

        //[HttpGet("{id}")]
        //public IActionResult Read(int id)
        //{
        //    var student = Students.Read(id);
        //    if (student == null)
        //        return new OkObjectResult($"Can't find such student by id = {id}");
        //    else
        //        return new OkObjectResult(student);
        //}

        //[HttpPut("{id}")]
        //public IActionResult Update(int id, [FromBody] Student student) =>
        //    new ObjectResult(Students.Update(id, student) ? $"Data has been updated succesfully!" : "Wrong data!");

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    if (Students.Delete(id))
        //        return new OkObjectResult("Such {id} has been deleted successfully!");
        //    else
        //        return BadRequest("Can't find this student!");
        //}
    }
}
