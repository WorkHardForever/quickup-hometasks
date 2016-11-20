using AspWithEf.Contracts;
using Microsoft.AspNetCore.Mvc;
using AspWithEf.Decorators;
using AspWithEf.Models;

namespace AspWithEf.Controllers
{
    [Route("api/[Controller]")]
    public class GroupsController : Controller, IGroupsCRUD
    {
        public readonly GroupDecorator Groups;

        public GroupsController(GroupDecorator groups)
        {
            Groups = groups;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Group group)
        {
            if (group?.Name == null)
                return BadRequest("Bad json request!");

            if (Groups.Create(group))
                return new OkObjectResult($"The group is creting now! Use id = {group.GroupId} that find this group.");
            else
                return BadRequest("Such name has been used yet!");
        }

        [HttpGet("{id}")]
        public IActionResult Read(int id)
        {
            var group = Groups.Read(id);
            if (group == null)
                return new OkObjectResult($"Can't find such group by id = {id}");
            else
                return new OkObjectResult(group);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Group group) =>
            new ObjectResult(Groups.Update(id, group) ? $"Data has been updated succesfully!" : "Wrong data!");

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (Groups.Delete(id))
                return new OkObjectResult("Such {id} has been deleted successfully!");
            else
                return BadRequest("Can't find this group!");
        }
    }
}
