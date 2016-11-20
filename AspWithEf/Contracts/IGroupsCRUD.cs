using AspWithEf.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspWithEf.Contracts
{
    public interface IGroupsCRUD
    {
        IActionResult Create([FromBody] Group group);
        IActionResult Read(int id);
        IActionResult Update(int id, [FromBody] Group group);
        IActionResult Delete(int id);
    }
}
